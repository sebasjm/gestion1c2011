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

namespace VentaElectrodomesticos.AbmProducto {

    public partial class FormListadoProductos : Form {
        private Object messageFromParent = null;
        public Object MessageFromParent {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }

        List<Categoria> items = new List<Categoria>();
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        public FormListadoProductos() {
            InitializeComponent();
            buildtree();
            FillData();
        }
        private void FormListadoProductos_Load(object sender, EventArgs e) {
            List<Marca> marcasList = Context.instance.dao.marca.search("");
            foreach (Marca marca in marcasList) {
                namesCollection.Add(marca.nombre);
            };
            txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombre.AutoCompleteCustomSource = namesCollection;
        }
        private void buildtree() {
            this.items = Context.instance.dao.categoria.search(0, "");
            treeCategorias.Nodes.Clear();    // Clear any existing items
            treeCategorias.BeginUpdate();    // prevent overhead and flicker
            LoadBaseNodes();            // load all the lowest tree nodes
            treeCategorias.EndUpdate();      // re-enable the tree
            treeCategorias.Refresh();        // refresh the <strong class="highlight">treeview</strong> display
        }
        private void LoadBaseNodes() {
            int? baseParent = null;                 // Find the lowest root category parent value
            TreeNode node;
            foreach (Categoria cat in items) {
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
        private void getChildren(TreeNode node) {
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
        void FillData() {
            float precioDesde = (txtPrecioDesde.Text == "") ? 0 : float.Parse(txtPrecioDesde.Text);
            float precioHasta = (txtPrecioHasta.Text == "") ? 0 : float.Parse(txtPrecioHasta.Text);
            TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
            int indice = 0;
            if (NodoSeleccionado == null) {
                indice = 0;
            } else {
                Categoria cate = (Categoria)NodoSeleccionado.Tag;
                indice = cate.id;
            }
            List<Marca> valor = (txtNombre.Text != "") ? Context.instance.dao.marca.search(txtNombre.Text) : null;
            String nombre = "";
            int marca = 0;
            if (valor == null) {
                nombre = txtNombre.Text;
                marca = 0;
            } else {
                nombre = "";
                if (valor.Count > 1) { MessageBox.Show("Debe Elegir una marca ", "Selección de Marca"); }
                marca = (valor[0].id != null) ? 0 : (int)valor[0].id;
            }

            List<Producto> productosList = Context.instance.dao.producto.search(
                txtCodigoProducto.Text,
                nombre,
                marca,
                indice,
                precioDesde,
                precioHasta);

            ViewHelper.fillDataGridProductos(dataProductos, productosList);
        }
        private void bBuscar_Click(object sender, EventArgs e) {
            FillData();
        }
        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            txtCodigoProducto.Text = "";
            txtNombre.Text = "";
            txtPrecioDesde.Text = "";
            txtPrecioHasta.Text = "";
            treeCategorias.CollapseAll();
            dataProductos.DataSource = null;
        }
        private void bSeleccionar_Click(object sender, EventArgs e) {
            Producto prod = (Producto)dataProductos.Rows[dataProductos.CurrentCell.RowIndex].DataBoundItem;
            if (prod != null) {
                this.messageFromParent = prod;
                this.Close();
            } else {
                MessageBox.Show("Debe seleccionar un Producto");
            }
        }
    }
}
