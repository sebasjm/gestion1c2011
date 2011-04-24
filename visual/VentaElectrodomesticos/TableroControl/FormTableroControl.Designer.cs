namespace VentaElectrodomesticos.TableroControl
{
    partial class FormTableroControl
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
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lSucursal = new System.Windows.Forms.Label();
            this.cmbAnioAnalizar = new System.Windows.Forms.ComboBox();
            this.lAnioAnalizar = new System.Windows.Forms.Label();
            this.lTotalVentas = new System.Windows.Forms.Label();
            this.lTotalFacturacion = new System.Windows.Forms.Label();
            this.lProporcionFormaPago = new System.Windows.Forms.Label();
            this.lMayorFactura = new System.Windows.Forms.Label();
            this.lMayorDeudor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.lValorTotalVentas = new System.Windows.Forms.Label();
            this.lValorTotalFacturacion = new System.Windows.Forms.Label();
            this.lValorProporcionFormaPago = new System.Windows.Forms.Label();
            this.lValorMayorFactura = new System.Windows.Forms.Label();
            this.lValorMayorDeudor = new System.Windows.Forms.Label();
            this.lValorVendedorAnio = new System.Windows.Forms.Label();
            this.lValorProductoAnio = new System.Windows.Forms.Label();
            this.lValorFaltanteStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(125, 12);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 26;
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(12, 15);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 25;
            this.lSucursal.Text = "Sucursal:";
            // 
            // cmbAnioAnalizar
            // 
            this.cmbAnioAnalizar.FormattingEnabled = true;
            this.cmbAnioAnalizar.Location = new System.Drawing.Point(125, 39);
            this.cmbAnioAnalizar.Name = "cmbAnioAnalizar";
            this.cmbAnioAnalizar.Size = new System.Drawing.Size(121, 21);
            this.cmbAnioAnalizar.TabIndex = 28;
            // 
            // lAnioAnalizar
            // 
            this.lAnioAnalizar.AutoSize = true;
            this.lAnioAnalizar.Location = new System.Drawing.Point(12, 42);
            this.lAnioAnalizar.Name = "lAnioAnalizar";
            this.lAnioAnalizar.Size = new System.Drawing.Size(78, 13);
            this.lAnioAnalizar.TabIndex = 27;
            this.lAnioAnalizar.Text = "Año a Analizar:";
            // 
            // lTotalVentas
            // 
            this.lTotalVentas.AutoSize = true;
            this.lTotalVentas.Location = new System.Drawing.Point(122, 82);
            this.lTotalVentas.Name = "lTotalVentas";
            this.lTotalVentas.Size = new System.Drawing.Size(82, 13);
            this.lTotalVentas.TabIndex = 29;
            this.lTotalVentas.Text = "Total de Ventas";
            // 
            // lTotalFacturacion
            // 
            this.lTotalFacturacion.AutoSize = true;
            this.lTotalFacturacion.Location = new System.Drawing.Point(122, 110);
            this.lTotalFacturacion.Name = "lTotalFacturacion";
            this.lTotalFacturacion.Size = new System.Drawing.Size(105, 13);
            this.lTotalFacturacion.TabIndex = 30;
            this.lTotalFacturacion.Text = "Total de Facturacion";
            // 
            // lProporcionFormaPago
            // 
            this.lProporcionFormaPago.AutoSize = true;
            this.lProporcionFormaPago.Location = new System.Drawing.Point(122, 136);
            this.lProporcionFormaPago.Name = "lProporcionFormaPago";
            this.lProporcionFormaPago.Size = new System.Drawing.Size(133, 13);
            this.lProporcionFormaPago.TabIndex = 31;
            this.lProporcionFormaPago.Text = "Proporción Forma de Pago";
            // 
            // lMayorFactura
            // 
            this.lMayorFactura.AutoSize = true;
            this.lMayorFactura.Location = new System.Drawing.Point(122, 163);
            this.lMayorFactura.Name = "lMayorFactura";
            this.lMayorFactura.Size = new System.Drawing.Size(75, 13);
            this.lMayorFactura.TabIndex = 32;
            this.lMayorFactura.Text = "Mayor Factura";
            // 
            // lMayorDeudor
            // 
            this.lMayorDeudor.AutoSize = true;
            this.lMayorDeudor.Location = new System.Drawing.Point(122, 194);
            this.lMayorDeudor.Name = "lMayorDeudor";
            this.lMayorDeudor.Size = new System.Drawing.Size(74, 13);
            this.lMayorDeudor.TabIndex = 33;
            this.lMayorDeudor.Text = "Mayor Deudor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Vendedor del Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Producto del Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Faltante de Stock";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(125, 329);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 37;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // lValorTotalVentas
            // 
            this.lValorTotalVentas.AutoSize = true;
            this.lValorTotalVentas.Location = new System.Drawing.Point(38, 82);
            this.lValorTotalVentas.Name = "lValorTotalVentas";
            this.lValorTotalVentas.Size = new System.Drawing.Size(25, 13);
            this.lValorTotalVentas.TabIndex = 38;
            this.lValorTotalVentas.Text = "100";
            // 
            // lValorTotalFacturacion
            // 
            this.lValorTotalFacturacion.AutoSize = true;
            this.lValorTotalFacturacion.Location = new System.Drawing.Point(38, 110);
            this.lValorTotalFacturacion.Name = "lValorTotalFacturacion";
            this.lValorTotalFacturacion.Size = new System.Drawing.Size(25, 13);
            this.lValorTotalFacturacion.TabIndex = 39;
            this.lValorTotalFacturacion.Text = "100";
            // 
            // lValorProporcionFormaPago
            // 
            this.lValorProporcionFormaPago.AutoSize = true;
            this.lValorProporcionFormaPago.Location = new System.Drawing.Point(38, 136);
            this.lValorProporcionFormaPago.Name = "lValorProporcionFormaPago";
            this.lValorProporcionFormaPago.Size = new System.Drawing.Size(25, 13);
            this.lValorProporcionFormaPago.TabIndex = 40;
            this.lValorProporcionFormaPago.Text = "100";
            // 
            // lValorMayorFactura
            // 
            this.lValorMayorFactura.AutoSize = true;
            this.lValorMayorFactura.Location = new System.Drawing.Point(38, 163);
            this.lValorMayorFactura.Name = "lValorMayorFactura";
            this.lValorMayorFactura.Size = new System.Drawing.Size(25, 13);
            this.lValorMayorFactura.TabIndex = 41;
            this.lValorMayorFactura.Text = "100";
            // 
            // lValorMayorDeudor
            // 
            this.lValorMayorDeudor.AutoSize = true;
            this.lValorMayorDeudor.Location = new System.Drawing.Point(38, 194);
            this.lValorMayorDeudor.Name = "lValorMayorDeudor";
            this.lValorMayorDeudor.Size = new System.Drawing.Size(25, 13);
            this.lValorMayorDeudor.TabIndex = 42;
            this.lValorMayorDeudor.Text = "100";
            // 
            // lValorVendedorAnio
            // 
            this.lValorVendedorAnio.AutoSize = true;
            this.lValorVendedorAnio.Location = new System.Drawing.Point(38, 226);
            this.lValorVendedorAnio.Name = "lValorVendedorAnio";
            this.lValorVendedorAnio.Size = new System.Drawing.Size(25, 13);
            this.lValorVendedorAnio.TabIndex = 43;
            this.lValorVendedorAnio.Text = "100";
            // 
            // lValorProductoAnio
            // 
            this.lValorProductoAnio.AutoSize = true;
            this.lValorProductoAnio.Location = new System.Drawing.Point(38, 257);
            this.lValorProductoAnio.Name = "lValorProductoAnio";
            this.lValorProductoAnio.Size = new System.Drawing.Size(25, 13);
            this.lValorProductoAnio.TabIndex = 44;
            this.lValorProductoAnio.Text = "100";
            // 
            // lValorFaltanteStock
            // 
            this.lValorFaltanteStock.AutoSize = true;
            this.lValorFaltanteStock.Location = new System.Drawing.Point(38, 286);
            this.lValorFaltanteStock.Name = "lValorFaltanteStock";
            this.lValorFaltanteStock.Size = new System.Drawing.Size(25, 13);
            this.lValorFaltanteStock.TabIndex = 45;
            this.lValorFaltanteStock.Text = "100";
            // 
            // FormTableroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 381);
            this.Controls.Add(this.lValorFaltanteStock);
            this.Controls.Add(this.lValorProductoAnio);
            this.Controls.Add(this.lValorVendedorAnio);
            this.Controls.Add(this.lValorMayorDeudor);
            this.Controls.Add(this.lValorMayorFactura);
            this.Controls.Add(this.lValorProporcionFormaPago);
            this.Controls.Add(this.lValorTotalFacturacion);
            this.Controls.Add(this.lValorTotalVentas);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lMayorDeudor);
            this.Controls.Add(this.lMayorFactura);
            this.Controls.Add(this.lProporcionFormaPago);
            this.Controls.Add(this.lTotalFacturacion);
            this.Controls.Add(this.lTotalVentas);
            this.Controls.Add(this.cmbAnioAnalizar);
            this.Controls.Add(this.lAnioAnalizar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lSucursal);
            this.Name = "FormTableroControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablero de Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.ComboBox cmbAnioAnalizar;
        private System.Windows.Forms.Label lAnioAnalizar;
        private System.Windows.Forms.Label lTotalVentas;
        private System.Windows.Forms.Label lTotalFacturacion;
        private System.Windows.Forms.Label lProporcionFormaPago;
        private System.Windows.Forms.Label lMayorFactura;
        private System.Windows.Forms.Label lMayorDeudor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lValorTotalVentas;
        private System.Windows.Forms.Label lValorTotalFacturacion;
        private System.Windows.Forms.Label lValorProporcionFormaPago;
        private System.Windows.Forms.Label lValorMayorFactura;
        private System.Windows.Forms.Label lValorMayorDeudor;
        private System.Windows.Forms.Label lValorVendedorAnio;
        private System.Windows.Forms.Label lValorProductoAnio;
        private System.Windows.Forms.Label lValorFaltanteStock;
    }
}