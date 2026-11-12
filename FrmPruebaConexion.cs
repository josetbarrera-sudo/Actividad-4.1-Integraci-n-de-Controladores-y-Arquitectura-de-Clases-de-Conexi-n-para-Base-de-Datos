/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using Biblioteca.Controllers;
using Biblioteca.Data;
using Biblioteca.Models;
using MySql.Data.MySqlClient;

namespace Biblioteca
{
    // Actividad 4.1: ventana para comprobar la conectividad con los dos motores.
    public partial class FrmPruebaConexion : Form
    {
        private readonly GeneroController _controlador = new GeneroController();

        public FrmPruebaConexion()
        {
            InitializeComponent();
        }

        private void Escribir(string texto)
        {
            // La fecha y hora del sistema debe verse en las capturas de evidencia.
            txtResultado.AppendText($"[{DateTime.Now:dd/MM/yyyy HH:mm:ss}] {texto}{Environment.NewLine}");
        }

        private void btnTestMariaDB_Click(object? sender, EventArgs e)
        {
            MySqlConnection? conexion = ConexionMariaDB.ObtenerConexion();
            if (conexion != null)
                Escribir($"MariaDB: conexión exitosa. Servidor versión {conexion.ServerVersion}, base de datos '{conexion.Database}'.");
            else
                Escribir("MariaDB: la conexión falló.");
        }

        private void btnTestMongoDB_Click(object? sender, EventArgs e)
        {
            if (ConexionMongoDB.ProbarConexion())
                Escribir("MongoDB: conexión exitosa (ping respondido por el servidor).");
            else
                Escribir("MongoDB: la conexión falló.");
        }

        private void btnGuardarPrueba_Click(object? sender, EventArgs e)
        {
            Genero genero = new Genero(1, "Terror", "Libros de suspenso y miedo", "terror.png", true);

            if (_controlador.CrearTablaMariaDB() && _controlador.InsertarMariaDB(genero))
                Escribir($"MariaDB: género guardado. Registros en la tabla: {_controlador.ContarMariaDB()}.");

            if (_controlador.InsertarMongoDB(genero))
                Escribir($"MongoDB: género guardado. Documentos en la colección: {_controlador.ContarMongoDB()}.");
        }
    }
}
