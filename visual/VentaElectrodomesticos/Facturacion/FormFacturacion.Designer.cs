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
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.lListadoProductos = new System.Windows.Forms.Label();
            this.bBuscarProducto = new System.Windows.Forms.Button();
            this.lDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lFormaPago = new System.Windows.Forms.Label();
            this.cmbFormasPago = new System.Windows.Forms.ComboBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.lCuotas = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.dataListadoProductos = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lTotalDescuento = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.bAgregarProducto = new System.Windows.Forms.Button();
            this.lCuota = new System.Windows.Forms.Label();
            this.lTotalCuota = new System.Windows.Forms.Label();
            this.lErrorCantidad = new System.Windows.Forms.Label();
            this.lErrorDescuento = new System.Windows.Forms.Label();
            this.lErrorCuotas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(17, 14);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(54, 13);
            this.lProvincia.TabIndex = 0;
            this.lProvincia.Text = "Provincia:";
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(283, 12);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 1;
            this.lSucursal.Text = "Sucursal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
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
            this.cmbProvincia.Size = new System.Drawing.Size(131, 21);
            this.cmbProvincia.TabIndex = 3;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(340, 9);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(109, 21);
            this.cmbSucursal.TabIndex = 4;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(286, 36);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(163, 23);
            this.bBuscarCliente.TabIndex = 6;
            this.bBuscarCliente.Text = "Buscar cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            this.bBuscarCliente.Click += new System.EventHandler(this.bBuscarCliente_Click);
            // 
            // lListadoProductos
            // 
            this.lListadoProductos.AutoSize = true;
            this.lListadoProductos.Location = new System.Drawing.Point(17, 72);
            this.lListadoProductos.Name = "lListadoProductos";
            this.lListadoProductos.Size = new System.Drawing.Size(110, 13);
            this.lListadoProductos.TabIndex = 7;
            this.lListadoProductos.Text = "Listado de Productos:";
            // 
            // bBuscarProducto
            // 
            this.bBuscarProducto.Location = new System.Drawing.Point(286, 67);
            this.bBuscarProducto.Name = "bBuscarProducto";
            this.bBuscarProducto.Size = new System.Drawing.Size(163, 23);
            this.bBuscarProducto.TabIndex = 9;
            this.bBuscarProducto.Text = "Buscar producto";
            this.bBuscarProducto.UseVisualStyleBackColor = true;
            this.bBuscarProducto.Click += new System.EventHandler(this.bBuscarProducto_Click);
            // 
            // lDescuento
            // 
            this.lDescuento.AutoSize = true;
            this.lDescuento.Location = new System.Drawing.Point(17, 363);
            this.lDescuento.Name = "lDescuento";
            this.lDescuento.Size = new System.Drawing.Size(62, 13);
            this.lDescuento.TabIndex = 10;
            this.lDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(126, 356);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(131, 20);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.Leave += new System.EventHandler(this.txtDescuento_Leave);
            // 
            // lFormaPago
            // 
            this.lFormaPago.AutoSize = true;
            this.lFormaPago.Location = new System.Drawing.Point(17, 386);
            this.lFormaPago.Name = "lFormaPago";
            this.lFormaPago.Size = new System.Drawing.Size(82, 13);
            this.lFormaPago.TabIndex = 12;
            this.lFormaPago.Text = "Forma de Pago:";
            // 
            // cmbFormasPago
            // 
            this.cmbFormasPago.FormattingEnabled = true;
            this.cmbFormasPago.Location = new System.Drawing.Point(126, 383);
            this.cmbFormasPago.Name = "cmbFormasPago";
            this.cmbFormasPago.Size = new System.Drawing.Size(131, 21);
            this.cmbFormasPago.TabIndex = 13;
            this.cmbFormasPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormasPago_SelectedIndexChanged);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(15, 410);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 14;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(395, 410);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 15;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // lCuotas
            // 
            this.lCuotas.AutoSize = true;
            this.lCuotas.Location = new System.Drawing.Point(283, 387);
            this.lCuotas.Name = "lCuotas";
            this.lCuotas.Size = new System.Drawing.Size(43, 13);
            this.lCuotas.TabIndex = 17;
            this.lCuotas.Text = "Cuotas:";
            this.lCuotas.Visible = false;
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(403, 384);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(67, 20);
            this.txtCuotas.TabIndex = 18;
            this.txtCuotas.Visible = false;
            this.txtCuotas.Leave += new System.EventHandler(this.txtCuotas_Leave);
            // 
            // dataListadoProductos
            // 
            this.dataListadoProductos.AllowUserToAddRows = false;
            this.dataListadoProductos.AllowUserToDeleteRows = false;
            this.dataListadoProductos.AllowUserToOrderColumns = true;
            this.dataListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoProductos.Location = new System.Drawing.Point(15, 127);
            this.dataListadoProductos.Name = "dataListadoProductos";
            this.dataListadoProductos.ReadOnly = true;
            this.dataListadoProductos.RowHeadersVisible = false;
            this.dataListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoProductos.Size = new System.Drawing.Size(465, 191);
            this.dataListadoProductos.TabIndex = 19;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(126, 40);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(131, 21);
            this.txtCliente.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total:";
            // 
            // lTotal
            // 
            this.lTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTotal.Location = new System.Drawing.Point(126, 330);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(131, 20);
            this.lTotal.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total con descuento:";
            // 
            // lTotalDescuento
            // 
            this.lTotalDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTotalDescuento.Location = new System.Drawing.Point(403, 330);
            this.lTotalDescuento.Name = "lTotalDescuento";
            this.lTotalDescuento.Size = new System.Drawing.Size(67, 20);
            this.lTotalDescuento.TabIndex = 25;
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(126, 71);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(131, 21);
            this.txtProducto.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(126, 98);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(131, 20);
            this.txtCantidad.TabIndex = 28;
            // 
            // bAgregarProducto
            // 
            this.bAgregarProducto.Location = new System.Drawing.Point(286, 96);
            this.bAgregarProducto.Name = "bAgregarProducto";
            this.bAgregarProducto.Size = new System.Drawing.Size(163, 23);
            this.bAgregarProducto.TabIndex = 29;
            this.bAgregarProducto.Text = "Agregar producto";
            this.bAgregarProducto.UseVisualStyleBackColor = true;
            this.bAgregarProducto.Click += new System.EventHandler(this.bAgregarProducto_Click);
            // 
            // lCuota
            // 
            this.lCuota.AutoSize = true;
            this.lCuota.Location = new System.Drawing.Point(283, 363);
            this.lCuota.Name = "lCuota";
            this.lCuota.Size = new System.Drawing.Size(82, 13);
            this.lCuota.TabIndex = 31;
            this.lCuota.Text = "Total por cuota:";
            this.lCuota.Visible = false;
            // 
            // lTotalCuota
            // 
            this.lTotalCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTotalCuota.Location = new System.Drawing.Point(403, 359);
            this.lTotalCuota.Name = "lTotalCuota";
            this.lTotalCuota.Size = new System.Drawing.Size(67, 20);
            this.lTotalCuota.TabIndex = 32;
            this.lTotalCuota.Visible = false;
            // 
            // lErrorCantidad
            // 
            this.lErrorCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lErrorCantidad.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.lErrorCantidad.Location = new System.Drawing.Point(263, 96);
            this.lErrorCantidad.Name = "lErrorCantidad";
            this.lErrorCantidad.Size = new System.Drawing.Size(22, 15);
            this.lErrorCantidad.TabIndex = 71;
            this.lErrorCantidad.Text = "*";
            this.lErrorCantidad.Visible = false;
            // 
            // lErrorDescuento
            // 
            this.lErrorDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lErrorDescuento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorDescuento.ForeColor = System.Drawing.Color.Red;
            this.lErrorDescuento.Location = new System.Drawing.Point(263, 356);
            this.lErrorDescuento.Name = "lErrorDescuento";
            this.lErrorDescuento.Size = new System.Drawing.Size(22, 15);
            this.lErrorDescuento.TabIndex = 72;
            this.lErrorDescuento.Text = "*";
            this.lErrorDescuento.Visible = false;
            // 
            // lErrorCuotas
            // 
            this.lErrorCuotas.BackColor = System.Drawing.Color.Transparent;
            this.lErrorCuotas.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorCuotas.ForeColor = System.Drawing.Color.Red;
            this.lErrorCuotas.Location = new System.Drawing.Point(476, 385);
            this.lErrorCuotas.Name = "lErrorCuotas";
            this.lErrorCuotas.Size = new System.Drawing.Size(22, 15);
            this.lErrorCuotas.TabIndex = 73;
            this.lErrorCuotas.Text = "*";
            this.lErrorCuotas.Visible = false;
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 435);
            this.Controls.Add(this.lErrorCuotas);
            this.Controls.Add(this.lErrorDescuento);
            this.Controls.Add(this.lErrorCantidad);
            this.Controls.Add(this.lTotalCuota);
            this.Controls.Add(this.lCuota);
            this.Controls.Add(this.bAgregarProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lTotalDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dataListadoProductos);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.lCuotas);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.cmbFormasPago);
            this.Controls.Add(this.lFormaPago);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lDescuento);
            this.Controls.Add(this.bBuscarProducto);
            this.Controls.Add(this.lListadoProductos);
            this.Controls.Add(this.bBuscarCliente);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lSucursal);
            this.Controls.Add(this.lProvincia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button bBuscarCliente;
        private System.Windows.Forms.Label lListadoProductos;
        private System.Windows.Forms.Button bBuscarProducto;
        private System.Windows.Forms.Label lDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lFormaPago;
        private System.Windows.Forms.ComboBox cmbFormasPago;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label lCuotas;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.DataGridView dataListadoProductos;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lTotalDescuento;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button bAgregarProducto;
        private System.Windows.Forms.Label lCuota;
        private System.Windows.Forms.Label lTotalCuota;
        private System.Windows.Forms.Label lErrorCantidad;
        private System.Windows.Forms.Label lErrorDescuento;
        private System.Windows.Forms.Label lErrorCuotas;
    }
}