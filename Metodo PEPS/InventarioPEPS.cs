using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_PEPS
{
    internal class InventarioPEPS
    {
        private List<Compra> compras = new List<Compra>();
        private List<Venta> ventas = new List<Venta>();
        private List<(string Concepto, DateTime Fecha, int? CantidadEntrada, decimal? ValorUnitarioEntrada, decimal? ValorTotalEntrada,
                       int? CantidadSalida, decimal? ValorUnitarioSalida, decimal? ValorTotalSalida, int CantidadSaldo, decimal ValorTotalSaldo)> historial =
                       new List<(string, DateTime, int?, decimal?, decimal?, int?, decimal?, decimal?, int, decimal)>();

        public void RegistrarCompra(DateTime fecha, int cantidad, decimal precioUnitario)
        {
            compras.Add(new Compra(fecha, cantidad, precioUnitario));

            // Guardar en el historial
            historial.Add(("Compra", fecha, cantidad, precioUnitario, cantidad * precioUnitario, null, null, null, ObtenerCantidadSaldo(), ObtenerValorTotalSaldo()));
        }

        public void RegistrarVenta(DateTime fecha, int cantidad)
        {
            int cantidadRestante = cantidad;
            decimal valorTotalSalida = 0;

            List<(int Cantidad, decimal PrecioUnitario)> salidas = new List<(int, decimal)>();

            foreach (var compra in compras.ToList()) // Copiamos la lista para evitar modificarla durante el recorrido
            {
                if (cantidadRestante <= 0) break;

                int cantidadSalida = Math.Min(compra.Cantidad, cantidadRestante);
                decimal valorUnitarioSalida = compra.PrecioUnitario;
                decimal valorSalida = cantidadSalida * valorUnitarioSalida;

                // Agregar al registro de salidas
                salidas.Add((cantidadSalida, valorUnitarioSalida));
                valorTotalSalida += valorSalida;

                // Actualizar el inventario
                compra.Cantidad -= cantidadSalida;
                cantidadRestante -= cantidadSalida;

                if (compra.Cantidad == 0)
                {
                    compras.Remove(compra); // Remover compra si se agotó
                }

                // Agregar cada salida individual al historial (una fila por salida parcial)
                historial.Add(("Venta", fecha, null, null, null, cantidadSalida, valorUnitarioSalida, cantidadSalida * valorUnitarioSalida,
                               ObtenerCantidadSaldo(), ObtenerValorTotalSaldo()));
            }

            if (cantidadRestante > 0)
            {
                throw new InvalidOperationException("No hay suficiente inventario para cubrir la venta.");
            }
        }

        private int ObtenerCantidadSaldo()
        {
            return compras.Sum(c => c.Cantidad); // Sumamos las cantidades restantes en el inventario
        }

        private decimal ObtenerValorTotalSaldo()
        {
            // Valor total es simplemente la suma de las cantidades multiplicadas por sus precios unitarios restantes
            return compras.Sum(c => c.Cantidad * c.PrecioUnitario);
        }

        public List<(string Concepto, DateTime Fecha, int? CantidadEntrada, decimal? ValorUnitarioEntrada, decimal? ValorTotalEntrada,
                     int? CantidadSalida, decimal? ValorUnitarioSalida, decimal? ValorTotalSalida, int CantidadSaldo, decimal ValorTotalSaldo)> ObtenerHistorial()
        {
            return historial;
        }
    }
}
