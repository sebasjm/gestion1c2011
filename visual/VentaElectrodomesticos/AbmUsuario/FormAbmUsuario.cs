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

namespace VentaElectrodomesticos.AbmUsuario
{
    public partial class FormAbmUsuario : Form
    {
        public FormAbmUsuario()
        {
            InitializeComponent();
            fillPermisos();
            lErrorConfirmPass.Visible = false;
            lErrorEmpleado.Visible = false;
            lErrorPassword.Visible = false;
            lErrorRoles.Visible = false;
            lErrorUsername.Visible = false;
            bBorrar.Visible = false;
            bModificar.Visible = false;
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
                bLimpiar.Text = "Borrar";
                bCrear.Text = "Modificar";
            }
        }
        private void cargarUsuario(Usuario cargoUsuario)
        {
            txtUsername.Text = cargoUsuario.username;
        }
        private void fillPermisos() {
            List<string> permisos = new List<string>();
            permisos.Add("ABM de Empleado");
            permisos.Add("ABM de Rol");
            permisos.Add("ABM de Usuario");
            permisos.Add("ABM de Cliente");
            permisos.Add("ABM de Producto");
            permisos.Add("Asignación de stock");
            permisos.Add("Facturación");
            permisos.Add("Efectuar Pago");
            permisos.Add("Tablero de Control");
            permisos.Add("Clientes Premium");
            permisos.Add("Mejores Categorías");
            for (int n = 0; n < permisos.Count; n++)
            {
                chkListadoRoles.Items.Add(permisos[n]);
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            if (bLimpiar.Text == "Borrar")
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al Usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con el borrado
                }
            }
            else {
                this.txtUsername.Text = "";
                this.lNombreEmpleado.Text = "";
                this.txtConfirmarPassword.Text = "";
                this.txtPassword.Text = "";
                for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                    chkListadoRoles.SetItemChecked(i, false);            
            }
        }
        private void bCrear_Click(object sender, EventArgs e)
        {
            if (bLimpiar.Text == "Crear")
            {
                if (MessageBox.Show("¿Esta seguro que desea crear al Usuario?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la creacion
                }
            }
            else
            {
                if (MessageBox.Show("¿Esta seguro que desea modificar al Usuario?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la modificacion
                }
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bModificar_Click(object sender, EventArgs e)
        {

        }
        private void bBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
