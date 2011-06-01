using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo.Tablero;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.Controladores {
    class TableroControlDAO {
        private Connection connection;
        public TableroControlDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(MayorDeudor), new MayorDeudorMapper());
            Context.instance.dao.addMapper(typeof(MejorProducto), new MejorProductoMapper());
            Context.instance.dao.addMapper(typeof(MejorVendedor), new MejorVendedorMapper());
            Context.instance.dao.addMapper(typeof(ProporcionFormasDePago), new ProporcionFormasDePagoMapper());
        }
        class MayorDeudorMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new MayorDeudor(
                        sdr.GetInt32(0),
                        sdr.GetString(1),
                        sdr.GetString(2)
                    );
            }
        }
        class MejorProductoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new MejorProducto(
                        sdr.GetInt32(0),
                        sdr.GetString(1),
                        sdr.GetString(2)
                    );
            }
        }
        class MejorVendedorMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new MejorVendedor(
                        sdr.GetInt32(0),
                        sdr.GetString(1),
                        sdr.GetString(2)
                    );
            }
        }
        class ProporcionFormasDePagoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new ProporcionFormasDePago(
                        sdr.GetDouble(0)
                    );
            }
        }


    private static readonly String FILTRO_ANIO =
	    "fecha BETWEEN " +
		"CAST({1}+'-01-01 00:00:00.0' AS datetime) " +
	    "AND " +
		"CAST({1}+'-12-31 23:59:59.9' AS datetime) ";

    private static readonly String FILTRO_SUCURSAL_ANIO =
        "WHERE " +
        "e.sucursal_id = {0} AND " +
        FILTRO_ANIO;

    private static readonly String CANTIDAD_VENTAS = 
        "SELECT count(*) " +
        "FROM la_huerta.Factura AS f " +
        "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
        FILTRO_SUCURSAL_ANIO;

    private static readonly String TOTAL_FACTURADO =
        "SELECT sum( (total)*(1-descuento) ) " +
        "FROM la_huerta.Factura AS f " +
        "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni" +
        FILTRO_SUCURSAL_ANIO;

    private static readonly String MAYOR_FACTURA =
        "SELECT max(total)" +
        "FROM la_huerta.Factura AS f" +
        "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni" +
        FILTRO_SUCURSAL_ANIO;

    private static readonly String CANTIDAD_PAGOS_CLIENTE =
        "SELECT sum(cuotas) "+
        "FROM la_huerta.Pago "+
        "WHERE factura_numero = f.numero AND " +
        FILTRO_ANIO +
        "GROUP BY factura_numero";

    private static readonly String MAYOR_DEUDOR =
        "SELECT TOP 1 c.dni, c.nombre, c.apellido " +
        "FROM la_huerta.Factura AS f " +
        "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
        "JOIN la_huerta.Cliente AS c ON c.dni = f.cliente_dni " +
        FILTRO_SUCURSAL_ANIO +
        "ORDER BY ((f.total*(1-f.descuento))/f.cuotas)*(f.cuotas-(" + CANTIDAD_PAGOS_CLIENTE + ")) DESC";

    private static readonly String MEJOR_VENDEDOR =
        "SELECT TOP 1 e.dni, e.nombre, e.apellido "+
        "FROM la_huerta.Factura AS f "+
        "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni"+
        FILTRO_SUCURSAL_ANIO +
        "GROUP BY e.dni, e.nombre, e.apellido "+
        "ORDER BY sum(total*(1-descuento)) DESC ";

    private static readonly String MEJOR_PRODUCTO =
        "SELECT TOP 1 p.codigo, p.nombre, p.categoria_id "+
        "FROM la_huerta.ItemFactura AS itf "+
        "JOIN la_huerta.Factura AS f ON f.numero = itf.factura_numero "+
        "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni "+
        "JOIN la_huerta.Producto AS p ON p.codigo = itf.producto_codigo "+
        FILTRO_SUCURSAL_ANIO +
        "GROUP BY p.codigo, p.nombre, p.categoria_id "+
        "ORDER BY sum(cantidad) DESC ";

    }
}
