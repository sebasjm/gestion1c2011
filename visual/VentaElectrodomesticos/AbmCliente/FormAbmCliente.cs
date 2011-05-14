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
namespace VentaElectrodomesticos.AbmCliente {
    public partial class FormAbmCliente : Form {
        Cliente cliente;
        Validator validator;

        public FormAbmCliente() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia, true);

            validator = new Validator()
                .add(txtNombre,    lErrorNombre,    Validator.vacio, Validator.nombre)
                .add(txtApellido,  lErrorApellido,  Validator.vacio, Validator.nombre)
                .add(txtDni,       lErrorDNI,       Validator.vacio, Validator.numerico)
                .add(txtMail,      lErrorMail,      Validator.vacio, Validator.mail)
                .add(txtDireccion, lErrorDireccion, Validator.vacio)
                .add(txtTelefono,  lErrorTelefono,  Validator.vacio, Validator.telefono)
                .add(cmbProvincia, lErrorProvincia, Validator.nulo);

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
        class ValidatorError {

            public Object campo {
                get; private set;
            }

            public ValidatorError(Object o) {
                this.campo = o;
            }

        }

        class Validator {
            abstract class ValidationEntry {
                abstract public bool validate();
            }
            class TextBoxValidationEntry : ValidationEntry {
                public TextBox campo;
                public Func<TextBox, bool> isValid;
                public Label label;

                public override bool validate() {
                    if (isValid(campo)) {
                        label.Visible = false;
                        return true;
                    }
                    label.Visible = true;
                    return false;
                }
            }
            class ComboValidationEntry : ValidationEntry {
                public ComboBox campo;
                public Func<ComboBox, bool> isValid;
                public Label label;

                public override bool validate() {
                    if (isValid(campo)) {
                        label.Visible = false;
                        return true;
                    }
                    label.Visible = true;
                    return false;
                }
            }

            List<ValidationEntry> checks = new List<ValidationEntry>();

            public readonly static Func<TextBox, bool> nombre = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[A-Z][ a-zA-Z]*$").Success;
            };
            public readonly static Func<TextBox, bool> mail = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,3}$").Success;
            };
            public readonly static Func<TextBox, bool> numerico = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^[0-9]+$").Success;
            };
            public readonly static Func<TextBox, bool> telefono = (TextBox campo) => {
                return campo.Text.Length == 0 || Regex.Match(campo.Text.Trim(), "^\\+?[0-9][ 0-9]*$").Success;
            };
            public readonly static Func<TextBox, bool> vacio = (TextBox campo) => {
                return campo.Text.Length != 0;
            };

            public readonly static Func<ComboBox, bool> nulo = (ComboBox campo) => {
                return campo.SelectedIndex != 0;
            };

            public Validator add(TextBox c, Label l, params Func<TextBox, bool>[] criteriaList) {
                foreach (Func<TextBox, bool> criteria in criteriaList) {
                    checks.Add(new TextBoxValidationEntry() { campo = c, isValid = criteria, label = l });
                }
                return this;
            }

            public Validator add(ComboBox c, Label l, params Func<ComboBox, bool>[] criteriaList) {
                foreach (Func<ComboBox, bool> criteria in criteriaList) {
                    checks.Add(new ComboValidationEntry() { campo = c, isValid = criteria, label = l });
                }
                return this;
            }

            public bool check() {
                bool result = true;
                foreach (ValidationEntry ve in checks) {
                    result = ve.validate() && result;
                }
                return result;
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
