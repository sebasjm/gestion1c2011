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
        Sucursal sucursal = null;
        Validator validator;
        public FormAbmEmpleado() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
            ViewHelper.fillComboSucursales(cmbSucursal);
            ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado);
            bModificar.Hide();
            bBorrar.Hide();
            validator = new Validator()
                .add(txtNombre, lErrorNombre, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtApellido, lErrorApellido, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtDni, lErrorDNI, Validator.Text.obligatorio, Validator.Text.numerico)
                .add(txtMail, lErrorMail, Validator.Text.obligatorio, Validator.Text.mail)
                .add(txtDireccion, lErrorDireccion, Validator.Text.obligatorio)
                .add(txtTelefono, lErrorTelefono, Validator.Text.obligatorio, Validator.Text.telefono)
                .add(cmbProvincia, lErrorProvincia, Validator.Combo.obligatorio)
                .add(cmbSucursal, lErrorSucursal, Validator.Combo.obligatorio)
                .add(cmbTipoEmpleado, lErrorTipoEmpleado, Validator.Combo.obligatorio);
        }
        private void bBuscar_Click(object sender, EventArgs e) {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
                bCrearOtro.Hide();
                bCrear.Hide();
                if (form.empleadosActivos) {
                    bModificar.Show();
                    bBorrar.Show();
                } else {
                    bBorrar.Show();
                    bBorrar.Text = "Habilitar";
                    txtApellido.Enabled = false;
                    txtNombre.Enabled = false;
                    txtMail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    cmbProvincia.Enabled = false;
                    cmbSucursal.Enabled = false;
                    cmbTipoEmpleado.Enabled = false;
                }
                txtDni.Enabled = false;
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
            cmbProvincia.SelectedValue = cargoEmpleado.sucursal.provinciaId ;
            cmbSucursal.SelectedValue = cargoEmpleado.sucursalId ;
            cmbTipoEmpleado.SelectedValue = cargoEmpleado.tipoEmpleadoId ;
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            this.limpiar();
            bCrear.Visible = true;
            bCrearOtro.Visible = true;
            bModificar.Visible = false;
            bBorrar.Visible = false;
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
            sucursal = null;
            txtDni.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtMail.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            cmbProvincia.Enabled = true;
            cmbSucursal.Enabled = true;
            cmbTipoEmpleado.Enabled = true;
            bCrearOtro.Show();
            bCrear.Show();
            bModificar.Hide();
            bBorrar.Hide();
            bBorrar.Text = "Borrar";
        }
        private void bCrear_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            int dni = Int32.Parse(txtDni.Text);
            if (Context.instance.dao.empleado.findByDni(dni) != null) {
                MessageBox.Show("No se puede crear el empleado porque existe un empleado con el mismo dni", "Error");
                return;
            }
            if (MessageBox.Show("¿Esta seguro que desea crear el Empleado?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la creacion
                Empleado empleadoNew = new Empleado(dni);
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
            if (MessageBox.Show("¿Esta seguro que desea modificar el empleado?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la modificacion
                this.empleado.apellido = txtApellido.Text;
                this.empleado.nombre = txtNombre.Text;
                this.empleado.mail = txtMail.Text;
                this.empleado.telefono = txtTelefono.Text;
                this.empleado.direccion = txtDireccion.Text;
                this.empleado.sucursalId = (Byte)cmbSucursal.SelectedValue  ;
                this.empleado.tipoEmpleadoId = (Byte)cmbTipoEmpleado.SelectedValue;
                Context.instance.dao.empleado.modificar(this.empleado);
                this.Close();
            }
        }
        private void bBorrar_Click(object sender, EventArgs e)
        {
            if ("Habilitar".Equals(bBorrar.Text)) {
                if (MessageBox.Show("¿Esta seguro que desea habilitar al Empleado?", "Confirmar Habilitación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la habilitación
                    Context.instance.dao.empleado.habilitar(empleado.dni);
                }
            } else {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al Empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la eliminación
                    Context.instance.dao.empleado.eliminar(empleado.dni);
                }
            }
            this.Close();
        }
        private void bCrearOtro_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            int dni = Int32.Parse(txtDni.Text);
            if (Context.instance.dao.empleado.findByDni(dni) != null) {
                MessageBox.Show("No se puede crear el empleado porque existe un empleado con el mismo dni", "Error");
                return;
            }
            if (MessageBox.Show("¿Esta seguro que desea crear el Empleado?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con la creacion
                Empleado empleadoNew = new Empleado(dni);
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
        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            sucursal = (Sucursal)cmbSucursal.SelectedItem;
            cmbProvincia.SelectedItem = sucursal != null ? sucursal.provincia : null;
        }
        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            Provincia item = (Provincia)cmbProvincia.SelectedItem;
            cmbSucursal.SelectedItem = item != null ? item.sucursal : null;
        }

        private void FormAbmEmpleado_Load(object sender, EventArgs e) {
            if (!Context.instance.security.hasPermissionTo(Security.FUNCIONALIDAD_ABM_EMPLEADO)) {
                MessageBox.Show("No tiene permisos suficiente para esta funcionalidad");
                this.Close();
                return;
            };
        }
    }
}
