﻿using System;
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
                .add(txtNombre,    lErrorNombre,    Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtApellido,  lErrorApellido,  Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtDni,       lErrorDNI,       Validator.Text.obligatorio, Validator.Text.numerico)
                .add(txtMail,      lErrorMail,      Validator.Text.obligatorio, Validator.Text.mail)
                .add(txtDireccion, lErrorDireccion, Validator.Text.obligatorio)
                .add(txtTelefono,  lErrorTelefono,  Validator.Text.obligatorio, Validator.Text.telefono)
                .add(cmbProvincia, lErrorProvincia, Validator.Combo.obligatorio);

        }

        private void bBuscar_Click(object sender, EventArgs e) {
            FormListadoClientes form = new FormListadoClientes();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarCliente((Cliente)form.MessageFromParent);
                bCrearOtro.Visible = false;
                bLimpiar.Visible = false;
                bModificar.Visible = true;
                bBorrar.Visible = true;
            }
        }
        private void cargarCliente(Cliente cargoCliente) {
            this.limpiar();
            this.cliente = cargoCliente;
            txtApellido.Text = cargoCliente.apellido;
            txtNombre.Text = cargoCliente.nombre;
            txtTelefono.Text = cargoCliente.telefono;
            txtDireccion.Text = cargoCliente.direccion;
            txtDni.Text = cargoCliente.dni.ToString();
            txtMail.Text = cargoCliente.mail;
            cmbProvincia.SelectedValue = cargoCliente.provinciaId;
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            this.limpiar();
        }
        private void limpiar() {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbProvincia.SelectedIndex = 0;
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
            if (MessageBox.Show("¿Esta seguro que desea borrar al cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // proceder con la eliminacion
                Context.instance.dao.cliente.delete(this.cliente);
                this.Close();
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

    }
}
