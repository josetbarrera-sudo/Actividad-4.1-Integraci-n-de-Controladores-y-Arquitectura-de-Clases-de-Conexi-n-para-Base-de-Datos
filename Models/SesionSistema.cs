/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using System;

namespace Biblioteca.Models
{
    // Actividad 3.7: sesión global. Todos los formularios (el principal MDI y sus ventanas hijas)
    // leen estos valores directamente, sin pasarlos por constructores ni consultar una base de datos.
    public static class SesionSistema
    {
        public static string UsuarioActivo { get; private set; } = string.Empty;   // nombre completo
        public static string RolActivo { get; private set; } = string.Empty;       // perfil asignado
        public static DateTime HoraInicioSesion { get; private set; }              // fecha y hora de inicio

        public static bool HaySesion => UsuarioActivo.Length > 0;
        public static bool EsAdministrador => RolActivo == Roles.Administrador;
        public static bool EsOperador => RolActivo == Roles.Operador;
        public static bool EsInvitado => RolActivo == Roles.Invitado;

        // Se llama justo después de validar correctamente las credenciales.
        public static void IniciarSesion(CuentaSistema cuenta)
        {
            UsuarioActivo = cuenta.NombreCompleto;
            RolActivo = cuenta.Rol;
            HoraInicioSesion = DateTime.Now;
        }

        public static void CerrarSesion()
        {
            UsuarioActivo = string.Empty;
            RolActivo = string.Empty;
            HoraInicioSesion = default;
        }
    }
}
