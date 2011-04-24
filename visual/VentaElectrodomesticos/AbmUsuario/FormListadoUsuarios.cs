using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.AbmEmpleado;

namespace VentaElectrodomesticos.AbmUsuario
{
    public partial class FormListadoUsuarios : Form
    {
        public FormListadoUsuarios()
        {
            InitializeComponent();
        }

        private void bBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.ShowDialog(this);
        }
    }
}
