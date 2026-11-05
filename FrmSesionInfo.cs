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
    // Actividad 3.7: ventana hija del MDI que demuestra la comunicación entre formularios.
    // NO recibe parámetros por el constructor: lee directamente las propiedades estáticas de SesionSistema.
    public partial class FrmSesionInfo : Form
    {
        public FrmSesionInfo()
        {
            InitializeComponent();
            MostrarDatosSesion();
        }

        private void MostrarDatosSesion()
        {
            lblUsuarioValor.Text = SesionSistema.UsuarioActivo;
            lblRolValor.Text = SesionSistema.RolActivo;
            lblHoraValor.Text = SesionSistema.HoraInicioSesion.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            MostrarDatosSesion();
        }

        private void btnCerrar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
