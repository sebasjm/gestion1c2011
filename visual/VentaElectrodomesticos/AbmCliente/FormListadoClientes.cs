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
namespace VentaElectrodomesticos.AbmCliente {
    public partial class FormListadoClientes : Form {
        private Object messageFromParent = null;
        public Object MessageFromParent {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }
        public bool clientesActivos = true;
        public FormListadoClientes() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            cmbProvincia.SelectedIndex = 0;
            dataClientes.DataSource = null;
        }
        private void bCancelar_Click(object sender, EventArgs e) {
            this.messageFromParent = null;
            this.Close();
        }
        private void bSeleccionar_Click(object sender, EventArgs e) {
            Cliente cliente = dataClientes.SelectedRows.Count == 0 ? null : (Cliente)dataClientes.SelectedRows[0].Cells[0].Value;
            if (cliente != null) {
                this.messageFromParent = cliente;
                this.Close();
            } else {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }
        private void bBuscar_Click(object sender, EventArgs e) {
            if (txtDni.Text.Length == 0)
                txtDni.Text = "0";
            clientesActivos = !chkEliminados.Checked;
            List<Cliente> result = Context.instance.dao.cliente.search(
                txtNombre.Text, 
                txtApellido.Text, 
                Convert.ToInt32(txtDni.Text),
                (Provincia)cmbProvincia.SelectedItem,
                clientesActivos
            );
            ViewHelper.fillDataGridClientes(dataClientes, result);
        }

    }
}
