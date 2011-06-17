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
        Sucursal sucursal = null;
        public bool empleadosActivos = true;

        public Object MessageFromParent {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }

        public FormListadoEmpleados() {
            InitializeComponent();
            ViewHelper.fillComboSucursales(cmbSucursal);
            ViewHelper.fillComboProvincias(cmbProvincia);
            
            ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado);
        }

        bool conFiltroUsuario = false;
        bool conUsuario = false;
        public FormListadoEmpleados(String modo)
        {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
            ViewHelper.fillComboSucursales(cmbSucursal);
            ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado);
            chkEliminados.Enabled = false;
            if (modo == "Analista") {
                cmbTipoEmpleado.SelectedIndex = 1;
                cmbTipoEmpleado.Enabled = false;
            }
            if (modo == "SinUsuario") {
                conFiltroUsuario = true;
                conUsuario = false;
            }
            if (modo == "ConUsuario") {
                conFiltroUsuario = true;
                conUsuario = true;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.messageFromParent = null;
            this.Close();
        }
        private void bBuscar_Click(object sender, EventArgs e) {
            if (txtDni.Text.Length == 0)
                txtDni.Text = "0";
            empleadosActivos = !chkEliminados.Checked;
            List<Empleado> result = null;
            if (conFiltroUsuario) {
                result = Context.instance.dao.empleado.search(
                    txtNombre.Text,
                    txtApellido.Text,
                    Convert.ToInt32(txtDni.Text),
                    sucursal,
                    (TipoEmpleado)cmbTipoEmpleado.SelectedItem,
                    empleadosActivos,
                    conUsuario
                );
            } else {
                result = Context.instance.dao.empleado.search(
                    txtNombre.Text,
                    txtApellido.Text,
                    Convert.ToInt32(txtDni.Text),
                    sucursal,
                    (TipoEmpleado)cmbTipoEmpleado.SelectedItem,
                    empleadosActivos
                );
            }
            ViewHelper.fillDataGridEmpleados(dataEmpleados, result);
        }
        private void bSeleccionar_Click(object sender, EventArgs e) {
            Empleado empleado = dataEmpleados.SelectedRows.Count == 0 ? null : (Empleado)dataEmpleados.SelectedRows[0].Cells[0].Value;
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
            chkEliminados.Checked = false;
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            sucursal = (Sucursal)cmbSucursal.SelectedItem;
            cmbProvincia.SelectedItem = sucursal != null ? sucursal.provincia : null;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            Provincia item = (Provincia)cmbProvincia.SelectedItem;
            cmbSucursal.SelectedItem = item != null ? item.sucursal : null;
        }
    }
}
