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

namespace VentaElectrodomesticos.AbmEmpleado {
    public partial class FormListadoEmpleados : Form {
        private Object messageFromParent = null;
        public Object MessageFromParent {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }

        public FormListadoEmpleados() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
            ViewHelper.fillComboSucursales(cmbSucursal);
            ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado);
        }

        public FormListadoEmpleados(String modo)
        {
            if (modo == "Analista") {
                InitializeComponent();
                ViewHelper.fillComboProvincias(cmbProvincia);
                ViewHelper.fillComboSucursales(cmbSucursal);
                ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado);
                cmbTipoEmpleado.SelectedIndex = 1;
                cmbTipoEmpleado.Enabled = false;
            } else { 
            
            }
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.messageFromParent = null;
            this.Close();
        }
        private void bBuscar_Click(object sender, EventArgs e) {
            if (txtDni.Text.Length == 0)
                txtDni.Text = "0";
            List<Empleado> result = Context.instance.dao.empleado.search(
                txtNombre.Text,
                txtApellido.Text,
                Convert.ToInt32(txtDni.Text),
                (Sucursal)cmbSucursal.SelectedItem,
                (TipoEmpleado)cmbTipoEmpleado.SelectedItem
            );
            ViewHelper.fillDataGridEmpleados(dataEmpleados, result);
        }
        private void bSeleccionar_Click(object sender, EventArgs e) {
            Empleado empleado = (Empleado)dataEmpleados.SelectedRows[0].Cells[0].Value;
            if (empleado != null) {
                this.messageFromParent = empleado;
                this.Close();
            } else {
                MessageBox.Show("Debe seleccionar un empleado");
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            cmbProvincia.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            cmbTipoEmpleado.SelectedIndex = 0;
            dataEmpleados.Rows.Clear();
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            Sucursal item = (Sucursal)cmbSucursal.SelectedItem;
            cmbProvincia.SelectedItem = item != null ? item.provincia : null;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            Provincia item = (Provincia)cmbProvincia.SelectedItem;
            cmbSucursal.SelectedItem = item != null ? item.sucursal : null;
        }

    }
}
