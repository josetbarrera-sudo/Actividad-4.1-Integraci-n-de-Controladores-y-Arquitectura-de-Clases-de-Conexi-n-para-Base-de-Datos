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
    // Copia física individual de un libro (identificación única por ejemplar).
    public class Ejemplar
    {
        public string CodigoEjemplar { get; }
        public int IdLibro { get; }
        public bool Disponible { get; set; } = true;

        public Ejemplar(int idLibro, int numero)
        {
            if (idLibro <= 0)
                throw new ArgumentException("El ID del libro debe ser mayor a 0.");
            IdLibro = idLibro;
            CodigoEjemplar = $"L{idLibro:D4}-E{numero:D3}";
        }

        public override string ToString() => $"{CodigoEjemplar} ({(Disponible ? "Disponible" : "Prestado")})";
    }
}
