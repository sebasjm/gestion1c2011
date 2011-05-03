using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.AbmProducto;
using VentaElectrodomesticos.AbmCliente;
using System.Data.SqlClient;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Facturacion
{
    public partial class FormFacturacion : Form
    {
        public FormFacturacion()
        {
            InitializeComponent();
            fillFormasPago();
            lCuotas.Hide();
            txtCuotas.Hide();
            fillFactura();
        }
        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            FormListadoClientes form = new FormListadoClientes();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarCliente((Cliente)form.MessageFromParent);
            }
        }
        private void cargarCliente(Cliente cargoCliente)
        {
            txtCliente.Text = cargoCliente.apellido + " , " + cargoCliente.apellido; 
        }
        private void bBuscarProducto_Click(object sender, EventArgs e)
        {
            FormListadoProductos form = new FormListadoProductos();
            // form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                Producto produ = (Producto)form.MessageFromParent;
                dataListadoProductos.Rows.Add();
                int r = dataListadoProductos.RowCount -2;
                dataListadoProductos.Rows[r].Cells[0].Value = produ.codigo;
                dataListadoProductos.Rows[r].Cells[1].Value = produ.descripcion;
                dataListadoProductos.Rows[r].Cells[2].Value = 1;
                dataListadoProductos.Rows[r].Cells[3].Value = produ.precio;
            }
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
            List<Sucursal> sucursalList = Context.instance.dao.sucursal.load();
            try
            {
                cmbSucursal.DataSource = sucursalList;
                cmbSucursal.DisplayMember = "direccion";
                cmbSucursal.ValueMember = "id";
                cmbSucursal.SelectedIndex = -1;
            }
            catch (NullReferenceException) { }
        }
        private void fillFormasPago()
        {
            List<string> pagos = new List<string>();
            pagos.Add("Pago en Efectivo");
            pagos.Add("Pago en Cuotas");
            for (int n = 0; n < pagos.Count; n++)
            {
                cmbFormasPago.Items.Add(pagos[n]);
            }
        }

        private void cmbFormasPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFormasPago.SelectedItem != null) {
                if ((string)cmbFormasPago.SelectedItem == "Pago en Cuotas")
                {
                    lCuotas.Show();
                    txtCuotas.Show();

                }
                else {
                    lCuotas.Hide();
                    txtCuotas.Hide();
                };
            }

        }
        private void fillFactura() {
            dataListadoProductos.Rows.Clear();
            dataListadoProductos.ColumnCount = 4;
            dataListadoProductos.ColumnHeadersVisible = true;
            dataListadoProductos.Columns[0].Name = "Producto";
            dataListadoProductos.Columns[1].Name = "Descripcion";
            dataListadoProductos.Columns[2].Name = "Cantidad";
            dataListadoProductos.Columns[3].Name = "Total";

        }
    }
}
