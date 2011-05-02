using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Modelo;

namespace VentaElectrodomesticos.AbmRol
{
    public partial class FormAbmRol : Form
    {
        public FormAbmRol()
        {
            InitializeComponent();
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoRoles form = new FormListadoRoles();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarRol((Rol)form.MessageFromParent);
            }
            bCrearOtro.Hide();
            bLimpiar.Text = "Borrar";
            bCrear.Text = "Modificar";
        }
        private void cargarRol(Rol rol){
            txtNombre.Text = rol.nombre;
        }
    }
}
