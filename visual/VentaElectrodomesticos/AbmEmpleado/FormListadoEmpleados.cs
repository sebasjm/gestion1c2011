using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.AbmEmpleado
{
    public partial class FormListadoEmpleados : Form
    {
        private Object messageFromParent = null;
        public Object MessageFromParent
        {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }

        public FormListadoEmpleados(){
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
            ViewHelper.fillComboSucursales(cmbSucursal);
            ViewHelper.fillComboTipoEmpleado(cmbTipoEmpleado);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.messageFromParent = null;
            this.Close();
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Length == 0)
                txtDni.Text = "0";

            dataEmpleados.DataSource = Context.instance.dao.empleado.search(
                txtNombre.Text,
                txtApellido.Text,
                Convert.ToInt32(txtDni.Text),
                (Sucursal)cmbSucursal.SelectedItem,
                (TipoEmpleado)cmbTipoEmpleado.SelectedItem
            );
        }
        private void bSeleccionar_Click_1(object sender, EventArgs e)
        {
            Empleado empleado = (Empleado)dataEmpleados.Rows[dataEmpleados.CurrentCell.RowIndex].DataBoundItem; 
            if (empleado != null)
            {
                this.messageFromParent = empleado;
                this.Close();
            }else{
                MessageBox.Show("Debe seleccionar un Empleado");
            }
        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            cmbProvincia.SelectedIndex = 0;
            cmbSucursal.SelectedIndex = 0;
            cmbTipoEmpleado.SelectedIndex = 0;
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            cmbProvincia.SelectedItem = ((Sucursal)cmbSucursal.SelectedItem).provincia;
            cmbProvincia.Refresh();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            cmbSucursal.SelectedItem = ((Provincia)cmbProvincia.SelectedItem).sucursal;
            cmbSucursal.Refresh();
        }

    }
}
