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

namespace VentaElectrodomesticos.AsignacionStock {
    public partial class FormAsignacionStock : Form {
        Empleado empleado;
        Sucursal sucursal;
        Producto producto;

        public FormAsignacionStock() {
            InitializeComponent();
            ViewHelper.fillComboSucursales(cmbSucursal);
        }
        private void bProducto_Click(object sender, EventArgs e) {
            FormListadoProductos form = new FormListadoProductos();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarProducto((Producto)form.MessageFromParent);
            }
            fillStock();
        }
        private void bAuditor_Click(object sender, EventArgs e) {
            FormListadoEmpleados form = new FormListadoEmpleados();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarEmpleado((Empleado)form.MessageFromParent);
            }
        }

        private void cargarEmpleado(Empleado emp) {
            txtAuditor.Text = emp.apellido + " , " + emp.nombre;
            this.empleado = emp;
        }

        private void cargarProducto(Producto prod) {
            txtProducto.Text = prod.codigo + " - " + prod.nombre;
            this.producto = prod;
        }

        void fillStock() {
            //al menos uno de los filtros tiene q estar activo
            List<Stock> stocks = (sucursal == null || sucursal.id == 0) && (producto == null || producto.codigo == 0) ?
                new List<Stock>() :
                Context.instance.dao.stock.search(this.sucursal, this.producto);

            ViewHelper.fillDataGridIngresoStock(dataStock, stocks);
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            this.sucursal = (Sucursal)cmbSucursal.SelectedItem;
            fillStock();
        }

        private void bAceptar_Click(object sender, EventArgs e) {
            MessageBox.Show("¿Esta seguro que desea asignar Stock?", "Asignar Stock");
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bLimpiar_Click(object sender, EventArgs e) {
            this.cmbSucursal.SelectedIndex = -1;
            this.txtAuditor.Text = "";
            this.txtProducto.Text = "";
            this.dataStock.Rows.Clear();
        }

        private void bAsignarOtro_Click(object sender, EventArgs e) {
            MessageBox.Show("¿Esta seguro que desea asignar Stock y volver a cargar otro?", "Asignar Stock");
            bLimpiar_Click(sender, e);
        }

    }
}
