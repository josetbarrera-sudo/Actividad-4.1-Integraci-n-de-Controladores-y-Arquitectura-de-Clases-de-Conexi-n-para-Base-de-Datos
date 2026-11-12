/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using MySql.Data.MySqlClient;

namespace Biblioteca.Data
{
    // Actividad 4.1: clase centralizada de conexión para MySQL / MariaDB.
    // Patrón Singleton: toda la aplicación comparte UNA sola conexión,
    // así se evita abrir un socket nuevo por cada consulta.
    public static class ConexionMariaDB
    {
        // Parámetros del servidor (privados: ningún formulario conoce las credenciales).
        // Server=localhost, Port=3306 y Uid=root son los valores por defecto de XAMPP.
        private const string Server = "localhost";
        private const string Database = "biblioteca";
        private const string Uid = "root";
        private const string Pwd = "";
        private const string Port = "3306";

        private static string CadenaConexion =>
            $"Server={Server};Port={Port};Database={Database};Uid={Uid};Pwd={Pwd};";

        // Instancia única compartida.
        private static MySqlConnection? _conexion;

        // Devuelve la conexión activa. Si es nula la crea; si está cerrada la abre;
        // si ya está abierta la reutiliza (evita fugas de memoria y saturación de hilos).
        // Devuelve null si ocurre un error (ya notificado al usuario).
        public static MySqlConnection? ObtenerConexion()
        {
            try
            {
                if (_conexion == null)
                    _conexion = new MySqlConnection(CadenaConexion);

                if (_conexion.State == System.Data.ConnectionState.Closed)
                    _conexion.Open();

                return _conexion;
            }
            catch (MySqlException ex)
            {
                // Se traducen los errores más comunes a mensajes claros.
                string mensaje = ex.Number switch
                {
                    0 or 1042 => "No se pudo conectar al servidor. Verifica que MySQL/MariaDB esté iniciado.",
                    1045 => "Usuario o contraseña incorrectos.",
                    1049 => $"La base de datos '{Database}' no existe.",
                    _ => $"Error de MySQL ({ex.Number}): {ex.Message}"
                };
                MessageBox.Show(mensaje, "Error de conexión MariaDB",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Se descarta la conexión fallida para que el siguiente intento empiece limpio.
                _conexion?.Dispose();
                _conexion = null;
                return null;
            }
        }

        // Cierra la conexión (por ejemplo al salir de la aplicación).
        public static void CerrarConexion()
        {
            if (_conexion != null && _conexion.State != System.Data.ConnectionState.Closed)
                _conexion.Close();
        }
    }
}