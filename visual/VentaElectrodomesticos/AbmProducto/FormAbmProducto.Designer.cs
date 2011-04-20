namespace VentaElectrodomesticos.AbmProducto
{
    partial class FormAbmProducto
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lNombreMarca = new System.Windows.Forms.Label();
            this.lCodProd = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(17, 157);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 59;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(179, 157);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 58;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(133, 121);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 55;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(133, 94);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 54;
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(14, 97);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 53;
            this.lCategoria.Text = "Categoria";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(14, 124);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(84, 13);
            this.lPrecio.TabIndex = 51;
            this.lPrecio.Text = "Precio en Pesos";
            this.lPrecio.Click += new System.EventHandler(this.lMail_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 63);
            this.txtDescripcion.MaxLength = 8;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 50;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(14, 66);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 49;
            this.lDescripcion.Text = "Descripción";
            this.lDescripcion.Click += new System.EventHandler(this.lDni_Click);
            // 
            // lNombreMarca
            // 
            this.lNombreMarca.AutoSize = true;
            this.lNombreMarca.Location = new System.Drawing.Point(14, 39);
            this.lNombreMarca.Name = "lNombreMarca";
            this.lNombreMarca.Size = new System.Drawing.Size(86, 13);
            this.lNombreMarca.TabIndex = 48;
            this.lNombreMarca.Text = "Nombre o Marca";
            // 
            // lCodProd
            // 
            this.lCodProd.AutoSize = true;
            this.lCodProd.Location = new System.Drawing.Point(14, 12);
            this.lCodProd.Name = "lCodProd";
            this.lCodProd.Size = new System.Drawing.Size(100, 13);
            this.lCodProd.TabIndex = 47;
            this.lCodProd.Text = "Código de producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 46;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(133, 9);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoProducto.TabIndex = 45;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(98, 157);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 60;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormAbmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 196);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lNombreMarca);
            this.Controls.Add(this.lCodProd);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoProducto);
            this.Name = "FormAbmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lNombreMarca;
        private System.Windows.Forms.Label lCodProd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button bLimpiar;
    }
}