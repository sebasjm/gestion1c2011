using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.AbmProducto;
using VentaElectrodomesticos.AbmEmpleado;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.AsignacionStock
{
    public partial class FormAsignacionStock : Form
    {
        public FormAsignacionStock()
        {
            InitializeComponent();
        }

        private void bProducto_Click(object sender, EventArgs e)
        {
            FormListadoProductos form = new FormListadoProductos();
            form.ShowDialog(this);
        }

        private void bAuditor_Click(object sender, EventArgs e)
        {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.ShowDialog(this);
        }
    }
}
