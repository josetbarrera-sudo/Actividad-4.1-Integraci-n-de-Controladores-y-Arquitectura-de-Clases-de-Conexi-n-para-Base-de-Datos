/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using System.Collections.Generic;

namespace Biblioteca.Models
{
    // Nombres de los perfiles (roles) que reconoce el sistema.
    public static class Roles
    {
        public const string Administrador = "Administrador";
        public const string Operador = "Operador";
        public const string Invitado = "Invitado";
    }

    // Una cuenta de acceso definida en memoria.
    public class CuentaSistema
    {
        public string NombreUsuario { get; }
        public string Contrasena { get; }
        public string NombreCompleto { get; }
        public string Rol { get; }

        public CuentaSistema(string nombreUsuario, string contrasena, string nombreCompleto, string rol)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            NombreCompleto = nombreCompleto;
            Rol = rol;
        }
    }

    // Actividad 3.7: almacén ESTÁTICO de usuarios autorizados.
    // Todo vive en el código fuente (sin SQL Server, MySQL ni archivos externos).
    // Las contraseñas en texto plano son solo para fines académicos.
    public static class UsuariosSistema
    {
        private static readonly List<CuentaSistema> _usuarios = new List<CuentaSistema>
        {
            new CuentaSistema("admin",    "Admin123", "Administrador del Sistema", Roles.Administrador),
            new CuentaSistema("operador", "Oper123",  "Operador de Biblioteca",    Roles.Operador),
            new CuentaSistema("invitado", "Invit123", "Usuario Invitado",          Roles.Invitado)
        };

        // Solo lectura: nadie fuera de esta clase puede agregar o quitar cuentas.
        public static IReadOnlyList<CuentaSistema> Usuarios => _usuarios;
    }
}
