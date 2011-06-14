using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.AbmEmpleado;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Vista;

namespace VentaElectrodomesticos.AbmUsuario
{
    public partial class FormAbmUsuario : Form
    {
        Validator validator;
        Validator validatorModificar;
        Empleado empleado = null;
        Usuario user = null;
        public FormAbmUsuario()
        {
            InitializeComponent();
            ViewHelper.fillRoles(chkListadoRoles);
            validator = new Validator()
                .add(txtUsername, lErrorUsername, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtPassword, lErrorPassword, Validator.Text.obligatorio)
                .add(txtConfirmarPassword, lErrorConfirmPass, Validator.Text.obligatorio)
                .add(txtEmpleado, lErrorEmpleado, Validator.Text.obligatorio);
            validatorModificar = new Validator()
                .add(txtUsername, lErrorUsername, Validator.Text.obligatorio, Validator.Text.nombre)
                .add(txtEmpleado, lErrorEmpleado, Validator.Text.obligatorio);
        }
        private void bBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
                Usuario userEmpleado = Context.instance.dao.user.findBy(this.empleado);
                if (userEmpleado != null) {
                    cargarUsuario(userEmpleado);
                    cargarRoles();
                    bCrearOtro.Hide();
                    bCrear.Visible = false;
                    bModificar.Visible = true;
                    bBorrar.Visible = true;
                }

            }
        }
        private void cargarEmpleado(Empleado cargoEmpleado){
            this.empleado = cargoEmpleado;
            txtEmpleado.Text = cargoEmpleado.apellido + " ," + cargoEmpleado.nombre;
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoUsuarios form = new FormListadoUsuarios();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.limpiar();
                this.cargarUsuario((Usuario)form.MessageFromParent);
                cargarEmpleado(this.user.empleado);
                cargarRoles();
                bCrearOtro.Hide();
                bCrear.Visible = false;
                bModificar.Visible = true;
                bBorrar.Visible = true;
            }
        }
        private void cargarUsuario(Usuario cargoUsuario)
        {
            this.user = cargoUsuario;
            txtUsername.Text = cargoUsuario.username;
        }
        private void cargarRoles(){
            List<Rol> func = Context.instance.dao.rol.findBy(this.user);

            for (int i = 0; i < chkListadoRoles.Items.Count; ++i) {
                Rol funca = (Rol)chkListadoRoles.Items[i];
                List<Rol> results = func.FindAll(
                    delegate(Rol p) { return p.id == funca.id; }
                    );
                if (results.Count > 0) {
                    chkListadoRoles.SetItemChecked(i, true);
                } else {
                    chkListadoRoles.SetItemChecked(i, false);
                }
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
        private void limpiar() {
            bCrear.Visible = true;
            bCrearOtro.Visible = true;
            bModificar.Visible = false;
            bBorrar.Visible = false;
            this.txtUsername.Text = "";
            this.txtEmpleado.Text = "";
            this.empleado = null;
            this.user = null;
            this.txtConfirmarPassword.Text = "";
            this.txtPassword.Text = "";
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                chkListadoRoles.SetItemChecked(i, false);   
        }
        private void bCrear_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
            if (!checkConfirmPass()) return;
                if (MessageBox.Show("¿Esta seguro que desea crear al Usuario?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la creacion
                    create_from_form();
                    this.Close();
                }
        }
        private void create_from_form(){
            Usuario user = new Usuario(0);
            user.password = (String)this.txtPassword.Text;
            user.username = (String)this.txtUsername.Text;
            user.empleado_dni = this.empleado.dni;
            Context.instance.dao.user.insertar(user);
            this.user = Context.instance.dao.user.findByName(user.username);
            // Cargo el usuario recientemente creado.
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i) {
                if (chkListadoRoles.GetItemChecked(i)) {
                    Context.instance.dao.user.insertarRol(this.user, (Rol)chkListadoRoles.Items[i]);
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!validatorModificar.check()) return;
            if (!checkConfirmPass()) return;
                if (MessageBox.Show("¿Esta seguro que desea modificar al Usuario?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la modificacion
                    user.password = (String)this.txtPassword.Text;
                    user.username = (String)this.txtUsername.Text;
                    Context.instance.dao.user.modificar(user);
                    // Cargo el usuario recientemente creado.
                    Context.instance.dao.user.limpiarRoles(this.user);
                    for (int i = 0; i < chkListadoRoles.Items.Count; ++i) {
                        if (chkListadoRoles.GetItemChecked(i)) {
                            Context.instance.dao.user.insertarRol(this.user, (Rol)chkListadoRoles.Items[i]);
                        }
                    }
                    this.Close();
                }
        }
        private void bBorrar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al Usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la modificacion
                    if (this.user.id == null) return;
                    Context.instance.dao.user.eliminar((int)this.user.id);
                    Context.instance.dao.user.limpiarRoles(this.user);
                    this.Close();
                }
            }
        private void bCrearOtro_Click(object sender, EventArgs e)        {
            if (!validator.check()) return;
            if (!checkConfirmPass()) return;
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Usuario?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el Guardado y la Creacion de otro
                create_from_form();
                this.limpiar();
            }
        }
        private bool checkConfirmPass() {
           if (this.txtPassword.Text.Length != 0 && this.txtConfirmarPassword.Text != this.txtPassword.Text) {
                lErrorPassword.Visible = true;
                lErrorConfirmPass.Visible = true;
                return false;
           }
           lErrorPassword.Visible = false;
           lErrorConfirmPass.Visible = false;
           return true;
        }
    }
}
