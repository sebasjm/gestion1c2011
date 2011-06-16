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

namespace VentaElectrodomesticos.MejoresCategorias {
    public partial class FormMejoresCategorias : Form {
        public FormMejoresCategorias() {
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
            ViewHelper.fillDataGridMejoresCategorias(
                dataCategorias,
                Context.instance.dao.tablero.mejoresCategorias(sucursal.id, anio)
            );

        }

        private void FormMejoresCategorias_Load(object sender, EventArgs e) {
            if (!Context.instance.security.hasPermissionTo(Security.FUNCIONALIDAD_TABLERO_CATEGORIAS)) {
                MessageBox.Show("No tiene permisos suficiente para esta funcionalidad");
                this.Close();
                return;
            };
        }
    }
}
