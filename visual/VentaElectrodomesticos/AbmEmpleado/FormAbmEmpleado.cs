using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.AbmEmpleado {
    public partial class FormAbmEmpleado : Form {
        public FormAbmEmpleado() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia,true);
            ViewHelper.fillComboSucursales(cmbSucursal,true);
            ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado,true);
        }
       
        private void bBuscar_Click(object sender, EventArgs e) {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
                bCrearOtro.Hide();
                bCrear.Hide();
                bModificar.Show();
                bEliminar.Show();
            }
        }

        private void cargarEmpleado(Empleado cargoEmpleado) {
            txtApellido.Text = cargoEmpleado.apellido;
            txtNombre.Text = cargoEmpleado.nombre;
            txtDni.Text = cargoEmpleado.dni.ToString();
            txtMail.Text = cargoEmpleado.mail;
            txtTelefono.Text = cargoEmpleado.telefono;
            txtDireccion.Text = cargoEmpleado.direccion;
            cmbProvincia.SelectedValue = cargoEmpleado.sucursal.provinciaId;
            cmbSucursal.SelectedValue = cargoEmpleado.sucursalId;
            cmbTipoEmpleado.SelectedValue = cargoEmpleado.tipoEmpleadoId;
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbProvincia.SelectedValue = 0;
            cmbSucursal.SelectedValue = 0;
            cmbTipoEmpleado.SelectedValue = 0;
            bCrearOtro.Show();
            bCrear.Show();
            bModificar.Hide();
            bEliminar.Hide();
        }

        private void bCrear_Click(object sender, EventArgs e) {

        }
        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bModificar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Esta seguro que desea modificar al cliente?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la modificacion
            }
        }

        private void bEliminar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Esta seguro que desea eliminar al Empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con el borrado
            }
        }


    }
}
