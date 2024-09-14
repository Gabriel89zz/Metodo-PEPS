using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_PEPS
{
    internal class Compra
    {
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public Compra(DateTime fecha, int cantidad, decimal precioUnitario)
        {
            Fecha = fecha;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }
    }
}
