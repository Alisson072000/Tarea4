using System.Data.Common;

namespace Tarea2
{
    class Cargo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Empleado Encargado { get; set; }
    }
}
