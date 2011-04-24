namespace VentaElectrodomesticos.EfectuarPago
{
    partial class FormEfectuarPago
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
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.lCuotas = new System.Windows.Forms.Label();
            this.lMontoPago = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscarCliente = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lSucursal = new System.Windows.Forms.Label();
            this.lProvincia = new System.Windows.Forms.Label();
            this.lFactura = new System.Windows.Forms.Label();
            this.cmbFactura = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(123, 146);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(121, 20);
            this.txtCuotas.TabIndex = 37;
            // 
            // lCuotas
            // 
            this.lCuotas.AutoSize = true;
            this.lCuotas.Location = new System.Drawing.Point(8, 149);
            this.lCuotas.Name = "lCuotas";
            this.lCuotas.Size = new System.Drawing.Size(43, 13);
            this.lCuotas.TabIndex = 36;
            this.lCuotas.Text = "Cuotas:";
            // 
            // lMontoPago
            // 
            this.lMontoPago.AutoSize = true;
            this.lMontoPago.Location = new System.Drawing.Point(114, 186);
            this.lMontoPago.Name = "lMontoPago";
            this.lMontoPago.Size = new System.Drawing.Size(130, 13);
            this.lMontoPago.TabIndex = 35;
            this.lMontoPago.Text = "Monto a Pagar : 20 Pesos";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(294, 186);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 34;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(13, 186);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 33;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(250, 36);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(119, 23);
            this.bBuscarCliente.TabIndex = 26;
            this.bBuscarCliente.Text = "Buscar Cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(123, 38);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 25;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(123, 73);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 24;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(122, 6);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente:";
            // 
            // lSucursal
            // 
            this.lSucursal.AutoSize = true;
            this.lSucursal.Location = new System.Drawing.Point(10, 76);
            this.lSucursal.Name = "lSucursal";
            this.lSucursal.Size = new System.Drawing.Size(51, 13);
            this.lSucursal.TabIndex = 21;
            this.lSucursal.Text = "Sucursal:";
            // 
            // lProvincia
            // 
            this.lProvincia.AutoSize = true;
            this.lProvincia.Location = new System.Drawing.Point(8, 14);
            this.lProvincia.Name = "lProvincia";
            this.lProvincia.Size = new System.Drawing.Size(54, 13);
            this.lProvincia.TabIndex = 20;
            this.lProvincia.Text = "Provincia:";
            // 
            // lFactura
            // 
            this.lFactura.AutoSize = true;
            this.lFactura.Location = new System.Drawing.Point(9, 113);
            this.lFactura.Name = "lFactura";
            this.lFactura.Size = new System.Drawing.Size(46, 13);
            this.lFactura.TabIndex = 39;
            this.lFactura.Text = "Factura:";
            // 
            // cmbFactura
            // 
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Location = new System.Drawing.Point(123, 110);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(121, 21);
            this.cmbFactura.TabIndex = 40;
            // 
            // FormEfectuarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 236);
            this.Controls.Add(this.cmbFactura);
            this.Controls.Add(this.lFactura);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.lCuotas);
            this.Controls.Add(this.lMontoPago);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bBuscarCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lSucursal);
            this.Controls.Add(this.lProvincia);
            this.Name = "FormEfectuarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efectuar Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label lCuotas;
        private System.Windows.Forms.Label lMontoPago;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBuscarCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSucursal;
        private System.Windows.Forms.Label lProvincia;
        private System.Windows.Forms.Label lFactura;
        private System.Windows.Forms.ComboBox cmbFactura;
    }
}