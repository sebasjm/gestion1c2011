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
using VentaElectrodomesticos.Exception;
using System.Text.RegularExpressions;
using VentaElectrodomesticos.Vista;

namespace VentaElectrodomesticos.AbmCliente {
    public partial class FormAbmCliente : Form {
        Cliente cliente;
        Validator validator;
        public FormAbmCliente() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
            validator = new Validator()
                .add(txtNombre, lErrorNombre, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtApellido, lErrorApellido, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtDni, lErrorDNI, Validator.Text.obligatorio, Validator.Text.numerico)
                .add(txtMail, lErrorMail, Validator.Text.obligatorio, Validator.Text.mail)
                .add(txtDireccion, lErrorDireccion, Validator.Text.obligatorio)
                .add(txtTelefono, lErrorTelefono, Validator.Text.obligatorio, Validator.Text.telefono)
                .add(cmbProvincia, lErrorProvincia, Validator.Combo.obligatorio);
        }
        private void bBuscar_Click(object sender, EventArgs e) {
            FormListadoClientes form = new FormListadoClientes();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarCliente((Cliente)form.MessageFromParent);
                bCrearOtro.Hide();
                bCrear.Hide();
                if (form.clientesActivos)
                {
                    bModificar.Show();
                    bBorrar.Show();
                }
                else
                {
                    bBorrar.Show();
                    bBorrar.Text = "Habilitar";
                    txtApellido.Enabled = false;
                    txtNombre.Enabled = false;
                    txtMail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    cmbProvincia.Enabled = false;
                }
                txtDni.Enabled = false;
            }
        }
        private void cargarCliente(Cliente cargoCliente) {
            this.limpiar();
            this.cliente = cargoCliente;
            txtApellido.Text = cargoCliente.apellido;
            txtNombre.Text = cargoCliente.nombre;
            txtDni.Text = cargoCliente.dni.ToString();
            txtMail.Text = cargoCliente.mail;
            txtDireccion.Text = cargoCliente.direccion;
            txtTelefono.Text = cargoCliente.telefono;
            cmbProvincia.SelectedValue = cargoCliente.provinciaId;
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
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbProvincia.SelectedIndex = 0;
            txtDni.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtMail.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            cmbProvincia.Enabled = true;
            bCrearOtro.Show();
            bCrear.Show();
            bModificar.Hide();
            bBorrar.Hide();
            bBorrar.Text = "Borrar";
        }
        private void bCrear_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea crear al cliente?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la creacion
                Cliente clienteNew = new Cliente(Int32.Parse(txtDni.Text));
                clienteNew.apellido = txtApellido.Text;
                clienteNew.nombre = txtNombre.Text;
                clienteNew.mail = txtMail.Text;
                clienteNew.telefono = txtTelefono.Text;
                clienteNew.direccion = txtDireccion.Text;
                clienteNew.provinciaId = (Byte)cmbProvincia.SelectedValue;
                Context.instance.dao.cliente.insertar(clienteNew);
            }
        }
        private void bModificar_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea modificar al cliente?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la modificacion
                this.cliente.apellido = txtApellido.Text;
                this.cliente.nombre = txtNombre.Text;
                this.cliente.mail = txtMail.Text;
                this.cliente.telefono = txtTelefono.Text;
                this.cliente.direccion = txtDireccion.Text;
                this.cliente.provinciaId = (Byte)cmbProvincia.SelectedValue;
                Context.instance.dao.cliente.modificar(this.cliente);
                this.Close();
            }
        }
        private void bBorrar_Click(object sender, EventArgs e) {
            if ("Habilitar".Equals(bBorrar.Text))
            {
                if (MessageBox.Show("¿Esta seguro que desea habilitar al Cliente?", "Confirmar Habilitación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la habilitación
                    Context.instance.dao.cliente.habilitar(cliente.dni);
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al Cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la eliminación
                    Context.instance.dao.cliente.eliminar(cliente.dni);
                    this.Close();
                }
            }
        }
        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void bCrearOtro_Click(object sender, EventArgs e) {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Cliente?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con el Guardado y la Creacion de otro
                Cliente clienteNew = new Cliente(Int32.Parse(txtDni.Text));
                clienteNew.apellido = txtApellido.Text;
                clienteNew.nombre = txtNombre.Text;
                clienteNew.mail = txtMail.Text;
                clienteNew.telefono = txtTelefono.Text;
                clienteNew.direccion = txtDireccion.Text;
                clienteNew.provinciaId = (Byte)cmbProvincia.SelectedValue;
                Context.instance.dao.cliente.insertar(clienteNew);
                this.limpiar();
            }
        }

        private void FormAbmCliente_Load(object sender, EventArgs e) {
            if (!Context.instance.security.hasPermissionTo(Security.FUNCIONALIDAD_ABM_CLIENTE)) {
                MessageBox.Show("No tiene permisos suficiente para esta funcionalidad");
                this.Close();
                return;
            };

        }
    }
}
