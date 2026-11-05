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
    public interface IAlmacenamientoCRUD
    {
        void InsertarRegistro(object objeto);
        object ConsultarRegistro(string id);
        void ActualizarRegistro(object objeto);
        void EliminarRegistro(string id);
    }
}