﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.AbmCliente;
using VentaElectrodomesticos.AbmProducto;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Vista;

namespace VentaElectrodomesticos.Facturacion {
    public partial class FormFacturacion : Form {

        Producto producto = null;
        Cliente cliente = null;
        Sucursal sucursal = null;
        Dictionary<int, ItemFacturaMock> itemsFacturaByProductoCodigo = new Dictionary<int, ItemFacturaMock>();

        Validator validatorAgregarItem = null;
        Validator validatorCrearFactura = null;

        double total = 0;
        double descuento = 0;
        byte cuotas = 1;
        int stock_producto = 0;

        public FormFacturacion() {
            InitializeComponent();

            ViewHelper.fillComboProvincias(cmbProvincia);
            ViewHelper.fillComboSucursales(cmbSucursal);
            ViewHelper.fillDataGridItemFactura(dataListadoProductos, new List<ItemFacturaMock>( itemsFacturaByProductoCodigo.Values ));

            fillFormasPago();
            ShowMonto();
            if (Context.instance.security.esAnalista()) {

            } else {
                sucursal = Context.instance.security.loggedUser.empleado.sucursal;
                cmbSucursal.SelectedItem = sucursal;
                cmbProvincia.SelectedItem = sucursal.provincia;
                cmbSucursal.Enabled = false;
                cmbProvincia.Enabled = false;
            }

            validatorAgregarItem = new Validator()
                .add(txtCantidad, lErrorCantidad, Validator.Text.obligatorio, Validator.Text.numerico);

            validatorCrearFactura = new Validator();
//                .add(txtDescuento, lErrorDescuento, Validator.Text.obligatorio);
        }
        private void bBuscarCliente_Click(object sender, EventArgs e) {
            FormListadoClientes form = new FormListadoClientes("");
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (form.MessageFromParent != null) {
                cliente = (Cliente)form.MessageFromParent;
                txtCliente.Text = cliente == null ? "" : cliente.apellido + " , " + cliente.nombre;
            }
        }

        private void bBuscarProducto_Click(object sender, EventArgs e) {
            FormListadoProductos form = new FormListadoProductos("");
            form.MessageFromParent = null;
            form.ShowDialog(this);
            if (sucursal == null) {
                MessageBox.Show("Seleccione una sucursal primero", "Error");
                return;
            }
            if (form.MessageFromParent != null) {
                producto = (Producto)form.MessageFromParent;
                txtProducto.Text = producto == null ? "" : producto.codigo + " - " + producto.nombre;
                if (producto == null) {
                    return;
                }
                stock_producto = Context.instance.dao.stock.find(sucursal, producto).stock;
            }
        }

        private void fillFormasPago() {
            cmbFormasPago.Items.Add("Pago en Efectivo");
            cmbFormasPago.Items.Add("Pago en Cuotas");
            cmbFormasPago.SelectedIndex = 0;
        }

        private Boolean esPagoEnCuotas() {
            return "Pago en Cuotas".Equals(cmbFormasPago.SelectedItem);
        }

        private void cmbFormasPago_SelectedIndexChanged(object sender, EventArgs e) {
            if (esPagoEnCuotas()) {
                cuotas = 2;
                lCuotas.Show();
                txtCuotas.Show();
                lCuota.Show();
                lTotalCuota.Show();
            } else {
                cuotas = 1;
                lCuotas.Hide();
                txtCuotas.Hide();
                lCuota.Hide();
                lTotalCuota.Hide();
            };
            ShowMonto();
        }


        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e) {
            sucursal = (Sucursal)cmbSucursal.SelectedItem;
            cmbProvincia.SelectedItem = sucursal != null ? sucursal.provincia : null;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e) {
            Provincia item = (Provincia)cmbProvincia.SelectedItem;
            cmbSucursal.SelectedItem = item != null ? item.sucursal : null;
        }

