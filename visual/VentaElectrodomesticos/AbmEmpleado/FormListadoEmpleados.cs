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

namespace VentaElectrodomesticos.AbmEmpleado
{
    public partial class FormListadoEmpleados : Form
    {
        public FormListadoEmpleados()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e) {
            if (txtDni.Text.Length == 0)
                txtDni.Text = "0";

            List<Empleado> result = null;
            try {
                result = Context.instance.dao.empleado.search(txtNombre.Text,
                    txtApellido.Text,
                    Convert.ToInt32(txtDni.Text),
                    (Provincia)cmbProvincia.SelectedItem,
                    (Sucursal)cmbSucursal.SelectedItem,
                    (TipoEmpleado)cmbTipoEmpleado.SelectedItem
                );
            } catch (FormatException ex) { 

            }

            dataGridView1.DataSource = result;
        }
    }
}
