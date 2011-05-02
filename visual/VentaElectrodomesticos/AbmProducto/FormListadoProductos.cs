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
    public partial class FormListadoProductos : Form
    {
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
        public FormListadoProductos()
        {
            InitializeComponent();
            fillTree();
        }
        private void FormListadoProductos_Load(object sender, EventArgs e)
        {
            List<Marca> marcasList = Context.instance.dao.marca.search("");
             
            foreach(Marca marca in marcasList ){
                namesCollection.Add(marca.nombre);
            };
            txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombre.AutoCompleteCustomSource = namesCollection;
        }
        private void fillTree() {
            List<Categoria> categoriasList = Context.instance.dao.categoria.search("");
            
            // loop through each subdirectory
            foreach (Categoria categoria in categoriasList)
            {
                // create a new node
                TreeNode t = new TreeNode(categoria.nombre);
                // populate the new node recursively
                PopulateTree(d.FullName, t);
                node.Nodes.Add(t); // add the node to the "master" node
            }
            // lastly, loop through each file in the directory, and add these as nodes
            /*foreach (FileInfo f in directory.GetFiles())
            {
                // create a new node
                TreeNode t = new TreeNode(f.Name);
                // add it to the "master"
                node.Nodes.Add(t);
            }*/
        }

    }
}
