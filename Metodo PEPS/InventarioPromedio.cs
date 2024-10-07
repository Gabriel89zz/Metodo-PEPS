using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_PEPS
{
    internal class InventarioPromedio : InventarioBase
    {
        public override void RegistrarCompra(DateTime fecha, int cantidad, decimal precioUnitario)
        {
            Compras.Add(new Compra(fecha, cantidad, precioUnitario));

            // Guardar en el historial
            Historial.Add(("Compra", fecha, cantidad, precioUnitario, cantidad * precioUnitario, null, null, null, ObtenerCantidadSaldo(), ObtenerValorTotalSaldo()));
        }

        public override void RegistrarVenta(DateTime fecha, int cantidad)
        {
            int cantidadRestante = cantidad;
            decimal valorTotalSalida = 0;
            decimal costoPromedio = ObtenerCostoPromedio();

            if (costoPromedio == 0) // Si no hay compras, no se puede vender
            {
                throw new InvalidOperationException("No hay suficiente inventario para cubrir la venta.");
            }

            // Recorremos la lista de compras desde la primera hasta la última
            for (int i = 0; i < Compras.Count && cantidadRestante > 0; i++)
            {
                var compra = Compras[i];

                // Solo procesar si hay cantidad disponible
                if (compra.Cantidad > 0)
                {
                    int cantidadSalida = Math.Min(compra.Cantidad, cantidadRestante);
                    decimal valorUnitarioSalida = costoPromedio; // Usar el costo promedio
                    decimal valorSalida = cantidadSalida * valorUnitarioSalida;

                    // Actualizar el inventario
                    compra.Cantidad -= cantidadSalida;
                    cantidadRestante -= cantidadSalida;

                    // Agregar cada salida al historial (una fila por salida parcial)
                    Historial.Add(("Venta", fecha, null, null, null, cantidadSalida, valorUnitarioSalida, valorSalida,
                                   ObtenerCantidadSaldo(), ObtenerValorTotalSaldo()));

                    // Si la compra se ha agotado, eliminarla
                    if (compra.Cantidad == 0)
                    {
                        Compras.RemoveAt(i);
                        i--; // Decrementar el índice para no saltar la siguiente compra
                    }
                }
            }

            if (cantidadRestante > 0)
            {
                throw new InvalidOperationException("No hay suficiente inventario para cubrir la venta.");
            }
        }

        private decimal ObtenerCostoPromedio()
        {
            if (Compras.Count == 0 || ObtenerCantidadSaldo() == 0)
                return 0;

            decimal costoTotal = Compras.Sum(c => c.Cantidad * c.PrecioUnitario);
            int cantidadTotal = ObtenerCantidadSaldo();
            return costoTotal / cantidadTotal; // Costo promedio
        }


    }
}
