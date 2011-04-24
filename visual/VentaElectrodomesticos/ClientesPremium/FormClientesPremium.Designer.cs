namespace VentaElectrodomesticos.ClientesPremium
{
    partial class FormClientesPremium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbAnioAnalizar = new System.Windows.Forms.ComboBox();
            this.lAnioAnalizar = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lSucursal = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaUltimaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAnioAnalizar
            // 
            this.cmbAnioAnalizar.FormattingEnabled = true;
            this.cmbAnioAnalizar.Location = new System.Drawing.Point(128, 39);
            this.cmbAnioAnalizar.Name = "cmbAnioAnalizar";
            this.cmbAnioAnalizar.Size = new System.Drawing.Size(121, 21);
            this.cmbAnioAnalizar.TabIndex = 32;
            // 
            // lAnioAnalizar
            // 
            this.lAnioAnalizar.AutoSize = true;
            this.lAnioAnalizar.Location = new System.Drawing.Point(15, 42);
            this.lAnioAnalizar.Name = "lAnioAnalizar";
            this.lAnioAnalizar.Size = new System.Drawing.Size(78, 13);
            this.lAnioAnalizar.TabIndex = 31;
            this.lAnioAnalizar.Text = "Año a Analizar:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(128, 12);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 30;
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(15, 15);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 29;
            this.lSucursal.Text = "Sucursal:";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(696, 231);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 38;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.ApellidoCliente,
            this.DniCliente,
            this.MontoTotal,
            this.TotalProductos,
            this.FechaUltimaCompra,
            this.DniVendedor});
            this.dataGridView1.Location = new System.Drawing.Point(18, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre del Cliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "Apellido del Cliente";
            this.ApellidoCliente.Name = "ApellidoCliente";
            // 
            // DniCliente
            // 
            this.DniCliente.HeaderText = "DNI del Cliente";
            this.DniCliente.Name = "DniCliente";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // TotalProductos
            // 
            this.TotalProductos.HeaderText = "Total de Productos";
            this.TotalProductos.Name = "TotalProductos";
            // 
            // FechaUltimaCompra
            // 
            this.FechaUltimaCompra.HeaderText = "Fecha de la Última Compra";
            this.FechaUltimaCompra.Name = "FechaUltimaCompra";
            // 
            // DniVendedor
            // 
            this.DniVendedor.HeaderText = "DNI del Vendedor";
            this.DniVendedor.Name = "DniVendedor";
            // 
            // FormClientesPremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 266);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cmbAnioAnalizar);
            this.Controls.Add(this.lAnioAnalizar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lSucursal);
            this.Name = "FormClientesPremium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Premium";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAnioAnalizar;
        private System.Windows.Forms.Label lAnioAnalizar;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaUltimaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniVendedor;
    }
}