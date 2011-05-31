using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Vista;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Modelo;


namespace VentaElectrodomesticos.AbmRol
{
    public partial class FormListadoRoles : Form
    {
        private Object messageFromParent = null;
        public Object MessageFromParent
        {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }
        public FormListadoRoles()
        {
            InitializeComponent();
            ViewHelper.fillFuncionalidades(chkListadoRoles);
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
                txtNombre.Text = "";
            dataRoles.DataSource = Context.instance.dao.rol.search(
                txtNombre.Text,
                chkListadoRoles
            );
        }
        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            Rol rol = (Rol)dataRoles.Rows[dataRoles.CurrentCell.RowIndex].DataBoundItem;
            if (rol != null)
            {
                this.messageFromParent = rol;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Rol");
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            dataRoles.DataSource = null;
        }
    }
}
