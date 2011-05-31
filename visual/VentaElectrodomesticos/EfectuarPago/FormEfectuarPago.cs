﻿using System;
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
        public FormEfectuarPago() {
            InitializeComponent();
            ViewHelper.fillComboProvincias(cmbProvincia);
            ViewHelper.fillComboSucursales(cmbSucursal);
        }

        private void bBuscarCliente_Click(object sender, EventArgs e) {
            FormListadoClientes form = new FormListadoClientes();
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                this.cargarCliente((Cliente)form.MessageFromParent);
                FillFacturas((Cliente)form.MessageFromParent);
            }
        }

        private void cargarCliente(Cliente cargoCliente) {
            txtCliente.Text = cargoCliente.apellido + " , " + cargoCliente.apellido;
        }

        void FillFacturas(Cliente cli) {
            List<Factura> facturaslList = Context.instance.dao.factura.search(cli.dni);
            try {
                cmbFactura.DataSource = facturaslList;
                cmbFactura.DisplayMember = "numero";
                cmbFactura.ValueMember = "numero";
                //cmbFactura.SelectedIndex = -1;
            } catch (NullReferenceException) { }
        }

        private void cmbFactura_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbFactura.SelectedItem != null) {
                Factura fact = ((Factura)cmbFactura.SelectedItem);
                double cuotas = (txtCuotas.Text == "") ? 1 : double.Parse(txtCuotas.Text);
                double total = ((fact.total - fact.total * fact.descuento) / fact.cuotas) * cuotas;
                lMontoPago.Text = "Monto a Pagar : " + total.ToString() + " Pesos";
            }
        }
        private void txtCuotas_TextChanged(object sender, EventArgs e) {
            if (cmbFactura.SelectedItem != null) {
                Factura fact = ((Factura)cmbFactura.SelectedItem);
                double cuotas = (txtCuotas.Text == "") ? 1 : double.Parse(txtCuotas.Text);
                double total = ((fact.total - fact.total * fact.descuento) / fact.cuotas) * cuotas;
                lMontoPago.Text = "Monto a Pagar : " + total.ToString() + " Pesos";
            }
        }

        private void bAceptar_Click(object sender, EventArgs e) {

        }
    }
}
