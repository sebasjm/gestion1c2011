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

namespace VentaElectrodomesticos.ClientesPremium {
    public partial class FormClientesPremium : Form {
        public FormClientesPremium() {
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
            anio = (String)cmbAnioAnalizar.SelectedItem;
            doSearch();
        }
        private void doSearch() {
            if (sucursal == null) return;
            ViewHelper.fillDataGridClientesPremium(
                dataClientes,
                Context.instance.dao.tablero.mejoresClientes(sucursal.id, anio)
            );
        }

    }
}
