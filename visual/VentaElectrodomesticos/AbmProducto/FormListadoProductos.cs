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
            FillData();
            ViewHelper.fillComboMarcas(cmbMarcas);
            this.items = Context.instance.dao.categoria.load();
            ViewHelper.fillTreeViewCategorias(treeCategorias, items);
        }
        public FormListadoProductos(String modo) {
            InitializeComponent();
            FillData();
            ViewHelper.fillComboMarcas(cmbMarcas);
            this.items = Context.instance.dao.categoria.load();
            ViewHelper.fillTreeViewCategorias(treeCategorias, items);
            chkEliminados.Enabled = false;
        }
        void FillData() {
            float precioDesde = 0;
            float precioHasta = 0;
            try { precioDesde = float.Parse(txtPrecioDesde.Text); } catch (FormatException) { txtPrecioDesde.Text = "0"; };
            try { precioHasta = float.Parse(txtPrecioHasta.Text); } catch (FormatException) { txtPrecioHasta.Text = "0"; };
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
            chkEliminados.Checked = false;
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
