namespace Metodo_PEPS
{
    public partial class Form1 : Form
    {
        private InventarioPEPS inventario = new InventarioPEPS();
        public Form1()
        {
            InitializeComponent(); 
            ConfigurarDataGridView();
        }
        //private void ConfigurarDataGridView()
        //{
        //    dgvSaldos.Columns.Add("Fecha", "Fecha");
        //    dgvSaldos.Columns.Add("Concepto", "Concepto");
        //    dgvSaldos.Columns.Add("CantidadEntrada", "Cantidad (Entrada)");
        //    dgvSaldos.Columns.Add("ValorUnitarioEntrada", "Valor unitario (Entrada)");
        //    dgvSaldos.Columns.Add("ValorTotalEntrada", "Valor total (Entrada)");
        //    dgvSaldos.Columns.Add("CantidadSalida", "Cantidad (Salida)");
        //    dgvSaldos.Columns.Add("ValorUnitarioSalida", "Valor unitario (Salida)");
        //    dgvSaldos.Columns.Add("ValorTotalSalida", "Valor total (Salida)");
        //    dgvSaldos.Columns.Add("CantidadSaldo", "Cantidad (Saldo)");
        //    dgvSaldos.Columns.Add("ValorTotalSaldo", "Valor total (Saldo)");
        //}

        //private void MostrarSaldos()
        //{
        //    dgvSaldos.Rows.Clear();

        //    var historial = inventario.ObtenerHistorial();

        //    // Llenamos el DataGridView con el historial
        //    foreach (var registro in historial)
        //    {
        //        dgvSaldos.Rows.Add(
        //            registro.Fecha.ToString("dd-MMM"),
        //            registro.Concepto,
        //            registro.CantidadEntrada.HasValue ? registro.CantidadEntrada.Value.ToString() : "",
        //            registro.ValorUnitarioEntrada.HasValue ? registro.ValorUnitarioEntrada.Value.ToString("C") : "",
        //            registro.ValorTotalEntrada.HasValue ? registro.ValorTotalEntrada.Value.ToString("C") : "",
        //            registro.CantidadSalida.HasValue ? registro.CantidadSalida.Value.ToString() : "",
        //            registro.ValorUnitarioSalida.HasValue ? registro.ValorUnitarioSalida.Value.ToString("C") : "",
        //            registro.ValorTotalSalida.HasValue ? registro.ValorTotalSalida.Value.ToString("C") : "",
        //            registro.CantidadSaldo.ToString(), // Se muestra la cantidad de saldo restante en cada movimiento
        //            registro.ValorTotalSaldo.ToString("C") // El valor total del saldo restante
        //        );
        //    }
        //}

        //private void btnRegistrarCompra_Click_1(object sender, EventArgs e)
        //{
        //    DateTime fecha = dtpFechaCompra.Value;
        //    int cantidad = int.Parse(txtCantidadCompra.Text);
        //    decimal precioUnitario = decimal.Parse(txtPrecioUnitario.Text);

        //    inventario.RegistrarCompra(fecha, cantidad, precioUnitario);
        //    MostrarSaldos();
        //}

        //private void btnRegistrarVenta_Click_1(object sender, EventArgs e)
        //{
        //    DateTime fecha = dtpFechaVenta.Value;
        //    int cantidad = int.Parse(txtCantidadVenta.Text);

        //    inventario.RegistrarVenta(fecha, cantidad);
        //    MostrarSaldos();
        //}

        private void ConfigurarDataGridView()
        {
            dgvSaldos.Columns.Add("Fecha", "Fecha");
            dgvSaldos.Columns.Add("Concepto", "Concepto");
            dgvSaldos.Columns.Add("CantidadEntrada", "Cantidad (Entrada)");
            dgvSaldos.Columns.Add("ValorUnitarioEntrada", "Valor unitario (Entrada)");
            dgvSaldos.Columns.Add("ValorTotalEntrada", "Valor total (Entrada)");
            dgvSaldos.Columns.Add("CantidadSalida", "Cantidad (Salida)");
            dgvSaldos.Columns.Add("ValorUnitarioSalida", "Valor unitario (Salida)");
            dgvSaldos.Columns.Add("ValorTotalSalida", "Valor total (Salida)");
            dgvSaldos.Columns.Add("CantidadSaldo", "Cantidad (Saldo)");
            dgvSaldos.Columns.Add("ValorTotalSaldo", "Valor total (Saldo)");
        }

        private void MostrarSaldos()
        {
            try
            {
                dgvSaldos.Rows.Clear();
                var historial = inventario.ObtenerHistorial();

                foreach (var registro in historial)
                {
                    dgvSaldos.Rows.Add(
                        registro.Fecha.ToString("dd-MMM"),
                        registro.Concepto,
                        registro.CantidadEntrada.HasValue ? registro.CantidadEntrada.Value.ToString() : "",
                        registro.ValorUnitarioEntrada.HasValue ? registro.ValorUnitarioEntrada.Value.ToString("C") : "",
                        registro.ValorTotalEntrada.HasValue ? registro.ValorTotalEntrada.Value.ToString("C") : "",
                        registro.CantidadSalida.HasValue ? registro.CantidadSalida.Value.ToString() : "",
                        registro.ValorUnitarioSalida.HasValue ? registro.ValorUnitarioSalida.Value.ToString("C") : "",
                        registro.ValorTotalSalida.HasValue ? registro.ValorTotalSalida.Value.ToString("C") : "",
                        registro.CantidadSaldo.ToString(),
                        registro.ValorTotalSaldo.ToString("C")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar los saldos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarCompra_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatosCompra())
                {
                    DateTime fecha = dtpFechaCompra.Value;
                    int cantidad = int.Parse(txtCantidadCompra.Text);
                    decimal precioUnitario = decimal.Parse(txtPrecioUnitario.Text);

                    inventario.RegistrarCompra(fecha, cantidad, precioUnitario);
                    MostrarSaldos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarVenta_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatosVenta())
                {
                    DateTime fecha = dtpFechaVenta.Value;
                    int cantidad = int.Parse(txtCantidadVenta.Text);

                    inventario.RegistrarVenta(fecha, cantidad);
                    MostrarSaldos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosCompra()
        {
            try
            {
                // Validar que la cantidad sea un número entero positivo
                if (!int.TryParse(txtCantidadCompra.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida para la compra (número entero positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Validar que el precio unitario sea un número decimal positivo
                if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario) || precioUnitario <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un precio unitario válido (número decimal positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la validación de datos de compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ValidarDatosVenta()
        {
            try
            {
                // Validar que la cantidad sea un número entero positivo
                if (!int.TryParse(txtCantidadVenta.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida para la venta (número entero positivo).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la validación de datos de venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
