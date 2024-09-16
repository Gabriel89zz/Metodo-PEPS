namespace Metodo_PEPS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnRegistrarCompra = new Button();
            btnRegistrarVenta = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCantidadCompra = new TextBox();
            txtPrecioUnitario = new TextBox();
            dtpFechaCompra = new DateTimePicker();
            dtpFechaVenta = new DateTimePicker();
            txtCantidadVenta = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dgvSaldos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSaldos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(186, 23);
            label1.Name = "label1";
            label1.Size = new Size(654, 29);
            label1.TabIndex = 0;
            label1.Text = "VALUACION DE INVENTARIOS POR EL METODO PEPS";
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarCompra.BackColor = Color.White;
            btnRegistrarCompra.FlatAppearance.BorderSize = 0;
            btnRegistrarCompra.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnRegistrarCompra.FlatStyle = FlatStyle.Flat;
            btnRegistrarCompra.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            btnRegistrarCompra.Location = new Point(509, 169);
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(100, 31);
            btnRegistrarCompra.TabIndex = 1;
            btnRegistrarCompra.Text = "Comprar";
            btnRegistrarCompra.UseVisualStyleBackColor = false;
            btnRegistrarCompra.Click += btnRegistrarCompra_Click_1;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrarVenta.BackColor = Color.White;
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            btnRegistrarVenta.Location = new Point(507, 304);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(100, 31);
            btnRegistrarVenta.TabIndex = 2;
            btnRegistrarVenta.Text = "Vender";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(462, 98);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(711, 98);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 4;
            label3.Text = "Precio Unitario:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(185, 98);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 5;
            label4.Text = "Fecha de Compra:";
            // 
            // txtCantidadCompra
            // 
            txtCantidadCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCantidadCompra.Font = new Font("Yu Gothic Medium", 12F);
            txtCantidadCompra.Location = new Point(462, 121);
            txtCantidadCompra.Name = "txtCantidadCompra";
            txtCantidadCompra.Size = new Size(195, 33);
            txtCantidadCompra.TabIndex = 6;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecioUnitario.Font = new Font("Yu Gothic Medium", 12F);
            txtPrecioUnitario.Location = new Point(711, 121);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(144, 33);
            txtPrecioUnitario.TabIndex = 7;
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaCompra.Font = new Font("Yu Gothic Medium", 12F);
            dtpFechaCompra.Format = DateTimePickerFormat.Short;
            dtpFechaCompra.Location = new Point(185, 121);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(220, 33);
            dtpFechaCompra.TabIndex = 8;
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaVenta.Font = new Font("Yu Gothic Medium", 12F);
            dtpFechaVenta.Format = DateTimePickerFormat.Short;
            dtpFechaVenta.Location = new Point(307, 255);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(220, 33);
            dtpFechaVenta.TabIndex = 12;
            // 
            // txtCantidadVenta
            // 
            txtCantidadVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCantidadVenta.Font = new Font("Yu Gothic Medium", 12F);
            txtCantidadVenta.Location = new Point(584, 255);
            txtCantidadVenta.Name = "txtCantidadVenta";
            txtCantidadVenta.Size = new Size(195, 33);
            txtCantidadVenta.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(307, 231);
            label5.Name = "label5";
            label5.Size = new Size(144, 21);
            label5.TabIndex = 10;
            label5.Text = "Fecha de Venta:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(584, 231);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 9;
            label6.Text = "Cantidad:";
            // 
            // dgvSaldos
            // 
            dgvSaldos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSaldos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvSaldos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaldos.Location = new Point(29, 365);
            dgvSaldos.Name = "dgvSaldos";
            dgvSaldos.ReadOnly = true;
            dgvSaldos.Size = new Size(1021, 266);
            dgvSaldos.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1083, 657);
            Controls.Add(dgvSaldos);
            Controls.Add(dtpFechaVenta);
            Controls.Add(txtCantidadVenta);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dtpFechaCompra);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidadCompra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(btnRegistrarCompra);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PEPS";
            ((System.ComponentModel.ISupportInitialize)dgvSaldos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrarCompra;
        private Button btnRegistrarVenta;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCantidadCompra;
        private TextBox txtPrecioUnitario;
        private DateTimePicker dtpFechaCompra;
        private DateTimePicker dtpFechaVenta;
        private TextBox txtCantidadVenta;
        private Label label5;
        private Label label6;
        private DataGridView dgvSaldos;
    }
}
