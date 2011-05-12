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
namespace VentaElectrodomesticos.AbmCliente {
    public partial class FormAbmCliente : Form     {
        public FormAbmCliente() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia, true);
            bModificar.Visible = false;
            bBorrar.Visible = false;
            lErrorNombre.Visible = false;
            lErrorApellido.Visible = false;
            lErrorDNI.Visible = false;
            lErrorDireccion.Visible = false;
            lErrorMail.Visible = false;
            lErrorTelefono.Visible = false;
            lErrorProvincia.Visible = false;
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
                txtApellido.Text = cargoCliente.apellido;
                txtNombre.Text = cargoCliente.nombre;
                txtDni.Text = cargoCliente.dni.ToString();
                txtMail.Text = cargoCliente.mail;
                // Falta en el modelo agregar los campos que faltan. cmbProvincia.SelectedValue =cargoCliente.pr
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtMail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbProvincia.SelectedIndex = 0;
        }
        private void bCrear_Click(object sender, EventArgs e) {
            this.validadCampos();
                if (MessageBox.Show("¿Esta seguro que desea crear al cliente?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    // proceder con la creacion
                }
        }
        private void validadCampos() {
            // TODO : Ver como cargar el objeto empleado
            ValidarHelper validador = new ValidarHelper();
            validador.validarCampo(txtNombre, lErrorNombre, "Nombre");
            validador.validarCampo(txtApellido, lErrorApellido, "Apellido");
            validador.validarCampo(txtDni, lErrorDNI, "DNI");
            validador.validarCampo(txtDireccion, lErrorDireccion, "Dirección");
            validador.validarCampo(txtMail, lErrorMail, "Mail");
            validador.validarCampo(txtTelefono, lErrorTelefono, "Teléfono");
            validador.validarCampo(cmbProvincia, lErrorProvincia, "Provincia");
        }
        private void bModificar_Click(object sender, EventArgs e)        {
            this.validadCampos();
            if (MessageBox.Show("¿Esta seguro que desea modificar al cliente?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)            {
                // proceder con la modificacion
            }
        }
        private void bBorrar_Click(object sender, EventArgs e)        {
            if (MessageBox.Show("¿Esta seguro que desea borrar al cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)            {
                // proceder con la eliminacion
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)        {
            this.Close();
        }
        private void bCrearOtro_Click(object sender, EventArgs e)        {
            this.validadCampos();
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Cliente?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el Guardado y la Creacion de otro
            }
        }
     }
}
