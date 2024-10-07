using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_PEPS
{
    internal abstract class InventarioBase
    {
        //public List<Compra> Compras { get; set; } = new List<Compra>();
        //public List<(string Concepto, DateTime Fecha, int? CantidadEntrada, decimal? ValorUnitarioEntrada, decimal? ValorTotalEntrada,
        //             int? CantidadSalida, decimal? ValorUnitarioSalida, decimal? ValorTotalSalida, int CantidadSaldo, decimal ValorTotalSaldo)> Historial
        //{ get; set; }
        //             = new List<(string, DateTime, int?, decimal?, decimal?, int?, decimal?, decimal?, int, decimal)>();

        //public abstract void RegistrarCompra(DateTime fecha, int cantidad, decimal precioUnitario);
        //public abstract void RegistrarVenta(DateTime fecha, int cantidad);

        //protected int ObtenerCantidadSaldo() => Compras.Sum(c => c.Cantidad);
        //protected decimal ObtenerValorTotalSaldo() => Compras.Sum(c => c.Cantidad * c.PrecioUnitario);

        //public List<(string Concepto, DateTime Fecha, int? CantidadEntrada, decimal? ValorUnitarioEntrada, decimal? ValorTotalEntrada,
        //             int? CantidadSalida, decimal? ValorUnitarioSalida, decimal? ValorTotalSalida, int CantidadSaldo, decimal ValorTotalSaldo)> ObtenerHistorial()
        //{
        //    return Historial;
        //}



        protected List<Compra> Compras = new List<Compra>();
        protected List<Venta> ventas = new List<Venta>();
        protected List<(string Concepto, DateTime Fecha, int? CantidadEntrada, decimal? ValorUnitarioEntrada, decimal? ValorTotalEntrada,
                       int? CantidadSalida, decimal? ValorUnitarioSalida, decimal? ValorTotalSalida, int CantidadSaldo, decimal ValorTotalSaldo)> Historial =
                       new List<(string, DateTime, int?, decimal?, decimal?, int?, decimal?, decimal?, int, decimal)>();

        public abstract void RegistrarCompra(DateTime fecha, int cantidad, decimal precioUnitario);
        public abstract void RegistrarVenta(DateTime fecha, int cantidad);

        protected  int ObtenerCantidadSaldo()
        {
            return Compras.Sum(c => c.Cantidad); // Sumamos las cantidades restantes en el inventario
        }

        protected decimal ObtenerValorTotalSaldo()
        {
            return Compras.Sum(c => c.Cantidad * c.PrecioUnitario); // Valor total es la suma de las cantidades multiplicadas por sus precios unitarios restantes
        }

        protected void ActualizarHistorial(string concepto, DateTime fecha, int? cantidadEntrada, decimal? valorUnitarioEntrada, decimal? valorTotalEntrada,
                                            int? cantidadSalida, decimal? valorUnitarioSalida, decimal? valorTotalSalida)
        {
            Historial.Add((concepto, fecha, cantidadEntrada, valorUnitarioEntrada, valorTotalEntrada, cantidadSalida, valorUnitarioSalida, valorTotalSalida,
                            ObtenerCantidadSaldo(), ObtenerValorTotalSaldo()));
        }

        public List<(string Concepto, DateTime Fecha, int? CantidadEntrada, decimal? ValorUnitarioEntrada, decimal? ValorTotalEntrada,
                     int? CantidadSalida, decimal? ValorUnitarioSalida, decimal? ValorTotalSalida, int CantidadSaldo, decimal ValorTotalSaldo)> ObtenerHistorial()
        {
            return Historial;
        }
    }
}
