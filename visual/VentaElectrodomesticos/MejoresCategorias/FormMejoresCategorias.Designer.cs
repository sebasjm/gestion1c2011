namespace VentaElectrodomesticos.MejoresCategorias
{
    partial class FormMejoresCategorias
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.cmbAnioAnalizar = new System.Windows.Forms.ComboBox();
            this.lAnioAnalizar = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lSucursal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadSubCategorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoNombreProductoMasVendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProductoMasMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProductoMasCaro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellidoVendedorMasVendio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(700, 231);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 43;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // cmbAnioAnalizar
            // 
            this.cmbAnioAnalizar.FormattingEnabled = true;
            this.cmbAnioAnalizar.Location = new System.Drawing.Point(142, 39);
            this.cmbAnioAnalizar.Name = "cmbAnioAnalizar";
            this.cmbAnioAnalizar.Size = new System.Drawing.Size(121, 21);
            this.cmbAnioAnalizar.TabIndex = 42;
            // 
            // lAnioAnalizar
            // 
            this.lAnioAnalizar.AutoSize = true;
            this.lAnioAnalizar.Location = new System.Drawing.Point(29, 42);
            this.lAnioAnalizar.Name = "lAnioAnalizar";
            this.lAnioAnalizar.Size = new System.Drawing.Size(78, 13);
            this.lAnioAnalizar.TabIndex = 41;
            this.lAnioAnalizar.Text = "Año a Analizar:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(142, 12);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 40;
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(29, 15);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 39;
            this.lSucursal.Text = "Sucursal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCategoria,
            this.CantidadSubCategorias,
            this.MontoTotal,
            this.CodigoNombreProductoMasVendido,
            this.NombreProductoMasMonto,
            this.NombreProductoMasCaro,
            this.NombreApellidoVendedorMasVendio});
            this.dataGridView1.Location = new System.Drawing.Point(32, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 44;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.HeaderText = "Nombre de la Categoría";
            this.NombreCategoria.Name = "NombreCategoria";
            // 
            // CantidadSubCategorias
            // 
            this.CantidadSubCategorias.HeaderText = "Cantidad de Sub Categorías";
            this.CantidadSubCategorias.Name = "CantidadSubCategorias";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // CodigoNombreProductoMasVendido
            // 
            this.CodigoNombreProductoMasVendido.HeaderText = "Código y Nombre del Producto más Vendido";
            this.CodigoNombreProductoMasVendido.Name = "CodigoNombreProductoMasVendido";
            // 
            // NombreProductoMasMonto
            // 
            this.NombreProductoMasMonto.HeaderText = "Código y Nombre de Producto con más Monto Total";
            this.NombreProductoMasMonto.Name = "NombreProductoMasMonto";
            // 
            // NombreProductoMasCaro
            // 
            this.NombreProductoMasCaro.HeaderText = "Código y Nombre de Producto que se vendió mas caro";
            this.NombreProductoMasCaro.Name = "NombreProductoMasCaro";
            // 
            // NombreApellidoVendedorMasVendio
            // 
            this.NombreApellidoVendedorMasVendio.HeaderText = "Nombre y Apellido del Vendedor que más Vendió";
            this.NombreApellidoVendedorMasVendio.Name = "NombreApellidoVendedorMasVendio";
            // 
            // FormMejoresCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 266);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cmbAnioAnalizar);
            this.Controls.Add(this.lAnioAnalizar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lSucursal);
            this.Name = "FormMejoresCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mejores Categorías";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ComboBox cmbAnioAnalizar;
        private System.Windows.Forms.Label lAnioAnalizar;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadSubCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoNombreProductoMasVendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProductoMasMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProductoMasCaro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellidoVendedorMasVendio;
    }
}