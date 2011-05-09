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
        private string nombre;
        private string apellido;
        private int dni = -1;
        public FormListadoClientes()
        {
            InitializeComponent();
            FillData();
            ViewHelper.fillComboProvincias(cmbProvincia, true);
        }
        void FillData()
        {
            List<Cliente> clientesList = Context.instance.dao.cliente.search(this.nombre, this.apellido, this.dni);
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
            this.nombre = txtNombre.Text;
            this.apellido = txtApellido.Text;
            if (txtDni.Text == "") { this.dni = 0; }
            else {
            this.dni = System.Int32.Parse(txtDni.Text);}
            FillData();
        }
  }
}
