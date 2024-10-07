using System.Windows.Forms;

namespace Metodo_PEPS
{
    public partial class Form1 : Form
    {
        private InventarioBase inventario;

        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();

        }

        // Asumiendo que tienes un ComboBox llamado cbMetodo
        private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetodo.SelectedItem.ToString())
            {
                case "PEPS":
                    inventario = new InventarioPEPS();
                    break;
                case "UEPS":
                    inventario = new InventarioUEPS();
                    break;
            }
            ActualizarDataGridView();
        }

        private void InicializarDataGridView()
        {
            // Configurar las columnas del DataGridView
            dgvSaldos.Columns.Add("Fecha", "Fecha");
            dgvSaldos.Columns.Add("CantidadEntrada", "Cantidad Entrada");
            dgvSaldos.Columns.Add("CantidadSalida", "Cantidad Salida");
            dgvSaldos.Columns.Add("Existencia", "Existencia");
            dgvSaldos.Columns.Add("CostoUnitario", "Costo Unitario");
            dgvSaldos.Columns.Add("Debe", "Debe");
            dgvSaldos.Columns.Add("Haber", "Haber");
            dgvSaldos.Columns.Add("Saldo", "Saldo");

            // Aplicar el formato de moneda a las columnas adecuadas
            dgvSaldos.Columns["CostoUnitario"].DefaultCellStyle.Format = "C";
            dgvSaldos.Columns["Debe"].DefaultCellStyle.Format = "C";
            dgvSaldos.Columns["Haber"].DefaultCellStyle.Format = "C";
            dgvSaldos.Columns["Saldo"].DefaultCellStyle.Format = "C";
        }

        // Método para actualizar el DataGridView con el historial de inventario
        private void ActualizarDataGridView()
        {
            dgvSaldos.Rows.Clear(); // Limpiar las filas previas

            // Obtener el historial del inventario y añadir cada registro al DataGridView
            foreach (var registro in inventario.ObtenerHistorial())
            {
                dgvSaldos.Rows.Add(
                    registro.Fecha.ToShortDateString(),   // Fecha
                    registro.CantidadEntrada,             // Cantidad Entrada
                    registro.CantidadSalida,              // Cantidad Salida
                    registro.CantidadSaldo,               // Existencia
                    registro.ValorUnitarioEntrada ?? registro.ValorUnitarioSalida, // Costo Unitario (formateado como moneda)
                    registro.ValorTotalEntrada,           // Debe (formateado como moneda)
                    registro.ValorTotalSalida,            // Haber (formateado como moneda)
                    registro.ValorTotalSaldo              // Saldo (formateado como moneda)
                );
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechaCompra.Value;
            int cantidad;
            decimal precioUnitario;

            // Validar que la cantidad sea un número entero positivo
            if (!int.TryParse(txtCantidadCompra.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida (entero positivo).", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el precio unitario sea un número decimal positivo
            if (!decimal.TryParse(txtPrecioUnitario.Text, out precioUnitario) || precioUnitario <= 0)
            {
                MessageBox.Show("Por favor, ingresa un precio unitario válido (número decimal positivo).", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inventario == null)
            {
                MessageBox.Show("Por favor, selecciona un método de inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            inventario.RegistrarCompra(fecha, cantidad, precioUnitario);
            ActualizarDataGridView();
        }


        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechaVenta.Value;
            int cantidad;

            // Validar que la cantidad sea un número entero positivo
            if (!int.TryParse(txtCantidadVenta.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida (entero positivo).", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar registrar la venta
            try
            {
                inventario.RegistrarVenta(fecha, cantidad);
                ActualizarDataGridView(); // Actualizar el DataGridView después de la venta
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMetodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cbMetodo.SelectedItem.ToString())
            {
                case "PEPS":
                    inventario = new InventarioPEPS();
                    break;
                case "UEPS":
                    inventario = new InventarioUEPS();
                    break;
                case "Promedio":
                    inventario = new InventarioPromedio(); // Usar la nueva clase
                    break;
            }
            ActualizarDataGridView();
        }
    }
}
