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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bCrear = new System.Windows.Forms.Button();
            this.lErrorCodigo = new System.Windows.Forms.Label();
            this.lErrorNombre = new System.Windows.Forms.Label();
            this.lErrorDescripcion = new System.Windows.Forms.Label();
            this.lErrorCategoria = new System.Windows.Forms.Label();
            this.lErrorPrecio = new System.Windows.Forms.Label();
            this.treeCategorias = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
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
            this.bCrearOtro.Click += new System.EventHandler(this.bCrearOtro_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(70, 185);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(58, 23);
            this.bLimpiar.TabIndex = 71;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(6, 185);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(58, 23);
            this.bCancelar.TabIndex = 70;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bCrear
            // 
            this.bCrear.Location = new System.Drawing.Point(339, 190);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(116, 23);
            this.bCrear.TabIndex = 69;
            this.bCrear.Text = "Crear";
            this.bCrear.UseVisualStyleBackColor = true;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // lErrorCodigo
            // 
            this.lErrorCodigo.AutoSize = true;
            this.lErrorCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lErrorCodigo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorCodigo.ForeColor = System.Drawing.Color.Red;
            this.lErrorCodigo.Location = new System.Drawing.Point(311, 40);
            this.lErrorCodigo.Name = "lErrorCodigo";
            this.lErrorCodigo.Size = new System.Drawing.Size(22, 29);
            this.lErrorCodigo.TabIndex = 73;
            this.lErrorCodigo.Text = "*";
            this.lErrorCodigo.Visible = false;
            // 
            // lErrorNombre
            // 
            this.lErrorNombre.AutoSize = true;
            this.lErrorNombre.BackColor = System.Drawing.Color.Transparent;
            this.lErrorNombre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lErrorNombre.Location = new System.Drawing.Point(311, 67);
            this.lErrorNombre.Name = "lErrorNombre";
            this.lErrorNombre.Size = new System.Drawing.Size(22, 29);
            this.lErrorNombre.TabIndex = 74;
            this.lErrorNombre.Text = "*";
            this.lErrorNombre.Visible = false;
            // 
            // lErrorDescripcion
            // 
            this.lErrorDescripcion.AutoSize = true;
            this.lErrorDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lErrorDescripcion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lErrorDescripcion.Location = new System.Drawing.Point(311, 94);
            this.lErrorDescripcion.Name = "lErrorDescripcion";
            this.lErrorDescripcion.Size = new System.Drawing.Size(22, 29);
            this.lErrorDescripcion.TabIndex = 75;
            this.lErrorDescripcion.Text = "*";
            this.lErrorDescripcion.Visible = false;
            // 
            // lErrorCategoria
            // 
            this.lErrorCategoria.AutoSize = true;
            this.lErrorCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lErrorCategoria.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorCategoria.ForeColor = System.Drawing.Color.Red;
            this.lErrorCategoria.Location = new System.Drawing.Point(311, 122);
            this.lErrorCategoria.Name = "lErrorCategoria";
            this.lErrorCategoria.Size = new System.Drawing.Size(22, 29);
            this.lErrorCategoria.TabIndex = 76;
            this.lErrorCategoria.Text = "*";
            this.lErrorCategoria.Visible = false;
            // 
            // lErrorPrecio
            // 
            this.lErrorPrecio.AutoSize = true;
            this.lErrorPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lErrorPrecio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lErrorPrecio.Location = new System.Drawing.Point(311, 149);
            this.lErrorPrecio.Name = "lErrorPrecio";
            this.lErrorPrecio.Size = new System.Drawing.Size(22, 29);
            this.lErrorPrecio.TabIndex = 77;
            this.lErrorPrecio.Text = "*";
            this.lErrorPrecio.Visible = false;
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
            this.label6.Location = new System.Drawing.Point(336, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Categorias :";
            // 
            // labelCategoria
            // 
            this.labelCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCategoria.Location = new System.Drawing.Point(131, 122);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(172, 22);
            this.labelCategoria.TabIndex = 89;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(339, 190);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(116, 23);
            this.bModificar.TabIndex = 90;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Location = new System.Drawing.Point(70, 185);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(58, 23);
            this.bBorrar.TabIndex = 91;
            this.bBorrar.Text = "Borrar";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // FormAbmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 254);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.treeCategorias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lErrorPrecio);
            this.Controls.Add(this.lErrorCategoria);
            this.Controls.Add(this.lErrorDescripcion);
            this.Controls.Add(this.lErrorNombre);
            this.Controls.Add(this.lErrorCodigo);
            this.Controls.Add(this.bCrearOtro);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
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
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Label lErrorCodigo;
        private System.Windows.Forms.Label lErrorNombre;
        private System.Windows.Forms.Label lErrorDescripcion;
        private System.Windows.Forms.Label lErrorCategoria;
        private System.Windows.Forms.Label lErrorPrecio;
        private System.Windows.Forms.TreeView treeCategorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bBorrar;
    }
}