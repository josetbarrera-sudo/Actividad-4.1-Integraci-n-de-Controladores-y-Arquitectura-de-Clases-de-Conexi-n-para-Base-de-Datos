/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using MongoDB.Bson;
using MongoDB.Driver;

namespace Biblioteca.Data
{
    // Actividad 4.1: clase centralizada de conexión para MongoDB (NoSQL).
    // MongoClient administra internamente un grupo de conexiones (Connection Pool),
    // por eso se crea UNA sola vez y se reutiliza; no se abre un cliente por consulta.
    public static class ConexionMongoDB
    {
        // Cadena de conexión estándar y nombre de la base de datos documental.
        private const string CadenaConexion = "mongodb://localhost:27017";
        private const string NombreBaseDatos = "biblioteca";

        // Objetos globales del cliente nativo.
        private static IMongoClient? _cliente;
        private static IMongoDatabase? _baseDatos;
        private static readonly object _candado = new object();

        // Método estático único para recuperar la referencia a la base de datos.
        public static IMongoDatabase ObtenerBaseDatos()
        {
            if (_baseDatos == null)
            {
                lock (_candado) // protege la creación si varios hilos la piden a la vez
                {
                    if (_baseDatos == null)
                    {
                        var settings = MongoClientSettings.FromConnectionString(CadenaConexion);
                        settings.ServerSelectionTimeout = TimeSpan.FromSeconds(3); // falla rápido si no hay servidor
                        _cliente = new MongoClient(settings);
                        _baseDatos = _cliente.GetDatabase(NombreBaseDatos);
                    }
                }
            }
            return _baseDatos;
        }

        // Prueba real de conexión: envía un "ping" al servidor.
        // Devuelve true si responde; si no, muestra un mensaje claro y devuelve false.
        public static bool ProbarConexion()
        {
            try
            {
                ObtenerBaseDatos().RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                return true;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("No se pudo conectar a MongoDB. Verifica que el servicio esté iniciado.",
                    "Error de conexión MongoDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (MongoException ex)
            {
                MessageBox.Show($"Error de MongoDB: {ex.Message}",
                    "Error de conexión MongoDB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
