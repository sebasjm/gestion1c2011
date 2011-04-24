namespace VentaElectrodomesticos.Facturacion
{
    partial class FormFacturacion
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
            this.lProvincia = new System.Windows.Forms.Label();
            this.lSucursal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.lListadoProductos = new System.Windows.Forms.Label();
            this.bBuscarProducto = new System.Windows.Forms.Button();
            this.lDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lFormaPago = new System.Windows.Forms.Label();
            this.cmbFormasPago = new System.Windows.Forms.ComboBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.lMontoTotal = new System.Windows.Forms.Label();
            this.lCuotas = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.dataListadoProductos = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(12, 19);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(54, 13);
            this.lProvincia.TabIndex = 0;
            this.lProvincia.Text = "Provincia:";
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(285, 17);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 1;
            this.lSucursal.Text = "Sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(126, 11);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 3;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(342, 14);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 4;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(126, 50);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 5;
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(288, 48);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(119, 23);
            this.bBuscarCliente.TabIndex = 6;
            this.bBuscarCliente.Text = "Buscar Cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lListadoProductos
            // 
            this.lListadoProductos.AutoSize = true;
            this.lListadoProductos.Location = new System.Drawing.Point(12, 103);
            this.lListadoProductos.Name = "lListadoProductos";
            this.lListadoProductos.Size = new System.Drawing.Size(110, 13);
            this.lListadoProductos.TabIndex = 7;
            this.lListadoProductos.Text = "Listado de Productos:";
            // 
            // bBuscarProducto
            // 
            this.bBuscarProducto.Location = new System.Drawing.Point(128, 93);
            this.bBuscarProducto.Name = "bBuscarProducto";
            this.bBuscarProducto.Size = new System.Drawing.Size(130, 23);
            this.bBuscarProducto.TabIndex = 9;
            this.bBuscarProducto.Text = "Buscar Producto";
            this.bBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // lDescuento
            // 
            this.lDescuento.AutoSize = true;
            this.lDescuento.Location = new System.Drawing.Point(15, 294);
            this.lDescuento.Name = "lDescuento";
            this.lDescuento.Size = new System.Drawing.Size(62, 13);
            this.lDescuento.TabIndex = 10;
            this.lDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(126, 294);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 11;
            // 
            // lFormaPago
            // 
            this.lFormaPago.AutoSize = true;
            this.lFormaPago.Location = new System.Drawing.Point(15, 324);
            this.lFormaPago.Name = "lFormaPago";
            this.lFormaPago.Size = new System.Drawing.Size(82, 13);
            this.lFormaPago.TabIndex = 12;
            this.lFormaPago.Text = "Forma de Pago:";
            // 
            // cmbFormasPago
            // 
            this.cmbFormasPago.FormattingEnabled = true;
            this.cmbFormasPago.Location = new System.Drawing.Point(126, 324);
            this.cmbFormasPago.Name = "cmbFormasPago";
            this.cmbFormasPago.Size = new System.Drawing.Size(121, 21);
            this.cmbFormasPago.TabIndex = 13;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(15, 356);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 14;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(381, 361);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 15;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // lMontoTotal
            // 
            this.lMontoTotal.AutoSize = true;
            this.lMontoTotal.Location = new System.Drawing.Point(155, 361);
            this.lMontoTotal.Name = "lMontoTotal";
            this.lMontoTotal.Size = new System.Drawing.Size(117, 13);
            this.lMontoTotal.TabIndex = 16;
            this.lMontoTotal.Text = "Monto Total : 20 Pesos";
            // 
            // lCuotas
            // 
            this.lCuotas.AutoSize = true;
            this.lCuotas.Location = new System.Drawing.Point(267, 327);
            this.lCuotas.Name = "lCuotas";
            this.lCuotas.Size = new System.Drawing.Size(43, 13);
            this.lCuotas.TabIndex = 17;
            this.lCuotas.Text = "Cuotas:";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(336, 324);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtCuotas.TabIndex = 18;
            // 
            // dataListadoProductos
            // 
            this.dataListadoProductos.AllowUserToOrderColumns = true;
            this.dataListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion,
            this.Cantidad,
            this.Total});
            this.dataListadoProductos.Location = new System.Drawing.Point(15, 132);
            this.dataListadoProductos.Name = "dataListadoProductos";
            this.dataListadoProductos.Size = new System.Drawing.Size(441, 150);
            this.dataListadoProductos.TabIndex = 19;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.dataListadoProductos);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.lCuotas);
            this.Controls.Add(this.lMontoTotal);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cmbFormasPago);
            this.Controls.Add(this.lFormaPago);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lDescuento);
            this.Controls.Add(this.bBuscarProducto);
            this.Controls.Add(this.lListadoProductos);
            this.Controls.Add(this.bBuscarCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lSucursal);
            this.Controls.Add(this.lProvincia);
            this.Name = "FormFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProvincia;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button bBuscarCliente;
        private System.Windows.Forms.Label lListadoProductos;
        private System.Windows.Forms.Button bBuscarProducto;
        private System.Windows.Forms.Label lDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lFormaPago;
        private System.Windows.Forms.ComboBox cmbFormasPago;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label lMontoTotal;
        private System.Windows.Forms.Label lCuotas;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.DataGridView dataListadoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}