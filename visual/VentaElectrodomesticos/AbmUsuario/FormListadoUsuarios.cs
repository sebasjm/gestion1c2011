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
namespace VentaElectrodomesticos.AbmUsuario
{
    public partial class FormListadoUsuarios : Form
    {
        private Object messageFromParent = null;
        public Object MessageFromParent
        {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }
        public FormListadoUsuarios()
        {
            InitializeComponent();
            fillPermisos();
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
        private void cargarEmpleado(Empleado cargoEmpleado)
        {
            lNombreEmpleado.Text = cargoEmpleado.apellido + " , " + cargoEmpleado.nombre;
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataUsuarios.DataSource = Context.instance.dao.user.search(
                    txtUsername.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString(), "Problema en Consulta");
            }
        }
        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)dataUsuarios.Rows[dataUsuarios.CurrentCell.RowIndex].DataBoundItem;
            if (usuario != null)
            {
                this.messageFromParent = usuario;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Empleado");
            }
        }
        private void fillPermisos()
        {
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

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "";
            this.lNombreEmpleado.Text = "";
            this.dataUsuarios.DataSource = null;
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                chkListadoRoles.SetItemChecked(i, false);
        }
    }
}
