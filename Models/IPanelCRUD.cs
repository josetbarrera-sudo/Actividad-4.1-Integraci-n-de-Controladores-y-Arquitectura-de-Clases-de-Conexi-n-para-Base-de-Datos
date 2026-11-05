/*
 * ENCABEZADO DE AUTORÍA
 * Equipo N°: 3
 * Integrantes (orden alfabético por primer apellido):
 * 1. CONTRERAS Rodríguez Janis Isabel
 * 2. MACÍAS Cruz Meredith Miranda
 * 3. TORRES Barrera José Ángel
 */
using System.Windows.Forms;

namespace Biblioteca
{
    public interface IPanelCRUD
    {
        void EjecutarGuardar();

        void EjecutarBuscar(string id, ErrorProvider alerta);

        void EjecutarActualizar();

        void EjecutarEliminar(StatusStrip barraEstado);
    }
}