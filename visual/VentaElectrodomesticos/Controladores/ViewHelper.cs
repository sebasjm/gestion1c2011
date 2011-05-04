using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Modelo;


namespace VentaElectrodomesticos.Controladores {
    class ViewHelper {

        public static void fillComboProvincias(ComboBox cmbProvincia){
            fillComboProvincias(cmbProvincia,false);
        }
        public static void fillComboProvincias(ComboBox cmbProvincia, bool withNull) {
            List<Provincia> provinciasList = Context.instance.dao.provincia.load();
            if (withNull)
                provinciasList.Insert(0, new Provincia(0) { nombre = "---" });
            cmbProvincia.DataSource = provinciasList;
            cmbProvincia.DisplayMember = "nombre";
            cmbProvincia.ValueMember = "id";
            cmbProvincia.SelectedIndex = 0;
        }

        public static void fillComboSucursales(ComboBox cmbSucursal) {
            fillComboSucursales(cmbSucursal,false);
        }
        public static void fillComboSucursales(ComboBox cmbSucursal, bool withNull) {
            List<Sucursal> sucursalList = Context.instance.dao.sucursal.load();
            if (withNull)
                sucursalList.Insert(0, new Sucursal(0) { direccion = "---" });
            cmbSucursal.DataSource = sucursalList;
            cmbSucursal.DisplayMember = "direccion";
            cmbSucursal.ValueMember = "id";
            cmbSucursal.SelectedIndex = 0;
        }

        public static void fillComboTipoEmpleado(ComboBox cmbTipoEmpleado) {
            fillComboTipoEmpleado(cmbTipoEmpleado, false);
        }
        public static void fillComboTipoEmpleado(ComboBox cmbTipoEmpleado, bool withNull) {
            List<TipoEmpleado> tipoEmpleadoList = Context.instance.dao.tipoEmpleado.load();
            if ( withNull ) 
                tipoEmpleadoList.Insert(0, new TipoEmpleado(0) { nombre = "---" });
            cmbTipoEmpleado.DataSource = tipoEmpleadoList;
            cmbTipoEmpleado.DisplayMember = "nombre";
            cmbTipoEmpleado.ValueMember = "id";
            cmbTipoEmpleado.SelectedIndex = 0;
        }

    }
}
