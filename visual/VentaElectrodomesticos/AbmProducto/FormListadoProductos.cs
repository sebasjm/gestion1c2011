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
        public bool productosActivos = true;
        List<Categoria> items = new List<Categoria>();
        public FormListadoProductos() {
            InitializeComponent();
            buildtree();
            FillData();
            ViewHelper.fillComboMarcas(cmbMarcas);
        }
        private void buildtree() {
            this.items = Context.instance.dao.categoria.search(0, "");
            treeCategorias.Nodes.Clear();   
            treeCategorias.BeginUpdate();   
            LoadBaseNodes();           
            treeCategorias.EndUpdate();
            treeCategorias.Refresh();  
        }
        private void LoadBaseNodes() {
            int? baseParent = null;                 
            TreeNode node;
            foreach (Categoria cat in items) {
                if (cat.categoria_padre < baseParent)
                    baseParent = cat.categoria_padre;
            }
            foreach (Categoria cat in items)        
            {
                if (cat.categoria_padre == baseParent)
                {
                    node = treeCategorias.Nodes.Add(cat.nombre);
                    node.Tag = cat;                 
                    getChildren(node);              
                }
            }
        }
        private void getChildren(TreeNode node) {
            TreeNode Node = null;
            Categoria nodeCat = (Categoria)node.Tag; 
            foreach (Categoria cat in items)         
            {
                if (cat.categoria_padre == nodeCat.id)    
                {
                    Node = node.Nodes.Add(cat.nombre);    
                    Node.Tag = cat;                         
                    getChildren(Node);                      
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
            productosActivos = !chkEliminados.Checked;
            List<Producto> productosList = Context.instance.dao.producto.search(
                txtCodigoProducto.Text,
                txtNombre.Text,
                cmbMarcas.SelectedIndex,
                indice,
                precioDesde,
                precioHasta,
                productosActivos);
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
            dataProductos.Rows.Clear();
        }
        private void bSeleccionar_Click(object sender, EventArgs e) {
            Producto prod = dataProductos.SelectedRows.Count == 0 ? null : (Producto)dataProductos.SelectedRows[0].Cells[0].Value;
            if (prod != null) {
                this.messageFromParent = prod;
                this.Close();
            } else {
                MessageBox.Show("Debe seleccionar un Producto");
            }
        }
    }
}
