using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.AbmEmpleado
{
    public partial class FormAbmEmpleado : Form
    {
        private int provincia_id = -1;
        public FormAbmEmpleado()
        {
            InitializeComponent();
            FillProvincias();
            FillSucursal();
            FillTipoEmpleado();
        }
        private void bBuscar_Click(object sender, EventArgs e)
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
        private void cargarEmpleado(Empleado cargoEmpleado)
        {
            try
            {
                        txtApellido.Text = cargoEmpleado.apellido;
                        txtNombre.Text = cargoEmpleado.nombre;
                        txtDni.Text = cargoEmpleado.dni.ToString();
                        txtMail.Text = cargoEmpleado.mail;
                        string input = cargoEmpleado.direccion;
                        // Split on one or more non-digit characters.
                        string[] numbers = Regex.Split(input, @"\D+");
                        txtCalle.Text = Regex.Split(input, numbers[1])[0];
                        txtNumero.Text = (numbers[1] != "") ? "" + numbers[1] : "";
                        txtDeptoPiso.Text = (numbers[2] != "") ? "" + numbers[2] : "";
            
            }
            catch (IndexOutOfRangeException) { /* TODO : Error que no se porque sucede */  }

        }
        void FillProvincias()
        {
            List<Provincia> provinciasList = Context.instance.dao.provincia.load();
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
            List<Sucursal> sucursalList = Context.instance.dao.sucursal.search(this.provincia_id);
            try
            {
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
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            if (bLimpiar.Text == "Borrar")
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar al Empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con el borrado
                }
            }
        }
        private void bCrear_Click(object sender, EventArgs e)
        {
            if (bLimpiar.Text == "Crear")
            {
                if (MessageBox.Show("¿Esta seguro que desea crear al Empleado?", "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la creacion
                }
            }
            else
            {
                if (MessageBox.Show("¿Esta seguro que desea modificar al cliente?", "Confirmar Modificación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // proceder con la modificacion
                }
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
