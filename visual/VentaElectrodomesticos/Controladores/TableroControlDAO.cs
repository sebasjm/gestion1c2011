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
            Context.instance.dao.addMapper(typeof(ClientePremium), new ClientePremiumMapper());
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
        class ClientePremiumMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new ClientePremium(
                        sdr.GetInt32(0),
                        sdr.GetString(1),
                        sdr.GetString(2),
                        sdr.GetDouble(3),
                        sdr.GetInt32(4),
                        sdr.GetDateTime(5),
                        sdr.GetInt32(6)
                    );
            }
        }

        public int calcularTotalVentas(int sucursal_id, string anio) {
            return connection.find<int>(TABLERO_CANTIDAD_VENTAS, sucursal_id, anio);
        }
        public Double? calcularTotalFacturacion(int sucursal_id, string anio) {
            return connection.find<Double?>(TABLERO_TOTAL_FACTURADO, sucursal_id, anio);
        }
        public ProporcionFormasDePago calcularProporcionFormasDePago(int sucursal_id, string anio) {
            return connection.find<ProporcionFormasDePago>(TABLERO_PROPORCIONAL_FORMA_DE_PAGO, sucursal_id, anio);
        }
        public Double? calcularMayorFactura(int sucursal_id, string anio) {
            return connection.find<Double?>(TABLERO_MAYOR_FACTURA, sucursal_id, anio);
        }
        public MayorDeudor calcularMayorDeudor(int sucursal_id, string anio) {
            return connection.find<MayorDeudor>(TABLERO_MAYOR_DEUDOR, sucursal_id, anio);
        }
        public MejorVendedor calcularMejorVendedor(int sucursal_id, string anio) {
            MejorVendedor v;
            return (v = connection.find<MejorVendedor>(TABLERO_MEJOR_VENDEDOR, sucursal_id, anio)) == null ? new NullMejorVendedor() : v;
        }
        public MejorProducto calcularMejorProducto(int sucursal_id, string anio) {
            return connection.find<MejorProducto>(TABLERO_MEJOR_PRODUCTO, sucursal_id, anio);
        }
        public List<ClientePremium> mejoresClientes(int sucursal_id, string anio) {
            return connection.query<ClientePremium>(PREMIUM_MEJORES_CLIENTES, sucursal_id, anio);
        }

        public FaltanteStock calcularFaltanteStock(int sucursal_id, string anio) {
            SqlParameter param_prod = new SqlParameter("@out_prod", System.Data.SqlDbType.Int);
            SqlParameter param_dias = new SqlParameter("@out_dias", System.Data.SqlDbType.Int);

            param_prod.Direction = System.Data.ParameterDirection.Output;
            param_dias.Direction = System.Data.ParameterDirection.Output;
            param_prod.Value = 0;

            List<SqlParameter> param_set = new List<SqlParameter>() {
                    new SqlParameter("@suc", sucursal_id),
                    new SqlParameter("@anio", anio),
                    param_prod,
                    param_dias
                };

            connection.procedure(TABLERO_FALTANTE_STOCK, param_set);

            return (int)param_prod.Value == 0 ? new NullFaltanteStock() : new FaltanteStock((int)param_prod.Value, (int)param_dias.Value);
        }

        private static readonly String FILTRO_ANIO =
            "fecha BETWEEN " +
            "CAST('{1}'+'-01-01 00:00:00.0' AS datetime) " +
            "AND " +
            "CAST('{1}'+'-12-31 23:59:59.9' AS datetime) ";

        private static readonly String FILTRO_SUCURSAL_ANIO =
            "WHERE " +
            "e.sucursal_id = {0} AND " +
            FILTRO_ANIO;

        private static readonly String TABLERO_CANTIDAD_VENTAS =
            "SELECT count(*) " +
            "FROM la_huerta.Factura AS f " +
            "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO;

        private static readonly String TABLERO_TOTAL_FACTURADO =
            "SELECT sum( (total)*(1-descuento) ) " +
            "FROM la_huerta.Factura AS f " +
            "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO;

        private static readonly String TABLERO_MAYOR_FACTURA =
            "SELECT max(total) " +
            "FROM la_huerta.Factura AS f " +
            "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO;

        private static readonly String CANTIDAD_PAGOS_CLIENTE =
            "SELECT sum(cuotas) " +
            "FROM la_huerta.Pago " +
            "WHERE factura_numero = f.numero AND " +
            FILTRO_ANIO +
            "GROUP BY factura_numero ";

        private static readonly String TABLERO_MAYOR_DEUDOR =
            "SELECT TOP 1 c.dni, c.nombre, c.apellido " +
            "FROM la_huerta.Factura AS f " +
            "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
            "JOIN la_huerta.Cliente AS c ON c.dni = f.cliente_dni " +
            FILTRO_SUCURSAL_ANIO +
            "ORDER BY f.total*(1-f.descuento)*(1- ( CASE WHEN f.cuotas = 0 THEN 0 ELSE (" + CANTIDAD_PAGOS_CLIENTE + ")/f.cuotas END )) DESC ";

        private static readonly String TABLERO_MEJOR_VENDEDOR =
            "SELECT TOP 1 e.dni, e.nombre, e.apellido " +
            "FROM la_huerta.Factura AS f " +
            "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO +
            "GROUP BY e.dni, e.nombre, e.apellido " +
            "ORDER BY sum(total*(1-descuento)) DESC ";

        private static readonly String TABLERO_MEJOR_PRODUCTO =
            "SELECT TOP 1 p.codigo, p.nombre, la_huerta.get_categoria_fullname( p.categoria_id )" +
            "FROM la_huerta.ItemFactura AS itf " +
            "JOIN la_huerta.Factura AS f ON f.numero = itf.factura_numero " +
            "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
            "JOIN la_huerta.Producto AS p ON p.codigo = itf.producto_codigo " +
            FILTRO_SUCURSAL_ANIO +
            "GROUP BY p.codigo, p.nombre, p.categoria_id " +
            "ORDER BY sum(cantidad) DESC ";

        private static readonly String TABLERO_PROPORCIONAL_FORMA_DE_PAGO =
            "";
        private static readonly String TABLERO_FALTANTE_STOCK =
            "la_huerta.dias_sin_stock";

        private static readonly String PREMIUM_MEJORES_CLIENTES =
            "SELECT TOP 30 c.dni, c.nombre, c.apellido, sum(total*(1-descuento)), sum(itf.cantidad), max(f.fecha), (select top 1 empleado_dni from la_huerta.Factura where numero = max(f.numero) ) " +
            "FROM la_huerta.Factura AS f " +
            "JOIN la_huerta.Cliente AS c ON c.dni = f.cliente_dni " +
            "JOIN la_huerta.Empleado AS e ON e.dni = f.empleado_dni " +
            "JOIN la_huerta.ItemFactura AS itf ON itf.factura_numero = f.numero " +
            FILTRO_SUCURSAL_ANIO +
            "GROUP BY c.dni, c.nombre, c.apellido " +
            "ORDER BY sum(total*(1-descuento)) DESC ";


    }
}
