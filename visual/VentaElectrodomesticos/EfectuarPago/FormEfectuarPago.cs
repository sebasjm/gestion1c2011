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
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;


namespace VentaElectrodomesticos.EfectuarPago {
    public partial class FormEfectuarPago : Form {

        private Sucursal sucursal = null;
        private Cliente cliente = null;

        public FormEfectuarPago() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
            ViewHelper.fillComboSucursales(cmbSucursal);

            sucursal = Context.instance.security.loggedUser.empleado.sucursal;
            cmbSucursal.SelectedItem = sucursal;
            cmbProvincia.SelectedItem = sucursal.provincia;
            cmbSucursal.Enabled = false;
            cmbProvincia.Enabled = false;
        }

        private void bBuscarCliente_Click(object sender, EventArgs e) {
            FormListadoClientes form = new FormListadoClientes();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarCliente((Cliente)form.MessageFromParent);
                cliente = (Cliente)form.MessageFromParent;
                FillFacturas();
            }
        }

        private void cargarCliente(Cliente cargoCliente) {
            txtCliente.Text = cargoCliente.apellido + " , " + cargoCliente.apellido;
        }

        void FillFacturas() {
            if (cliente != null && sucursal != null) {
                List<Factura> facturaslList = Context.instance.dao.factura.search(cliente, sucursal);
                ViewHelper.fillDataGridFacturas(dataFacturas, facturaslList);
            }
        }

        private void bAceptar_Click(object sender, EventArgs e) {
            Factura factura = cliente != null && sucursal != null ? (dataFacturas.SelectedRows.Count == 0 ? null : (Factura)dataFacturas.SelectedRows[0].Cells[0].Value) : null;
            if (factura == null) return;
            int cuotas = 0;
            try {
                cuotas = Int32.Parse(txtCuotas.Text);
            } catch (FormatException ) {
                return;
            }
            if (cuotas > factura.cuotasPorPagar) {
                MessageBox.Show("No puede pagar mas cuotas que las que faltan pagar", "Error", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("El total a pagar es : " + (factura.valorCuota * cuotas) + " ¿Esta seguro de realizar la transacción ?", "Confirmación", MessageBoxButtons.YesNo ) == DialogResult.Yes)
              {
                  Context.instance.dao.factura.pagar(factura, cuotas);
                  FillFacturas();

              }
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            sucursal = (Sucursal)cmbSucursal.SelectedItem;
            cmbProvincia.SelectedItem = sucursal != null ? sucursal.provincia : null;
            FillFacturas();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            Provincia item = (Provincia)cmbProvincia.SelectedItem;
            cmbSucursal.SelectedItem = item != null ? item.sucursal : null;
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
