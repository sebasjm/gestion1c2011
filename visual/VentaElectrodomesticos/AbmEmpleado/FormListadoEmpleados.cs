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
        private Object messageFromParent;
        public Object MessageFromParent
        {
            get { return messageFromParent; }
            set { messageFromParent = value; }
        }

        private string nombre;
        private string apellido;
        private int dni = -1;
        private int sucursal_id = -1 ;
        private int provincia_id = -1;
        private int tipoempleado_id = -1;

        public FormListadoEmpleados(){
            InitializeComponent();
            cmbSucursal.Items.Insert(0, "Todos los Resultados");
            cmbProvincia.Items.Insert(0, "Todos los Resultados");
            cmbTipoEmpleado.Items.Insert(0, "Todos los Resultados");
            FillProvincias();
            FillSucursal();
            FillTipoEmpleado();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.messageFromParent = 0;
            this.Close();
        }
        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Length == 0)
                txtDni.Text = "0";

            try {
                dataEmpleados.DataSource = Context.instance.dao.empleado.search(txtNombre.Text,
                    txtApellido.Text,
                    Convert.ToInt32(txtDni.Text),
                    (Provincia)cmbProvincia.SelectedItem,
                    (Sucursal)cmbSucursal.SelectedItem,
                    (TipoEmpleado)cmbTipoEmpleado.SelectedItem
                );
            } catch (FormatException ex) {

            }

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
        void FillProvincias()
        {
            List<Provincia> provinciasList = Context.instance.dao.provincia.getProvincias();
            try
            {
                cmbProvincia.DataSource = provinciasList;
                cmbProvincia.DisplayMember = "nombre";
                cmbProvincia.ValueMember = "id";
                cmbProvincia.SelectedIndex = -1;
            }
            catch (NullReferenceException) { }
        }
        void FillSucursal()
        {
            List<Sucursal> sucursalList = Context.instance.dao.sucursal.getSucursales(this.provincia_id);
            try{
                cmbSucursal.DataSource = sucursalList;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "id";
                cmbSucursal.SelectedIndex = -1;
            }
            catch (NullReferenceException) { }
        }
        void FillTipoEmpleado()
        {
            try
            {
                List<TipoEmpleado> tipoEmpleadoList = Context.instance.dao.tipoEmpleado.getTipoEmpleadoes(this.provincia_id);
                cmbTipoEmpleado.DataSource = tipoEmpleadoList;
                cmbTipoEmpleado.DisplayMember = "nombre";
                cmbTipoEmpleado.ValueMember = "id";
                cmbTipoEmpleado.SelectedIndex = -1;
            }
            catch (NullReferenceException) { }
        }
        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.provincia_id = (cmbProvincia.SelectedItem != null) ? ((Provincia)cmbProvincia.SelectedItem).id : -1;
            FillSucursal();
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDni.Text = "";
            txtNombre.Text = "";
            cmbProvincia.SelectedIndex = -1;
        }

    }
}
