using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
        private string nombre = "";
        public FormListadoRoles()
        {
            InitializeComponent();
            FillData();
        }
        void FillData()
        {
            List<Rol> rolesList = Context.instance.dao.rol.getRoles( -1 , this.nombre );
            try
            {
                lRoles.DataSource = rolesList;
                lRoles.DisplayMember = "nombre";
                lRoles.ValueMember = "id";
                lRoles.SelectedIndex = -1;
            }
            catch (NullReferenceException) { }
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            this.nombre = txtNombre.Text;
            FillData();
        }
        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            Rol rol = (Rol)lRoles.Items[0];
            // Rows[lRoles.CurrentCell.RowIndex].DataBoundItem;
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
            lRoles.DataSource = null;
        }
    }
}
