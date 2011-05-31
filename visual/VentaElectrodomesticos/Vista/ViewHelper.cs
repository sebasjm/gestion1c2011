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

        public static void fillFuncionalidades(CheckedListBox chkRoles) {
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
        public static void fillComboMarcas(ComboBox cmbMarca) {
            List<Marca> marcaList = Context.instance.dao.marca.load();
            marcaList.Insert(0, new Marca(0) { nombre = "---" });
            cmbMarca.DataSource = marcaList;
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "id";
            cmbMarca.SelectedIndex = 0;
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
        public static void fillDataGridProductos(DataGridView dataProductos, List<Producto> result) {
            dataProductos.ColumnCount = 7;
            dataProductos.Columns[0].Visible = false;
            dataProductos.Columns[1].Name = "Código";
            dataProductos.Columns[2].Name = "Nombre";
            dataProductos.Columns[3].Name = "Descripción";
            dataProductos.Columns[4].Name = "Precio";
            dataProductos.Columns[5].Name = "Marca";
            dataProductos.Columns[6].Name = "Categoría";
            dataProductos.Rows.Clear();
            foreach (Producto c in result) {
                dataProductos.Rows.Add(
                    c,
                    c.codigo,
                    c.nombre,
                    c.descripcion,
                    c.precio,
                    c.marca.nombre,
                    c.categoria.nombre
                );
            }
        }
        public static void fillDataGridMarcas(DataGridView dataMarcas, List<Marca> result)
        {
            dataMarcas.ColumnCount = 2;
            dataMarcas.Columns[0].Visible = false;
            dataMarcas.Columns[1].Name = "Nombre";
            dataMarcas.Rows.Clear();
            foreach (Marca c in result)
            {
                dataMarcas.Rows.Add(
                    c,
                    c.nombre
                );
            }
        }
        public static void fillDataGridIngresoStock(DataGridView dataStock, List<Stock> result) {
            dataStock.ColumnCount = 5;
            dataStock.Columns[0].Visible = false;
            dataStock.Columns[1].Name = "Adicionar stock";
            dataStock.Columns[1].CellTemplate.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            dataStock.Columns[2].Name = "Stock actual";
            dataStock.Columns[2].ReadOnly = true;
            dataStock.Columns[3].Name = "Producto";
            dataStock.Columns[3].ReadOnly = true;
            dataStock.Columns[4].Name = "Sucursal";
            dataStock.Columns[4].ReadOnly = true;
            dataStock.Columns[4].Width = 200;
            dataStock.Rows.Clear();
            foreach (Stock s in result) {
                dataStock.Rows.Add(
                    s,
                    "0",
                    s.stock,
                    s.producto_codigo,
                    s.sucursal.direccion
                );
            }
        }
        public static void fillTreeViewCategorias(TreeView dataCategorias, List<Categoria> result) {
            dataCategorias.Nodes.Clear();    // Clear any existing items
            dataCategorias.BeginUpdate();    // prevent overhead and flicker

            TreeNode root = dataCategorias.Nodes.Add( "---" );
            root.Tag = new Categoria(0);
            root.Expand();
            Dictionary<short, TreeNode> nodes = new Dictionary<short, TreeNode>();

            //asume fathers first
            foreach (Categoria cat in result) {
                TreeNode node = (cat.categoria_padre == null ? root: nodes[(short)cat.categoria_padre]).Nodes.Add(cat.nombre);
                node.Tag = cat;
                nodes.Add(cat.id, node);
            }

            dataCategorias.EndUpdate();
            dataCategorias.Refresh(); 
        }

        public static void fillDataGridFacturas(DataGridView dataFacturas, List<Factura> result) {
            dataFacturas.ColumnCount = 6;
            dataFacturas.Columns[0].Visible = false;
            dataFacturas.Columns[1].Name = "Número";
            dataFacturas.Columns[2].Name = "Total";
            dataFacturas.Columns[2].DefaultCellStyle.Format = "#,##0.00";
            dataFacturas.Columns[3].Name = "Cuotas";
            dataFacturas.Columns[3].DefaultCellStyle.Format = "#,##0.00";
            dataFacturas.Columns[4].Name = "Cuotas por pagar";
            dataFacturas.Columns[5].Name = "Fecha";
            dataFacturas.Columns[5].Width = 160;
            dataFacturas.Rows.Clear();
            foreach (Factura f in result) {
                dataFacturas.Rows.Add(
                    f,
                    f.numero,
                    f.totalConDesctuento,
                    f.valorCuota,
                    f.cuotasPorPagar,
                    f.fecha
                );
            }
        }
    }
}
