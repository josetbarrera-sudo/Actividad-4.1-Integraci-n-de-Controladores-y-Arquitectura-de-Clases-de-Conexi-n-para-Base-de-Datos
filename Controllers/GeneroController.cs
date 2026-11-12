/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using Biblioteca.Data;
using Biblioteca.Models;
using MongoDB.Driver;
using MySql.Data.MySqlClient;

namespace Biblioteca.Controllers
{
    // Documento sencillo para guardar un género en MongoDB.
    // La propiedad Id se convierte automáticamente en el campo _id del documento.
    public class GeneroDocumento
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string RutaImagen { get; set; } = string.Empty;
        public bool EsActivo { get; set; }
    }

    // Actividad 4.1: capa Controller. Ya no usa listas en memoria;
    // pide la conexión a las clases centralizadas y ejecuta comandos SQL / consultas documentales.
    public class GeneroController
    {
        // ---------------------------- MariaDB (SQL) ----------------------------

        // Crea la tabla si todavía no existe.
        public bool CrearTablaMariaDB()
        {
            MySqlConnection? conexion = ConexionMariaDB.ObtenerConexion();
            if (conexion == null) return false;

            string sql = @"CREATE TABLE IF NOT EXISTS generos (
                               id INT PRIMARY KEY,
                               nombre VARCHAR(100) NOT NULL,
                               descripcion VARCHAR(255) NOT NULL,
                               ruta_imagen VARCHAR(255),
                               es_activo TINYINT(1) NOT NULL)";
            using (MySqlCommand comando = new MySqlCommand(sql, conexion))
            {
                comando.ExecuteNonQuery();
            }
            return true;
        }

        // Inserta (o actualiza si el id ya existe) usando parámetros: evita inyección SQL.
        public bool InsertarMariaDB(Genero genero)
        {
            MySqlConnection? conexion = ConexionMariaDB.ObtenerConexion();
            if (conexion == null) return false;

            string sql = @"INSERT INTO generos (id, nombre, descripcion, ruta_imagen, es_activo)
                           VALUES (@id, @nombre, @descripcion, @ruta, @activo)
                           ON DUPLICATE KEY UPDATE nombre = @nombre, descripcion = @descripcion,
                                                   ruta_imagen = @ruta, es_activo = @activo";
            try
            {
                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", genero.Id);
                    comando.Parameters.AddWithValue("@nombre", genero.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                    comando.Parameters.AddWithValue("@ruta", genero.RutaImagen);
                    comando.Parameters.AddWithValue("@activo", genero.EsActivo);
                    comando.ExecuteNonQuery();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"No se pudo guardar en MariaDB: {ex.Message}", "Error SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Cuenta los registros de la tabla (sirve para comprobar que se guardó).
        public long ContarMariaDB()
        {
            MySqlConnection? conexion = ConexionMariaDB.ObtenerConexion();
            if (conexion == null) return -1;

            using (MySqlCommand comando = new MySqlCommand("SELECT COUNT(*) FROM generos", conexion))
            {
                return Convert.ToInt64(comando.ExecuteScalar());
            }
        }

        // ---------------------------- MongoDB (NoSQL) ----------------------------

        private IMongoCollection<GeneroDocumento> ColeccionGeneros()
        {
            return ConexionMongoDB.ObtenerBaseDatos().GetCollection<GeneroDocumento>("generos");
        }

        // Inserta o reemplaza el documento con ese Id (upsert).
        public bool InsertarMongoDB(Genero genero)
        {
            try
            {
                var documento = new GeneroDocumento
                {
                    Id = genero.Id,
                    Nombre = genero.Nombre,
                    Descripcion = genero.Descripcion,
                    RutaImagen = genero.RutaImagen,
                    EsActivo = genero.EsActivo
                };
                ColeccionGeneros().ReplaceOne(
                    d => d.Id == documento.Id,
                    documento,
                    new ReplaceOptions { IsUpsert = true });
                return true;
            }
            catch (Exception ex) when (ex is MongoException || ex is TimeoutException)
            {
                MessageBox.Show($"No se pudo guardar en MongoDB: {ex.Message}", "Error MongoDB",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public long ContarMongoDB()
        {
            return ColeccionGeneros().CountDocuments(Builders<GeneroDocumento>.Filter.Empty);
        }
    }
}
