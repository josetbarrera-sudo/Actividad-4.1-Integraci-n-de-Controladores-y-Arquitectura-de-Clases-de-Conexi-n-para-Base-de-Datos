/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Biblioteca.Models;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmPrincipal : Form
    {
        // Actividad 3.5 (MDI): la vista activa ya no se guarda en un campo; es la ventana hija
        // que tiene el foco dentro del contenedor. Si no es un módulo CRUD (p. ej. la consulta), es null.
        private IPanelCRUD? VistaActiva => this.ActiveMdiChild as IPanelCRUD;
        public FrmPrincipal()
        {
            InitializeComponent();

            // Actividad 4.1: opción de menú para abrir la ventana de prueba de conexión a las bases de datos.
            ToolStripMenuItem mnuConexion = new ToolStripMenuItem("Prueba de conexión");
            mnuConexion.Click += (s, e) => new FrmPruebaConexion().ShowDialog(this);
            menuStrip1.Items.Add(mnuConexion);
        }

        // ================== ACTIVIDAD 3.7: SESIÓN Y RESTRICCIONES POR PERFIL ==================
        // El evento Load (se enlaza en el Diseñador) lee la clase estática SesionSistema,
        // muestra los datos en el StatusStrip y aplica las restricciones según el rol activo.
        private void FrmPrincipal_Load(object? sender, EventArgs e)
        {
            this.Text = $"Gestión de Biblioteca - {SesionSistema.UsuarioActivo} ({SesionSistema.RolActivo})";

            tssUsuario.Text = $"Usuario: {SesionSistema.UsuarioActivo}";
            tssRol.Text = $"Rol: {SesionSistema.RolActivo}";
            tssHora.Text = $"Inicio de sesión: {SesionSistema.HoraInicioSesion:dd/MM/yyyy HH:mm:ss}";

            AplicarRestriccionesPorRol();
        }

        // Enabled = false deshabilita un control; Visible = false lo oculta.
        private void AplicarRestriccionesPorRol()
        {
            if (SesionSistema.RolActivo == Roles.Administrador)
            {
                // Administrador: acceso completo, no se restringe nada.
                tssMensaje.Text = "Acceso completo (Administrador).";
            }
            else if (SesionSistema.RolActivo == Roles.Operador)
            {
                // Operador: consulta, registro y actualización; sin procesos administrativos.
                btnUsuarios.Visible = false;
                btnAdministrador.Visible = false;
                btnPersona.Visible = false;
                btnEstadisticas.Visible = false;
                btnProcesoMasivo.Visible = false;
                btnMasterEliminar.Enabled = false;

                tssMensaje.Text = "Perfil Operador: sin acceso a procesos administrativos.";
            }
            else
            {
                // Invitado (o cualquier perfil desconocido: mínimo privilegio): solo consulta.
                btnUsuarios.Visible = false;
                btnAdministrador.Visible = false;
                btnPersona.Visible = false;
                btnAutores.Visible = false;
                btnPrestamos.Visible = false;
                btnGenero.Visible = false;
                btnReserva.Visible = false;
                btnMulta.Visible = false;
                btnEditorial.Visible = false;
                btnEstadisticas.Visible = false;
                btnProcesoMasivo.Visible = false;
                btnEdicionRapida.Visible = false;

                btnMasterGuardar.Enabled = false;
                btnMasterActualizar.Enabled = false;
                btnMasterEliminar.Enabled = false;

                tssMensaje.Text = "Perfil Invitado: solo opciones de consulta.";
            }
        }

        // Abre la ventana hija que demuestra la comunicación entre formularios (lee SesionSistema)
        private void btnDatosSesion_Click(object? sender, EventArgs e)
        {
            AbrirHijo<FrmSesionInfo>("Datos de sesión");
        }

        // Cierra la sesión y reinicia la aplicación: vuelve a aparecer FrmLogin para entrar con otro perfil.
        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar la sesión y volver al inicio de sesión?\nLos datos capturados se perderán.",
                "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            SesionSistema.CerrarSesion();
            Application.Restart();
        }

        private void btnEstadisticas_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(Estadisticas.Resumen(), "Estadísticas de la biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Actividad 3.4 / 3.5: la ventana del proceso concurrente ahora es una hija MDI de instancia única
        private void btnProcesoMasivo_Click(object? sender, EventArgs e)
        {
            AbrirHijo<FrmProcesosHilos>("Reporte masivo (hilos)");
        }

        // ================== ACTIVIDAD 3.5: ARQUITECTURA MDI ==================
        // FrmPrincipal es el formulario contenedor (IsMdiContainer = true, se configura en el Diseñador).
        // Cada módulo se abre como ventana hija (MdiParent = this) y solo puede existir UNA instancia.
        private void AbrirHijo<T>(string titulo) where T : Form, new()
        {
            // Algoritmo de instancia única: se recorre la colección de ventanas hijas abiertas
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo.GetType() == typeof(T))
                {
                    // Ya existe: se restaura si estaba minimizada, se trae al frente y NO se crea otra
                    if (hijo.WindowState == FormWindowState.Minimized)
                        hijo.WindowState = FormWindowState.Normal;

                    hijo.Activate();
                    return;
                }
            }

            T nuevo = new T();
            nuevo.Text = titulo;
            nuevo.StartPosition = FormStartPosition.WindowsDefaultLocation;   // cada ventana nueva se escalona
            nuevo.MdiParent = this;   // obligatorio ANTES de Show(): la ventana queda atrapada dentro del contenedor
            nuevo.Show();

            AjustarAlAreaMdi(nuevo);
        }

        // Los formularios se diseñaron grandes (1145 x 883); se reducen para que quepan en el área MDI.
        // Si el contenido es más grande, la propia ventana hija muestra barras de desplazamiento (ver FrmBase).
        private void AjustarAlAreaMdi(Form hijo)
        {
            MdiClient? area = this.Controls.OfType<MdiClient>().FirstOrDefault();
            if (area == null)
                return;

            int ancho = Math.Min(hijo.Width, Math.Max(400, area.ClientSize.Width - 40));
            int alto = Math.Min(hijo.Height, Math.Max(300, area.ClientSize.Height - 40));
            hijo.Size = new Size(ancho, alto);
        }

        private void mnuCascada_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuMosaicoVertical_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuMosaicoHorizontal_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //Botones que llaman a las otras clases / ventanas
        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmAutor>("Autores");
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmUsuario>("Usuarios");
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmLibros>("Libros");
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmPrestamo>("Préstamos");
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmPersona>("Persona");
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmGenero>("Género");
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmReserva>("Reserva");
        }

        private void btnMulta_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmMulta>("Multa");
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmEditorial>("Editorial");
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            AbrirHijo<FrmAdministrador>("Administrador");
        }


        //Botones maestros
        private void btnMasterGuardar_Click(object sender, EventArgs e)
        {
            if (VistaActiva != null)
            {
                VistaActiva.EjecutarGuardar();// Llamada limpia y polimórfica
            }
            else
            {
                MessageBox.Show("Abra y seleccione un módulo antes de guardar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMasterActualizar_Click(object sender, EventArgs e)
        {
            if (VistaActiva != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Desea actualizar los datos del registro?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes)
                    return;

                VistaActiva.EjecutarActualizar();
            }
            else
            {
                MessageBox.Show("Abra y seleccione un módulo antes de actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMasterEliminar_Click(object sender, EventArgs e)
        {
            if (VistaActiva != null)
            {
                VistaActiva.EjecutarEliminar(statusStrip1);
            }
            else
            {
                MessageBox.Show("Abra y seleccione un módulo antes de eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMasterBuscar_Click(object sender, EventArgs e)
        {
            if (VistaActiva != null)
            {
                VistaActiva.EjecutarBuscar(txtIdBusqueda.Text.Trim(), errorProvider1);
            }
            else
            {
                MessageBox.Show("Abra y seleccione un módulo antes de buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}