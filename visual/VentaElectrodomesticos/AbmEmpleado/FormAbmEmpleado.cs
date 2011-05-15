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
using VentaElectrodomesticos.Vista;
namespace VentaElectrodomesticos.AbmEmpleado {
    public partial class FormAbmEmpleado : Form {
        private Empleado empleado;
        private Validator validator;
        public FormAbmEmpleado() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia, false);
            ViewHelper.fillComboSucursales(cmbSucursal, false);
            ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado, false);

            validator = new Validator()
                .add(txtNombre, lErrorNombre, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtApellido, lErrorApellido, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtDni, lErrorDNI, Validator.Text.obligatorio, Validator.Text.numerico)
                .add(txtDireccion, lErrorDireccion, Validator.Text.obligatorio)
                .add(txtMail, lErrorMail, Validator.Text.obligatorio, Validator.Text.mail)
                .add(txtTelefono, lErrorTelefono, Validator.Text.obligatorio, Validator.Text.telefono)
                .add(cmbProvincia, lErrorProvincia, Validator.Combo.obligatorio)
                .add(cmbSucursal, lErrorSucursal, Validator.Combo.obligatorio)
                .add(cmbTipoEmpleado, lErrorTipoEmpleado, Validator.Combo.obligatorio)
                ;
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
                bBorrar.Show();
            }
        }
        private void cargarEmpleado(Empleado cargoEmpleado) {
            this.limpiar();
            this.empleado = cargoEmpleado;
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
            this.limpiar();
        }
        private void limpiar() {
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
            bBorrar.Hide();
        }
        private void bCrear_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear el Empleado?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la creacion
                Empleado empleadoNew = new Empleado(Int32.Parse(txtDni.Text));
                empleadoNew.apellido = txtApellido.Text;
                empleadoNew.nombre = txtNombre.Text;
                empleadoNew.mail = txtMail.Text;
                empleadoNew.telefono = txtTelefono.Text;
                empleadoNew.direccion = txtDireccion.Text;
                empleadoNew.sucursalId = (Byte)cmbSucursal.SelectedValue;
                empleadoNew.tipoEmpleadoId = (Byte)cmbTipoEmpleado.SelectedValue;
                Context.instance.dao.empleado.insertar(empleadoNew);
                this.Close();
            }
        }
        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void bModificar_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea modificar al cliente?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la modificacion
                this.empleado.apellido = txtApellido.Text;
                this.empleado.nombre = txtNombre.Text;
                this.empleado.mail = txtMail.Text;
                this.empleado.telefono = txtTelefono.Text;
                this.empleado.direccion = txtDireccion.Text;
                this.empleado.sucursalId = (Byte)cmbSucursal.SelectedValue;
                this.empleado.tipoEmpleadoId = (Byte)cmbTipoEmpleado.SelectedValue;
                Context.instance.dao.empleado.modificar(this.empleado);
                this.Close();
            }
        }
        private void bBorrar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Esta seguro que desea eliminar al Empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con el borrado
                Context.instance.dao.empleado.delete(empleado);
                this.Close();
            }
        }

        private void bCrearOtro_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear el Empleado?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la creacion
                Empleado empleadoNew = new Empleado(Int32.Parse(txtDni.Text));
                empleadoNew.apellido = txtApellido.Text;
                empleadoNew.nombre = txtNombre.Text;
                empleadoNew.mail = txtMail.Text;
                empleadoNew.telefono = txtTelefono.Text;
                empleadoNew.direccion = txtDireccion.Text;
                empleadoNew.sucursalId = (Byte)cmbSucursal.SelectedValue;
                empleadoNew.tipoEmpleadoId = (Byte)cmbTipoEmpleado.SelectedValue;
                Context.instance.dao.empleado.insertar(empleadoNew);
                this.limpiar();
            }
        }
    }
}
