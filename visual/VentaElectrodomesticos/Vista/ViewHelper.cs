﻿using System;
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

        public static void fillFuncionalidades(CheckedListBox chkRoles)
        {
           /*
            for (int n = 0; n < permisos.Count; n++)
            {
                chkRoles.Items.Add(permisos[n]);
            }
            */
            List<Funcionalidad> funcionalidadList = Context.instance.dao.funcionalidad.load();
            chkRoles.DataSource = funcionalidadList;
            chkRoles.DisplayMember = "nombre";
            chkRoles.ValueMember = "id";
            chkRoles.SelectedIndex = 0;
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

        public static void fillComboTipoEmpleado(ComboBox cmbTipoEmpleado, bool withNull) {
            List<TipoEmpleado> tipoEmpleadoList = Context.instance.dao.tipoEmpleado.load();
            if ( withNull ) 
                tipoEmpleadoList.Insert(0, new TipoEmpleado(0) { nombre = "---" });

            cmbTipoEmpleado.DataSource = tipoEmpleadoList;
            cmbTipoEmpleado.DisplayMember = "nombre";
            cmbTipoEmpleado.ValueMember = "id";
            cmbTipoEmpleado.SelectedIndex = 0;
        }

        public static void fillDataGridEmpleados(DataGridView dataEmpleados, List<Empleado> result) {
            dataEmpleados.ColumnCount = 9;

            dataEmpleados.Columns[0].Visible = false;
            dataEmpleados.Columns[1].Name = "DNI";
            dataEmpleados.Columns[2].Name = "Nombre";
            dataEmpleados.Columns[3].Name = "Apellido";
            dataEmpleados.Columns[4].Name = "eMail";
            dataEmpleados.Columns[5].Name = "Dirección";
            dataEmpleados.Columns[6].Name = "Telefono";
            dataEmpleados.Columns[7].Name = "Tipo";
            dataEmpleados.Columns[8].Name = "Sucursal";

            dataEmpleados.Rows.Clear();

            foreach (Empleado e in result) {
                dataEmpleados.Rows.Add(
                    e,
                    e.dni,
                    e.nombre,
                    e.apellido,
                    e.mail,
                    e.direccion,
                    e.telefono,
                    e.tipoEmpleado.nombre,
                    e.sucursal.direccion
                );
            }
        }
    }
}
