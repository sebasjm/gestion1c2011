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
namespace VentaElectrodomesticos.AbmUsuario {
    public partial class FormListadoUsuarios : Form {
        private Object messageFromParent = null;
        private Empleado empleado;
        public Object MessageFromParent {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }
        public bool usuariosActivos = true;
        public FormListadoUsuarios() {
            InitializeComponent();
            ViewHelper.fillRoles(chkListadoRoles);
        }
        private void bBuscarEmpleado_Click(object sender, EventArgs e) {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
            }
        }
        private void cargarEmpleado(Empleado cargoEmpleado) {
            empleado = cargoEmpleado;
            lNombreEmpleado.Text = cargoEmpleado.apellido + " , " + cargoEmpleado.nombre + " ("+empleado.dni+")";
        }
        private void bBuscar_Click(object sender, EventArgs e) {
            try {
                List<string> valores = new List<string>();
                foreach (Rol rol in chkListadoRoles.CheckedItems) {
                    valores.Add("" + rol.id);
                }
                usuariosActivos = !chkEliminados.Checked;
                dataUsuarios.DataSource = Context.instance.dao.user.search(
                    txtUsername.Text,
                    valores,
                    empleado,
                    usuariosActivos);
            } catch (FormatException ex) {
                MessageBox.Show(ex.ToString(), "Problema en Consulta");
            }
        }
        private void bSeleccionar_Click(object sender, EventArgs e) {
            Usuario usuario = dataUsuarios.SelectedRows.Count == 0 ? null : (Usuario)dataUsuarios.Rows[dataUsuarios.CurrentCell.RowIndex].DataBoundItem;
            if (usuario != null) {
                this.messageFromParent = usuario;
                this.Close();
            } else {
                MessageBox.Show("Debe seleccionar un Empleado");
            }
        }
        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void bLimpiar_Click(object sender, EventArgs e) {
            this.txtUsername.Text = "";
            this.lNombreEmpleado.Text = "";
            this.dataUsuarios.DataSource = null;
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                chkListadoRoles.SetItemChecked(i, false);
        }
    }
}
