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
        }

        private void FormAbmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void bBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = 0;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
            }
            //MessageBox.Show(form.MessageFromParent.ToString());
            bCrearOtro.Hide();
            bLimpiar.Text = "Borrar";
            bCrear.Text = "Modificar";
        }
        private void cargarEmpleado(Empleado cargoEmpleado){
            string nombre = cargoEmpleado.nombre;
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            FormListadoUsuarios form = new FormListadoUsuarios();
            form.ShowDialog(this);
        }

    }
}
