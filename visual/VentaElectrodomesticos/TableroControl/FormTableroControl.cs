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

namespace VentaElectrodomesticos.TableroControl {
    public partial class FormTableroControl : Form {
        public FormTableroControl() {
            InitializeComponent();
            fillAnios();
            ViewHelper.fillComboSucursales(cmbSucursal);
        }
        private void fillAnios() {
            for (int n = 1995; n <= 2100; n++) {
                cmbAnioAnalizar.Items.Add(""+n);
            }
            cmbAnioAnalizar.SelectedItem = anio;
        }
        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        Sucursal sucursal = null;
        String anio = "1995";

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            sucursal = (Sucursal)cmbSucursal.SelectedItem;
            doSearch();
        }

        private void cmbAnioAnalizar_SelectedIndexChanged(object sender, EventArgs e) {
            anio = (String) cmbAnioAnalizar.SelectedItem;
            doSearch();
        }

        private void doSearch() {
            if (sucursal == null) return;
            lValorTotalVentas.Text = "" + Context.instance.dao.tablero.calcularTotalVentas(sucursal.id, anio);
            lValorMayorFactura.Text = "" + Context.instance.dao.tablero.calcularMayorFactura(sucursal.id, anio);
            lValorProporcionFormaPago.Text = "" + Context.instance.dao.tablero.calcularProporcionFormasDePago(sucursal.id, anio);
            lValorTotalFacturacion.Text = "" + Context.instance.dao.tablero.calcularTotalFacturacion(sucursal.id, anio);
            lValorFaltanteStock.Text = "" + Context.instance.dao.tablero.calcularFaltanteStock(sucursal.id, anio);
            lValorMayorDeudor.Text = "" + Context.instance.dao.tablero.calcularMayorDeudor(sucursal.id, anio);
            lValorMayorFactura.Text = "" + Context.instance.dao.tablero.calcularMayorFactura(sucursal.id, anio);
            lValorProductoAnio.Text = "" + Context.instance.dao.tablero.calcularMejorProducto(sucursal.id, anio);
            lValorVendedorAnio.Text = "" + Context.instance.dao.tablero.calcularMejorVendedor(sucursal.id, anio);
        }

    }
}
