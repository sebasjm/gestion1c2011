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

namespace VentaElectrodomesticos.Facturacion
{
    public partial class FormFacturacion : Form
    {
        public FormFacturacion()
        {
            InitializeComponent();
        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.ShowDialog(this);


        }

        private void bBuscarProducto_Click(object sender, EventArgs e)
        {
            FormListadoProductos form = new FormListadoProductos();
            form.ShowDialog(this);
        }
    }
}
