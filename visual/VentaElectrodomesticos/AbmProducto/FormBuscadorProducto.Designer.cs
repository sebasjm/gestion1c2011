namespace VentaElectrodomesticos.AbmProducto
{
    partial class FormBuscadorProducto
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bebidas");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Comidas");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Productos", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lNombreMarca = new System.Windows.Forms.Label();
            this.lCodProd = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.treeCategorias = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.lPrecio = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lHasta = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(23, 247);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 71;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(185, 247);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 70;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Location = new System.Drawing.Point(20, 70);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(52, 13);
            this.lCategoria.TabIndex = 67;
            this.lCategoria.Text = "Categoria";
            // 
            // lNombreMarca
            // 
            this.lNombreMarca.AutoSize = true;
            this.lNombreMarca.Location = new System.Drawing.Point(20, 42);
            this.lNombreMarca.Name = "lNombreMarca";
            this.lNombreMarca.Size = new System.Drawing.Size(86, 13);
            this.lNombreMarca.TabIndex = 63;
            this.lNombreMarca.Text = "Nombre o Marca";
            // 
            // lCodProd
            // 
            this.lCodProd.AutoSize = true;
            this.lCodProd.Location = new System.Drawing.Point(20, 15);
            this.lCodProd.Name = "lCodProd";
            this.lCodProd.Size = new System.Drawing.Size(100, 13);
            this.lCodProd.TabIndex = 62;
            this.lCodProd.Text = "Código de producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 61;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(139, 12);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoProducto.TabIndex = 60;
            // 
            // treeCategorias
            // 
            this.treeCategorias.Location = new System.Drawing.Point(139, 70);
            this.treeCategorias.Name = "treeCategorias";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Bebidas";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Comidas";
            treeNode3.Name = "Nodo0";
            treeNode3.Text = "Productos";
            this.treeCategorias.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeCategorias.Size = new System.Drawing.Size(121, 97);
            this.treeCategorias.TabIndex = 72;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(23, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 73;
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
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(105, 247);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 74;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(23, 176);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 13);
            this.lPrecio.TabIndex = 75;
            this.lPrecio.Text = "Precio:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(139, 176);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(121, 20);
            this.txtDesde.TabIndex = 76;
            // 
            // lHasta
            // 
            this.lHasta.AutoSize = true;
            this.lHasta.Location = new System.Drawing.Point(95, 212);
            this.lHasta.Name = "lHasta";
            this.lHasta.Size = new System.Drawing.Size(38, 13);
            this.lHasta.TabIndex = 77;
            this.lHasta.Text = "Hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(139, 209);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(121, 20);
            this.txtHasta.TabIndex = 78;
            // 
            // lDesde
            // 
            this.lDesde.AutoSize = true;
            this.lDesde.Location = new System.Drawing.Point(95, 179);
            this.lDesde.Name = "lDesde";
            this.lDesde.Size = new System.Drawing.Size(41, 13);
            this.lDesde.TabIndex = 79;
            this.lDesde.Text = "Desde:";
            // 
            // FormBuscadorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 448);
            this.Controls.Add(this.lDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.lHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeCategorias);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.lCategoria);
            this.Controls.Add(this.lNombreMarca);
            this.Controls.Add(this.lCodProd);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoProducto);
            this.Name = "FormBuscadorProducto";
            this.Text = "Buscador de Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Label lNombreMarca;
        private System.Windows.Forms.Label lCodProd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TreeView treeCategorias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lHasta;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lDesde;
    }
}