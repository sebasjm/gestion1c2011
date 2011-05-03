namespace VentaElectrodomesticos.AbmProducto
{
    partial class FormListadoProductos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bBuscar = new System.Windows.Forms.Button();
            this.grpFiltroBusqueda = new System.Windows.Forms.GroupBox();
            this.grpPrecios = new System.Windows.Forms.GroupBox();
            this.lHasta = new System.Windows.Forms.Label();
            this.lDesde = new System.Windows.Forms.Label();
            this.txtPrecioHasta = new System.Windows.Forms.TextBox();
            this.txtPrecioDesde = new System.Windows.Forms.TextBox();
            this.treeCategorias = new System.Windows.Forms.TreeView();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lNombreMarca = new System.Windows.Forms.Label();
            this.lCodProd = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.grpFiltroBusqueda.SuspendLayout();
            this.grpPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(359, 211);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 71;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // grpFiltroBusqueda
            // 
            this.grpFiltroBusqueda.Controls.Add(this.grpPrecios);
            this.grpFiltroBusqueda.Controls.Add(this.treeCategorias);
            this.grpFiltroBusqueda.Controls.Add(this.lCategoria);
            this.grpFiltroBusqueda.Controls.Add(this.lNombreMarca);
            this.grpFiltroBusqueda.Controls.Add(this.lCodProd);
            this.grpFiltroBusqueda.Controls.Add(this.txtNombre);
            this.grpFiltroBusqueda.Controls.Add(this.txtCodigoProducto);
            this.grpFiltroBusqueda.Location = new System.Drawing.Point(13, 13);
            this.grpFiltroBusqueda.Name = "grpFiltroBusqueda";
            this.grpFiltroBusqueda.Size = new System.Drawing.Size(421, 192);
            this.grpFiltroBusqueda.TabIndex = 75;
            this.grpFiltroBusqueda.TabStop = false;
            this.grpFiltroBusqueda.Text = "Filtros de Búsqueda";
            // 
            // grpPrecios
            // 
            this.grpPrecios.Controls.Add(this.lHasta);
            this.grpPrecios.Controls.Add(this.lDesde);
            this.grpPrecios.Controls.Add(this.txtPrecioHasta);
            this.grpPrecios.Controls.Add(this.txtPrecioDesde);
            this.grpPrecios.Location = new System.Drawing.Point(14, 76);
            this.grpPrecios.Name = "grpPrecios";
            this.grpPrecios.Size = new System.Drawing.Size(243, 100);
            this.grpPrecios.TabIndex = 86;
            this.grpPrecios.TabStop = false;
            this.grpPrecios.Text = "Rango de Precios";
            // 
            // lHasta
            // 
            this.lHasta.AutoSize = true;
            this.lHasta.Location = new System.Drawing.Point(22, 57);
            this.lHasta.Name = "lHasta";
            this.lHasta.Size = new System.Drawing.Size(38, 13);
            this.lHasta.TabIndex = 82;
            this.lHasta.Text = "Hasta:";
            // 
            // lDesde
            // 
            this.lDesde.AutoSize = true;
            this.lDesde.Location = new System.Drawing.Point(22, 25);
            this.lDesde.Name = "lDesde";
            this.lDesde.Size = new System.Drawing.Size(41, 13);
            this.lDesde.TabIndex = 81;
            this.lDesde.Text = "Desde:";
            // 
            // txtPrecioHasta
            // 
            this.txtPrecioHasta.Location = new System.Drawing.Point(116, 54);
            this.txtPrecioHasta.Name = "txtPrecioHasta";
            this.txtPrecioHasta.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioHasta.TabIndex = 80;
            // 
            // txtPrecioDesde
            // 
            this.txtPrecioDesde.Location = new System.Drawing.Point(116, 25);
            this.txtPrecioDesde.Name = "txtPrecioDesde";
            this.txtPrecioDesde.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioDesde.TabIndex = 79;
            // 
            // treeCategorias
            // 
            this.treeCategorias.Location = new System.Drawing.Point(273, 49);
            this.treeCategorias.Name = "treeCategorias";
            this.treeCategorias.Size = new System.Drawing.Size(120, 127);
            this.treeCategorias.TabIndex = 85;
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(270, 22);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 84;
            this.lCategoria.Text = "Categoria";
            // 
            // lNombreMarca
            // 
            this.lNombreMarca.AutoSize = true;
            this.lNombreMarca.Location = new System.Drawing.Point(11, 52);
            this.lNombreMarca.Name = "lNombreMarca";
            this.lNombreMarca.Size = new System.Drawing.Size(86, 13);
            this.lNombreMarca.TabIndex = 83;
            this.lNombreMarca.Text = "Nombre o Marca";
            // 
            // lCodProd
            // 
            this.lCodProd.AutoSize = true;
            this.lCodProd.Location = new System.Drawing.Point(11, 25);
            this.lCodProd.Name = "lCodProd";
            this.lCodProd.Size = new System.Drawing.Size(100, 13);
            this.lCodProd.TabIndex = 82;
            this.lCodProd.Text = "Código de producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 81;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(130, 22);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoProducto.TabIndex = 80;
            // 
            // dataProductos
            // 
            this.dataProductos.AllowUserToOrderColumns = true;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Location = new System.Drawing.Point(13, 240);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.Size = new System.Drawing.Size(421, 165);
            this.dataProductos.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(12, 411);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 78;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(96, 411);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 77;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.dataProductos);
            this.Controls.Add(this.grpFiltroBusqueda);
            this.Controls.Add(this.bBuscar);
            this.Name = "FormListadoProductos";
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.FormListadoProductos_Load);
            this.grpFiltroBusqueda.ResumeLayout(false);
            this.grpFiltroBusqueda.PerformLayout();
            this.grpPrecios.ResumeLayout(false);
            this.grpPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.GroupBox grpFiltroBusqueda;
        private System.Windows.Forms.GroupBox grpPrecios;
        private System.Windows.Forms.Label lHasta;
        private System.Windows.Forms.Label lDesde;
        private System.Windows.Forms.TextBox txtPrecioHasta;
        private System.Windows.Forms.TextBox txtPrecioDesde;
        private System.Windows.Forms.TreeView treeCategorias;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lNombreMarca;
        private System.Windows.Forms.Label lCodProd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;

    }
}