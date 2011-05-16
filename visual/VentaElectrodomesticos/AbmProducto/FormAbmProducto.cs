using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Vista;
namespace VentaElectrodomesticos.AbmProducto
{
    public partial class FormAbmProducto : Form
    {
        List<Categoria> items = new List<Categoria>();
        Validator validator;
        Categoria categoria = null;
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        Producto producto;
        public FormAbmProducto()        {
            InitializeComponent();
            buildtree();
            bBorrar.Visible = false;
            bModificar.Visible = false;
            validator = new Validator()
                .add(txtCodigoProducto, lErrorCodigo, Validator.vacio, Validator.numerico)
                .add(txtDescripcion, lErrorDescripcion, Validator.vacio, Validator.nombre)
                .add(txtNombre, lErrorNombre, Validator.vacio, Validator.nombre)
                .add(this.categoria, lErrorCategoria, Validator.categoria)
                .add(txtPrecio, lErrorPrecio, Validator.vacio, Validator.numerico);
            List<Marca> marcasList = Context.instance.dao.marca.search("");
            foreach (Marca marca in marcasList)
            {
                namesCollection.Add(marca.nombre);
            };
            txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombre.AutoCompleteCustomSource = namesCollection;
        }
        private void buildtree()        {
            this.items = Context.instance.dao.categoria.search(0 , "");
            treeCategorias.Nodes.Clear();    // Clear any existing items
            treeCategorias.BeginUpdate();    // prevent overhead and flicker
            LoadBaseNodes();            // load all the lowest tree nodes
            treeCategorias.EndUpdate();      // re-enable the tree
            treeCategorias.Refresh();        // refresh the <strong class="highlight">treeview</strong> display
        }
        private void LoadBaseNodes()        {
            int? baseParent = null;                 // Find the lowest root category parent value
            TreeNode node;
            foreach (Categoria cat in items)
            {
                if (cat.categoria_padre < baseParent)
                    baseParent = cat.categoria_padre;
            }
            foreach (Categoria cat in items)         // iterate through the categories
            {
                if (cat.categoria_padre == baseParent)     // found a matching root item
                {
                    node = treeCategorias.Nodes.Add(cat.nombre); // add it to the tree
                    node.Tag = cat;                 // send the category into the tag for future processing
                    getChildren(node);              // load all the children of this node
                }
            }
        }
        // recursive tree loader. Passes back in a node to retireve its childre
        // until there are no more children for this node.
        private void getChildren(TreeNode node)        {
            TreeNode Node = null;
            Categoria nodeCat = (Categoria)node.Tag;  // get the category for this node
            foreach (Categoria cat in items)         // locate all children of this category
            {
                if (cat.categoria_padre == nodeCat.id)     // found a child
                {
                    Node = node.Nodes.Add(cat.nombre);    // add the child
                    Node.Tag = cat;                         // set its tag to its category
                    getChildren(Node);                      // find this child's children
                }
            }
        }
        private void bBuscar_Click(object sender, EventArgs e)        {
            FormListadoProductos form = new FormListadoProductos();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarProducto((Producto)form.MessageFromParent);
                bCrearOtro.Hide();
                bBorrar.Visible = true;
                bModificar.Visible = true;
                bCrear.Visible = false;
                bLimpiar.Visible = false;
            }
        }
        private void cargarProducto(Producto prod) {
            this.limpiar();
            this.producto = prod;
            txtCodigoProducto.Text = "" + prod.codigo;
            txtDescripcion.Text = prod.descripcion;
            txtNombre.Text = prod.nombre;
            txtPrecio.Text = "" + prod.precio;
            List<Categoria> cate = Context.instance.dao.categoria.search( prod.categoria_id , "");
            labelCategoria.Text = cate[0].nombre ;
        }
        private void treeCategorias_AfterSelect(object sender, TreeViewEventArgs e)        {
            TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
            if (NodoSeleccionado != null)
            {
                this.categoria = (Categoria)NodoSeleccionado.Tag;
                labelCategoria.Text = categoria.nombre;
            }
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea modificar el Producto?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la modificacion
                TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
                Categoria cate = null;
                if (NodoSeleccionado != null)
                {
                    cate = (Categoria)NodoSeleccionado.Tag;
                }
                Marca marca = Context.instance.dao.marca.findByNombre(txtNombre.Text);
                this.producto.nombre = txtNombre.Text;
                this.producto.marca_id = (marca == null ) ? (short)0 : (short)marca.id;
                this.producto.descripcion = txtDescripcion.Text;
                this.producto.categoria_id = (cate == null) ? this.producto.categoria_id : cate.id;
                this.producto.precio = Double.Parse(txtPrecio.Text);
                Context.instance.dao.producto.modificar(this.producto);
                this.Close();
            }
        }
        private void bBorrar_Click(object sender, EventArgs e)        {
            if (MessageBox.Show("¿Esta seguro que desea borrar el Producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la eliminacion
                Context.instance.dao.producto.delete(this.producto);
                this.Close();
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)        {
            this.Close();
        }
        private void bCrear_Click(object sender, EventArgs e)        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear el Producto?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la creacion
                Producto productoNew = new Producto(Int32.Parse(txtCodigoProducto.Text));
                TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
                Categoria cate = null;
                if (NodoSeleccionado != null)
                {
                    cate = (Categoria)NodoSeleccionado.Tag;
                }
                Marca marca = Context.instance.dao.marca.findByNombre(txtNombre.Text);
                productoNew.nombre = txtNombre.Text;
                productoNew.descripcion = txtDescripcion.Text;
                productoNew.categoria_id = cate.id;
                productoNew.marca_id = (short)marca.id;
                productoNew.precio = Double.Parse(txtPrecio.Text);
                Context.instance.dao.producto.insertar(productoNew);
                this.Close();
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e)        {
            this.limpiar();
        }
        private void limpiar() {
            txtCodigoProducto.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            labelCategoria.Text = "";
            txtPrecio.Text = "";
            treeCategorias.CollapseAll();
        }
        private void bCrearOtro_Click(object sender, EventArgs e)        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Producto?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el Guardado y la Creacion de otro
                Producto productoNew = new Producto(Int32.Parse(txtCodigoProducto.Text));
                TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
                Categoria cate = null;
                if (NodoSeleccionado != null)
                {
                    cate = (Categoria)NodoSeleccionado.Tag;
                }
                Marca marca = Context.instance.dao.marca.findByNombre(txtNombre.Text);
                productoNew.nombre = txtNombre.Text;
                productoNew.descripcion = txtDescripcion.Text;
                productoNew.categoria_id = cate.id;
                productoNew.marca_id = (short)marca.id;
                productoNew.precio = Double.Parse(txtPrecio.Text);
                Context.instance.dao.producto.insertar(productoNew);
                this.limpiar();
            }
        }
    }
}
