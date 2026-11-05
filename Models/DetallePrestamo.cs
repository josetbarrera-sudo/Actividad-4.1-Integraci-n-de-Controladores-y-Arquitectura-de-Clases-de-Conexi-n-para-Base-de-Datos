/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
namespace Biblioteca.Models
{
    // Tabla intermedia Préstamo-Libro (un préstamo puede incluir varios libros).
    public class DetallePrestamo
    {
        public int IdPrestamo { get; }
        public Libros Libro { get; }
        // Copia exacta prestada; null cuando el libro es digital.
        public Ejemplar? Ejemplar { get; }

        public DetallePrestamo(int idPrestamo, Libros libro, Ejemplar? ejemplar)
        {
            IdPrestamo = idPrestamo;
            Libro = libro;
            Ejemplar = ejemplar;
        }
    }
}
