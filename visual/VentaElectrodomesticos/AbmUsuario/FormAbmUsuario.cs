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
        private Usuario user = null;
        private Empleado empleado = null;
        Validator validator;
        public FormAbmUsuario()
        {
            InitializeComponent();
            ViewHelper.fillFuncionalidades(chkListadoRoles);
            validator = new Validator()
                .add(txtUsername, lErrorUsername, Validator.vacio, Validator.nombre)
                .add(this.empleado, lErrorEmpleado, Validator.empleado)
                .add(txtPassword, lErrorPassword, Validator.vacio, Validator.password)
                .add(txtConfirmarPassword, lErrorConfirmPass, Validator.vacio, Validator.password)
                .add(chkListadoRoles, lErrorRoles,  Validator.sin_elementos)
                .add(txtPassword, txtConfirmarPassword, lErrorPassword , lErrorConfirmPass, Validator.passwordIgual);

        
        }
        private void bBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
            }
        }
        private void cargarEmpleado(Empleado cargoEmpleado){
            this.empleado = cargoEmpleado;
            lNombreEmpleado.Text = cargoEmpleado.apellido + " ," + cargoEmpleado.nombre;
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoUsuarios form = new FormListadoUsuarios();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarUsuario((Usuario)form.MessageFromParent);
                bCrearOtro.Hide();
                bLimpiar.Visible = false;
                bCrear.Visible = false;
                bModificar.Visible = true;
                bBorrar.Visible = true;
            }
        }
        private void cargarUsuario(Usuario cargoUsuario)
        {
            this.limpiar();
            this.user = cargoUsuario;
            txtUsername.Text = cargoUsuario.username;
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
        private void limpiar() {
            this.txtUsername.Text = "";
            this.lNombreEmpleado.Text = "";
            this.txtConfirmarPassword.Text = "";
            this.txtPassword.Text = "";
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                chkListadoRoles.SetItemChecked(i, false);   
        }
        private void bCrear_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
                if (MessageBox.Show("¿Esta seguro que desea crear al Usuario?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la creacion
                    Usuario user = new Usuario(0);
                    user.password = (String)this.txtPassword.Text;
                    user.username = (String)this.txtUsername.Text;
                    Context.instance.dao.user.insertar(user);
                    // Cargo el usuario recientemente creado.
                    List<Usuario> usuarioNuevo = Context.instance.dao.user.search((String)this.txtUsername.Text);
                    this.empleado.usuarioId = usuarioNuevo[0].id ;
                    Context.instance.dao.empleado.modificar(this.empleado);
                    this.Close();
                }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            if (!validator.check()) return;
                if (MessageBox.Show("¿Esta seguro que desea modificar al Usuario?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la modificacion
                    user.password = (String)this.txtPassword.Text;
                    user.username = (String)this.txtUsername.Text;
                    Context.instance.dao.user.modificar(user);
                    // Cargo el usuario recientemente creado.
                    List<Usuario> usuarioNuevo = Context.instance.dao.user.search((String)this.txtUsername.Text);
                    this.empleado.usuarioId = usuarioNuevo[0].id;
                    Context.instance.dao.empleado.modificar(this.empleado);
                    this.Close();
                }
        }
        private void bBorrar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al Usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la modificacion
                    this.Close();
                }
            }
        private void bCrearOtro_Click(object sender, EventArgs e)        {
            if (!validator.check()) return;
            if (MessageBox.Show("¿Esta seguro que desea Guardar y crear otro Usuario?", "Confirmar Guardar y Crear Otro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // proceder con el Guardado y la Creacion de otro
                Usuario user = new Usuario(0);
                user.password = (String)this.txtPassword.Text;
                user.username = (String)this.txtUsername.Text;
                Context.instance.dao.user.insertar(user);
                // Cargo el usuario recientemente creado.
                List<Usuario> usuarioNuevo = Context.instance.dao.user.search((String)this.txtUsername.Text);
                this.empleado.usuarioId = usuarioNuevo[0].id;
                Context.instance.dao.empleado.modificar(this.empleado);
                this.limpiar();
            }
        }
    }
}
