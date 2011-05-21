using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentaElectrodomesticos.Modelo;
namespace VentaElectrodomesticos.Controladores {
    class ViewHelper {
        public static void fillComboProvincias(ComboBox cmbProvincia) {
            List<Provincia> provinciasList = Context.instance.dao.provincia.load();
            provinciasList.Insert(0, new Provincia(0) { nombre = "---" });
            cmbProvincia.DataSource = provinciasList;
            cmbProvincia.DisplayMember = "nombre";
            cmbProvincia.ValueMember = "id";
            cmbProvincia.SelectedIndex = 0;
        }

        public static void fillFuncionalidades(CheckedListBox chkRoles)
        {
            List<Funcionalidad> funcionalidadList = Context.instance.dao.funcionalidad.load();
            chkRoles.DataSource = funcionalidadList;
            chkRoles.DisplayMember = "nombre";
            chkRoles.ValueMember = "id";
            chkRoles.SelectedIndex = 0;
        }
        public static void fillComboSucursales(ComboBox cmbSucursal) {
            List<Sucursal> sucursalList = Context.instance.dao.sucursal.load();
            sucursalList.Insert(0, new Sucursal(0) { direccion = "---" });
            cmbSucursal.DataSource = sucursalList;
            cmbSucursal.DisplayMember = "direccion";
            cmbSucursal.ValueMember = "id";
            
            cmbSucursal.SelectedIndex = 0;
        }

        public static void fillComboTipoEmpleado(ComboBox cmbTipoEmpleado) {
            List<TipoEmpleado> tipoEmpleadoList = Context.instance.dao.tipoEmpleado.load();
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

        public static void fillDataGridClientes(DataGridView dataClientes, List<Cliente> result) {
            dataClientes.ColumnCount = 8;

            dataClientes.Columns[0].Visible = false;
            dataClientes.Columns[1].Name = "DNI";
            dataClientes.Columns[2].Name = "Nombre";
            dataClientes.Columns[3].Name = "Apellido";
            dataClientes.Columns[4].Name = "eMail";
            dataClientes.Columns[5].Name = "Dirección";
            dataClientes.Columns[6].Name = "Telefono";
            dataClientes.Columns[7].Name = "Provincia";

            dataClientes.Rows.Clear();

            foreach (Cliente c in result) {
                dataClientes.Rows.Add(
                    c,
                    c.dni,
                    c.nombre,
                    c.apellido,
                    c.mail,
                    c.direccion,
                    c.telefono,
                    c.provincia != null ? c.provincia.nombre : "---"
                );
            }
        }

        public static void fillDataGridIngresoStock(DataGridView dataStock, List<Stock> result) {
            dataStock.ColumnCount = 5;

            dataStock.Columns[0].Visible = false;
            dataStock.Columns[1].Name = "Adicionar stock";
            dataStock.Columns[2].Name = "Stock actual";
            dataStock.Columns[3].Name = "Producto";
            dataStock.Columns[4].Name = "Sucursal";
            dataStock.Columns[4].Width = 200;

            dataStock.Rows.Clear();

            foreach (Stock s in result) {
                dataStock.Rows.Add(
                    s,
                    0,
                    s.stock,
                    s.producto_codigo,
                    s.sucursal.direccion
                );
            }
        }
    }
}
