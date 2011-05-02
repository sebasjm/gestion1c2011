using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.AbmCliente;
using System.Data.SqlClient;


namespace VentaElectrodomesticos.EfectuarPago
{
    public partial class FormEfectuarPago : Form
    {
        public FormEfectuarPago()
        {
            InitializeComponent();
        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            FormListadoClientes form = new FormListadoClientes();
            form.ShowDialog(this);
        }
    }
}