        private void bAgregarProducto_Click(object sender, EventArgs e) {
            if (!validatorAgregarItem.check()) return;
            Int32 cant = Int32.Parse(txtCantidad.Text);
            if (cant > stock_producto) {
                MessageBox.Show("La cantidad de items no puede ser mayor al stock actual: " + stock_producto, "Error");
                return;
            }
            if (itemsFacturaByProductoCodigo.ContainsKey(producto.codigo)) {
                int old_cant = itemsFacturaByProductoCodigo[producto.codigo].cantidad;
                total = total - producto.precio * old_cant;
                itemsFacturaByProductoCodigo.Remove(producto.codigo);
            }
            if (cant != 0) {
                itemsFacturaByProductoCodigo.Add(
                    producto.codigo,
                    new ItemFacturaMock(producto) { cantidad = cant }
                );
                total = total + producto.precio * cant;
            } 
            ViewHelper.fillDataGridItemFactura(dataListadoProductos, new List<ItemFacturaMock>(itemsFacturaByProductoCodigo.Values));
            ShowMonto();
        }
        private void ShowMonto() {
            lTotal.Text = String.Format("{0:#,##0.00}", total);
            lTotalDescuento.Text = String.Format("{0:#,##0.00}", total * (1 - descuento));
            lTotalCuota.Text = String.Format("{0:#,##0.00}", (total/cuotas) * (1 - descuento));
            txtCuotas.Text = "" + cuotas;
        }
        private void bAceptar_Click(object sender, EventArgs e) {
            if (!validatorCrearFactura.check()) return;
            if (sucursal == null || producto == null || cliente == null) {
                return;
            }
            string mensaje = "";
            if (esPagoEnCuotas()) {
                mensaje = String.Format("¿Crear la factura de {0} cuotas por {1} cada una?", cuotas, lTotalCuota.Text);
            } else {
                mensaje = String.Format("¿Crear la factura al contado por un total de {0}?", lTotalDescuento.Text);
            }
            if (MessageBox.Show(mensaje, "Confirmar Creación", MessageBoxButtons.YesNo) == DialogResult.No) {
                return;
            }
            Context.instance.dao.factura.nueva(
                descuento,
                total, 
                cuotas, 
                cliente, 
                new List<ItemFacturaMock>(itemsFacturaByProductoCodigo.Values) 
            );
            this.Close();
        }
        private void limpiar() {
            producto = null;
            total = 0;
            descuento = 0;
            cuotas = 1;
            stock_producto = 0;
            ShowMonto();
            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
            cmbFormasPago.SelectedIndex = 0;
            itemsFacturaByProductoCodigo = new Dictionary<int, ItemFacturaMock>();
            ViewHelper.fillDataGridItemFactura(dataListadoProductos, new List<ItemFacturaMock>());
        }
        private void txtDescuento_Leave(object sender, EventArgs e) {
            Boolean error = false;
            try {
                descuento = Double.Parse(txtDescuento.Text);
            } catch (FormatException ) {
                error = true;
            }
            if (error || descuento < 0 || descuento > 30) {
                descuento = 0;
            }
            txtDescuento.Text = String.Format("{0:#,##0.00}", descuento);
            //con el formato se perdio presicion, releer descuento pero asumir buen formato
            descuento = Double.Parse(txtDescuento.Text) / 100;
            ShowMonto();
        }
        private void txtCuotas_Leave(object sender, EventArgs e) {
            try {
                cuotas = Byte.Parse(txtCuotas.Text);
            } catch (FormatException) { }
            if (cuotas < 2 || cuotas > 12) {
                cuotas = 2;
            }
            txtCuotas.Text = String.Format("{0}", cuotas);
            ShowMonto();
        }

        private void FormFacturacion_Load(object sender, EventArgs e) {
            if (!Context.instance.security.hasPermissionTo(Security.FUNCIONALIDAD_OPERACION_FACTURACION)) {
                MessageBox.Show("No tiene permisos suficiente para esta funcionalidad");
                this.Close();
                return;
            };
        }

        private void bCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
