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
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.AsignacionStock
{
    public partial class FormAsignacionStock : Form
    {
        Empleado empleado;
        Sucursal sucursal;
        Producto producto;

        public FormAsignacionStock()
        {
            InitializeComponent();
            fillStock();
            fillSucursal();
        }
        private void bProducto_Click(object sender, EventArgs e)
        {
            FormListadoProductos form = new FormListadoProductos();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarProducto((Producto)form.MessageFromParent);
           }
        }
        private void bAuditor_Click(object sender, EventArgs e)
        {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null)
            {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
                
            }
        }
        void fillSucursal()
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
        private void cargarEmpleado(Empleado emp) {
            txtAuditor.Text = emp.apellido + " , " + emp.nombre;
            this.empleado = emp;
            fillStock();
        }
        private void cargarProducto(Producto prod)
        {
            txtProducto.Text = prod.codigo + " - " + prod.nombre;
            this.producto = prod;
            fillStock();
        }
        void fillStock()
        {
            dataStock.DataSource = Context.instance.dao.stock.search(this.sucursal , this.producto ,0 );
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sucursal = (Sucursal)cmbSucursal.SelectedItem;
            fillStock();
        }
   }
}
