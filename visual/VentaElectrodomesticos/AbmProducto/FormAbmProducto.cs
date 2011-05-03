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

namespace VentaElectrodomesticos.AbmProducto
{
    public partial class FormAbmProducto : Form
    {
        List<Categoria> items = new List<Categoria>();
        public FormAbmProducto()
        {
            InitializeComponent();
            buildtree();
        }
        private void buildtree()
        {
            this.items = Context.instance.dao.categoria.search(0 , "");
            treeCategorias.Nodes.Clear();    // Clear any existing items
            treeCategorias.BeginUpdate();    // prevent overhead and flicker
            LoadBaseNodes();            // load all the lowest tree nodes
            treeCategorias.EndUpdate();      // re-enable the tree
            treeCategorias.Refresh();        // refresh the <strong class="highlight">treeview</strong> display
        }
        private void LoadBaseNodes()
        {
            int baseParent = 0;                 // Find the lowest root category parent value
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
        private void getChildren(TreeNode node)
        {
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
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoProductos form = new FormListadoProductos();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarProducto((Producto)form.MessageFromParent);
                bCrearOtro.Hide();
                bLimpiar.Text = "Borrar";
                bCrear.Text = "Modificar";
            }
        }
        private void cargarProducto(Producto prod) {
            txtCodigoProducto.Text = "" + prod.codigo;
            txtDescripcion.Text = prod.descripcion;
            txtNombre.Text = prod.nombre;
            txtPrecio.Text = "" + prod.precio;
            List<Categoria> cate = Context.instance.dao.categoria.search( prod.categoria_id , "");
            txtCategoria.Text = cate[0].nombre;
        }

        private void treeCategorias_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode NodoSeleccionado = (TreeNode)treeCategorias.SelectedNode;
            if (NodoSeleccionado != null)
            {
                Categoria cate = (Categoria)NodoSeleccionado.Tag;
                txtCategoria.Text = cate.nombre;
            }
        }
    }
}
