/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using Biblioteca.Models;
using System;
using System.Windows.Forms;

namespace Biblioteca
{
    // Actividad 3.7: ventana modal de inicio de sesión.
    // Controles (creados desde el Diseñador): txtUsuario, txtContrasena, btnIngresar, btnSalir, lblAutoria
    public partial class FrmLogin : Form
    {
        private int _intentos = 0;
        private const int MaxIntentos = 3;

        public FrmLogin()
        {
            InitializeComponent();

            txtContrasena.UseSystemPasswordChar = true;   // enmascara la contraseña
            txtContrasena.ShortcutsEnabled = false;
            this.AcceptButton = btnIngresar;   // Enter = Ingresar
            this.CancelButton = btnSalir;      // Esc = Salir
        }

        private void btnIngresar_Click(object? sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (usuario.Length == 0 || contrasena.Length == 0)
            {
                MessageBox.Show("Ingrese su usuario y su contraseña.", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCredenciales(usuario, contrasena, out CuentaSistema? cuenta) && cuenta != null)
            {
                // Se guarda la sesión de inmediato y se cierra el login con resultado OK
                SesionSistema.IniciarSesion(cuenta);
                this.DialogResult = DialogResult.OK;
                return;
            }

            _intentos++;
            txtContrasena.Clear();
            txtContrasena.Focus();

            if (_intentos >= MaxIntentos)
            {
                MessageBox.Show("Demasiados intentos fallidos. La aplicación se cerrará.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            // Mismo mensaje si falla el usuario o la contraseña (no revela cuál de los dos)
            MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;   // Program.cs termina la aplicación
        }

        // Validación lógica con datos estáticos (sin SQL):
        // recorre la colección de UsuariosSistema y compara las credenciales capturadas.
        // Devuelve true si coinciden y entrega la cuenta (nombre completo y rol) por el parámetro out.
        private static bool ValidarCredenciales(string usuario, string contrasena, out CuentaSistema? cuentaEncontrada)
        {
            cuentaEncontrada = null;

            foreach (CuentaSistema cuenta in UsuariosSistema.Usuarios)
            {
                bool usuarioCoincide = string.Equals(cuenta.NombreUsuario, usuario, StringComparison.OrdinalIgnoreCase);
                bool contrasenaCoincide = string.Equals(cuenta.Contrasena, contrasena, StringComparison.Ordinal);

                if (usuarioCoincide && contrasenaCoincide)
                {
                    cuentaEncontrada = cuenta;
                    return true;
                }
            }

            return false;
        }
    }
}
