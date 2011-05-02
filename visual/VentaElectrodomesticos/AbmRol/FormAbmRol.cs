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
            fillPermisos();
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoRoles form = new FormListadoRoles();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarRol((Rol)form.MessageFromParent);
                bCrearOtro.Hide();
                bLimpiar.Text = "Borrar";
                bCrear.Text = "Modificar";
            }
        }
        private void cargarRol(Rol rol){
            txtNombre.Text = rol.nombre;
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

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            for (int i = 0; i < chkListadoRoles.Items.Count; ++i)
                chkListadoRoles.SetItemChecked(i, false); 
        }
    }
}
