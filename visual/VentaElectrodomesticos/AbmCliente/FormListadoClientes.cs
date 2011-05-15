using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Modelo;
namespace VentaElectrodomesticos.AbmCliente
{
    public partial class FormListadoClientes : Form
    {
        private Object messageFromParent = null;
        public Object MessageFromParent
        {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }
        public FormListadoClientes()
        {
            InitializeComponent();
            FillData();
            ViewHelper.fillComboProvincias(cmbProvincia);
        }
        void FillData()
        {
            List<Cliente> clientesList = Context.instance.dao.cliente.search(txtNombre.Text, txtApellido.Text, ((txtDni.Text == "") ? (Int32)0 :  System.Int32.Parse(txtDni.Text)) );
            try
            {
                dataClientes.DataSource = clientesList;
            }
            catch (NullReferenceException) { }
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            cmbProvincia.SelectedIndex = -1;
            dataClientes.DataSource = null;
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.messageFromParent = 0;
            this.Close();
        }
        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dataClientes.Rows[dataClientes.CurrentCell.RowIndex].DataBoundItem;
            if (cliente != null)
            {
                this.messageFromParent = cliente;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado");
            }
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FillData();
        }
  }
}
