using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_PEPS
{
    internal class Venta
    {
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }

        public Venta(DateTime fecha, int cantidad)
        {
            Fecha = fecha;
            Cantidad = cantidad;
        }
    }
}
