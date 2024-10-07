using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_PEPS
{
    internal class InventarioUEPS : InventarioBase
    {
        public override void RegistrarCompra(DateTime fecha, int cantidad, decimal precioUnitario)
        {
            Compras.Add(new Compra(fecha, cantidad, precioUnitario));
            Historial.Add(("Compra", fecha, cantidad, precioUnitario, cantidad * precioUnitario, null, null, null, ObtenerCantidadSaldo(), ObtenerValorTotalSaldo()));
        }

        public override void RegistrarVenta(DateTime fecha, int cantidad)
        {
            int cantidadRestante = cantidad;
            decimal valorTotalSalida = 0;

            for (int i = Compras.Count - 1; i >= 0 && cantidadRestante > 0; i--)
            {
                var compra = Compras[i];
                int cantidadSalida = Math.Min(compra.Cantidad, cantidadRestante);
                decimal valorUnitarioSalida = compra.PrecioUnitario;

                valorTotalSalida += cantidadSalida * valorUnitarioSalida;
                compra.Cantidad -= cantidadSalida;
                cantidadRestante -= cantidadSalida;

                Historial.Add(("Venta", fecha, null, null, null, cantidadSalida, valorUnitarioSalida, cantidadSalida * valorUnitarioSalida, ObtenerCantidadSaldo(), ObtenerValorTotalSaldo()));

                if (compra.Cantidad == 0) Compras.RemoveAt(i);
            }

            if (cantidadRestante > 0) throw new InvalidOperationException("No hay suficiente inventario para cubrir la venta.");
        }
    }
}
