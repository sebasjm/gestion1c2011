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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lNombreMarca = new System.Windows.Forms.Label();
            this.lCodProd = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bCrearOtro = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.treeCategorias = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(131, 149);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(172, 20);
            this.txtPrecio.TabIndex = 55;
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(12, 125);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 53;
            this.lCategoria.Text = "Categoria";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(12, 152);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(84, 13);
            this.lPrecio.TabIndex = 51;
            this.lPrecio.Text = "Precio en Pesos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(131, 94);
            this.txtDescripcion.MaxLength = 8;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcion.TabIndex = 50;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(12, 97);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lDescripcion.TabIndex = 49;
            this.lDescripcion.Text = "Descripción";
            // 
            // lNombreMarca
            // 
            this.lNombreMarca.AutoSize = true;
            this.lNombreMarca.Location = new System.Drawing.Point(12, 70);
            this.lNombreMarca.Name = "lNombreMarca";
            this.lNombreMarca.Size = new System.Drawing.Size(86, 13);
            this.lNombreMarca.TabIndex = 48;
            this.lNombreMarca.Text = "Nombre o Marca";
            // 
            // lCodProd
            // 
            this.lCodProd.AutoSize = true;
            this.lCodProd.Location = new System.Drawing.Point(12, 43);
            this.lCodProd.Name = "lCodProd";
            this.lCodProd.Size = new System.Drawing.Size(100, 13);
            this.lCodProd.TabIndex = 47;
            this.lCodProd.Text = "Código de producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 46;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(131, 40);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(172, 20);
            this.txtCodigoProducto.TabIndex = 45;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(15, 12);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(100, 22);
            this.bBuscar.TabIndex = 65;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bCrearOtro
            // 
            this.bCrearOtro.Location = new System.Drawing.Point(339, 219);
            this.bCrearOtro.Name = "bCrearOtro";
            this.bCrearOtro.Size = new System.Drawing.Size(116, 23);
            this.bCrearOtro.TabIndex = 72;
            this.bCrearOtro.Text = "Crear y Continuar";
            this.bCrearOtro.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(70, 185);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(58, 23);
            this.bLimpiar.TabIndex = 71;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 70;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(339, 190);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(116, 23);
            this.bCrear.TabIndex = 69;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(311, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 73;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(311, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 29);
            this.label2.TabIndex = 74;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(311, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(311, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 29);
            this.label4.TabIndex = 76;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(311, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 29);
            this.label5.TabIndex = 77;
            this.label5.Text = "*";
            // 
            // treeCategorias
            // 
            this.treeCategorias.Location = new System.Drawing.Point(339, 40);
            this.treeCategorias.Name = "treeCategorias";
            this.treeCategorias.Size = new System.Drawing.Size(120, 127);
            this.treeCategorias.TabIndex = 87;
            this.treeCategorias.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCategorias_AfterSelect);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(394, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 29);
            this.label7.TabIndex = 88;
            this.label7.Text = "*";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Location = new System.Drawing.Point(131, 122);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(172, 22);
            this.txtCategoria.TabIndex = 89;
            // 
            // FormAbmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 254);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.treeCategorias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.txtPrecio);
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

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lNombreMarca;
        private System.Windows.Forms.Label lCodProd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bCrearOtro;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeCategorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtCategoria;
    }
}