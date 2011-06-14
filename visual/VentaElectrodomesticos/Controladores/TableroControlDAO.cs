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
            Context.instance.dao.addMapper(typeof(MejorCategoria), new MejorCategoriaMapper());
        }
        class MayorDeudorMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new MayorDeudor(
                        sdr.IsDBNull(0) ? 0 : sdr.GetInt32(0),
                        sdr.IsDBNull(1) ? "" : sdr.GetString(1),
                        sdr.IsDBNull(2) ? "" : sdr.GetString(2)
                    );
            }
        }
        class MejorProductoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new MejorProducto(
                        sdr.IsDBNull(0) ? 0 : sdr.GetInt32(0),
                        sdr.IsDBNull(1) ? "" : sdr.GetString(1),
                        sdr.IsDBNull(2) ? "" : sdr.GetString(2)
                    );
            }
        }
        class MejorVendedorMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new MejorVendedor(
                        sdr.IsDBNull(0) ? 0 : sdr.GetInt32(0),
                        sdr.IsDBNull(1) ? "" : sdr.GetString(1),
                        sdr.IsDBNull(2) ? "" : sdr.GetString(2)
                    );
            }
        }
        class ProporcionFormasDePagoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new ProporcionFormasDePago(
                        sdr.IsDBNull(0) ? 0 : sdr.GetDouble(0)
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
        class MejorCategoriaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return sdr.HasRows ? new MejorCategoria(
                        sdr.IsDBNull(0) ? "" : sdr.GetString(0),
                        sdr.IsDBNull(1) ? 0 :sdr.GetInt32(1),
                        sdr.IsDBNull(2) ? 0d : sdr.GetDouble(2),
                        sdr.IsDBNull(3) ? "" : sdr.GetString(3),
                        sdr.IsDBNull(4) ? "" : sdr.GetString(4),
                        sdr.IsDBNull(5) ? "" : sdr.GetString(5),
                        sdr.IsDBNull(6) ? "" : sdr.GetString(6)
                    ) : null;
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
        public List<MejorCategoria> mejoresCategorias(int sucursal_id, string anio) {
            return connection.query<MejorCategoria>(PREMIUM_MEJORES_CATEGORIAS, sucursal_id, anio);
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
            "FROM EL_GRUPO.Factura AS f " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO;

        private static readonly String TABLERO_TOTAL_FACTURADO =
            "SELECT sum( (total)*(1-descuento) ) " +
            "FROM EL_GRUPO.Factura AS f " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO;

        private static readonly String TABLERO_MAYOR_FACTURA =
            "SELECT max(total*(1-descuento)) " +
            "FROM EL_GRUPO.Factura AS f " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO;

        private static readonly String CANTIDAD_PAGOS_CLIENTE =
            "SELECT sum(cuotas) " +
            "FROM EL_GRUPO.Pago " +
            "WHERE factura_numero = f.numero AND " +
            FILTRO_ANIO +
            "GROUP BY factura_numero ";

        private static readonly String TABLERO_MAYOR_DEUDOR =
            "SELECT TOP 1 c.dni, c.nombre, c.apellido " +
            "FROM EL_GRUPO.Factura AS f " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            "JOIN EL_GRUPO.Cliente AS c ON c.dni = f.cliente_dni " +
            FILTRO_SUCURSAL_ANIO +
            "ORDER BY f.total*(1-f.descuento)*(1- ( CASE WHEN f.cuotas = 0 THEN 0 ELSE (" + CANTIDAD_PAGOS_CLIENTE + ")/f.cuotas END )) DESC ";

        private static readonly String TABLERO_MEJOR_VENDEDOR =
            "SELECT TOP 1 e.dni, e.nombre, e.apellido " +
            "FROM EL_GRUPO.Factura AS f " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_SUCURSAL_ANIO +
            "GROUP BY e.dni, e.nombre, e.apellido " +
            "ORDER BY sum(total*(1-descuento)) DESC ";

        private static readonly String TABLERO_MEJOR_PRODUCTO =
            "SELECT TOP 1 p.codigo, p.nombre, EL_GRUPO.get_categoria_fullname( p.categoria_id )" +
            "FROM EL_GRUPO.ItemFactura AS itf " +
            "JOIN EL_GRUPO.Factura AS f ON f.numero = itf.factura_numero " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            "JOIN EL_GRUPO.Producto AS p ON p.codigo = itf.producto_codigo " +
            FILTRO_SUCURSAL_ANIO +
            "GROUP BY p.codigo, p.nombre, p.categoria_id " +
            "ORDER BY sum(cantidad) DESC ";

        private static readonly String TABLERO_PROPORCIONAL_FORMA_DE_PAGO =
            " SELECT convert( float, sum( CASE cuotas WHEN 1 THEN 1 ELSE 0 END ) ) / convert( float, count(*) ) " +
             "FROM EL_GRUPO.Factura AS f " +
             "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
             FILTRO_SUCURSAL_ANIO;

        private static readonly String TABLERO_FALTANTE_STOCK =
            "EL_GRUPO.dias_sin_stock";

        private static readonly String PREMIUM_MEJORES_CLIENTES =
            "SELECT TOP 30 c.dni, c.nombre, c.apellido, sum(total*(1-descuento)), sum(itf.cantidad), max(f.fecha), (select top 1 empleado_dni from EL_GRUPO.Factura where numero = max(f.numero) ) " +
            "FROM EL_GRUPO.Factura AS f " +
            "JOIN EL_GRUPO.Cliente AS c ON c.dni = f.cliente_dni " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            "JOIN EL_GRUPO.ItemFactura AS itf ON itf.factura_numero = f.numero " +
            FILTRO_SUCURSAL_ANIO +
            "GROUP BY c.dni, c.nombre, c.apellido " +
            "ORDER BY sum(total*(1-descuento)) DESC ";

        private static readonly String CATEGORIA_CANT_SUBCATEGORIAS =
            "SELECT count(*) " +
            "FROM EL_GRUPO.Categoria " +
            "WHERE c.id <> id AND c.id = EL_GRUPO.categoria_root(id) ";

        private static readonly String FILTRO_CATEGORIA =
            FILTRO_SUCURSAL_ANIO +
            " AND EL_GRUPO.categoria_root(p.categoria_id) = c.id ";

        private static readonly String CATEGORIA_MONTO =
            "SELECT sum( itf.producto_precio*itf.cantidad*(1-f.descuento) ) " +
            "FROM EL_GRUPO.ItemFactura AS itf " +
            "join EL_GRUPO.Producto as p on p.codigo = itf.producto_codigo " +
            "join EL_GRUPO.Factura as f on f.numero = itf.factura_numero " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_CATEGORIA;

        private static readonly String CATEGORIA_PROD_MAS_VENDIDO =
            "SELECT TOP 1 convert(varchar(50),itf.producto_codigo)+' -- '+p.nombre " +
            "FROM EL_GRUPO.ItemFactura AS itf " +
            "join EL_GRUPO.Producto as p on p.codigo = itf.producto_codigo " +
            "join EL_GRUPO.Factura as f on f.numero = itf.factura_numero " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni " +
            FILTRO_CATEGORIA +
            "GROUP BY itf.producto_codigo,p.nombre "+
            "ORDER BY sum(itf.cantidad) DESC";

        private static readonly String CATEGORIA_PROD_MAS_FACTURADO =
            "SELECT TOP 1 convert(varchar(50),itf.producto_codigo)+' -- '+p.nombre+' -- $'+convert(varchar(50),sum( itf.producto_precio*itf.cantidad*(1-f.descuento) )) " +
            "FROM EL_GRUPO.ItemFactura AS itf " + 
            "join EL_GRUPO.Producto as p on p.codigo = itf.producto_codigo " +
            "join EL_GRUPO.Factura as f on f.numero = itf.factura_numero " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni  " +
            FILTRO_CATEGORIA +
            "GROUP BY itf.producto_codigo,p.nombre " +
            "ORDER BY sum( itf.producto_precio*itf.cantidad*(1-f.descuento) ) DESC";

        private static readonly String CATEGORIA_PROD_MAS_CARO =
            "SELECT TOP 1 convert(varchar(50),itf.producto_codigo) + ' -- ' +p.nombre + ' -- $'+ convert(varchar(50),itf.producto_precio*itf.cantidad*(1-f.descuento)) " +
            "FROM EL_GRUPO.ItemFactura AS itf  " +
            "join EL_GRUPO.Producto as p on p.codigo = itf.producto_codigo " +
            "join EL_GRUPO.Factura as f on f.numero = itf.factura_numero " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni  " +
            FILTRO_CATEGORIA +
            "ORDER BY itf.producto_precio*itf.cantidad*(1-f.descuento) DESC";

        private static readonly String CATEGORIA_MEJOR_VENEDOR =
            "SELECT TOP 1 e.apellido + ', ' + e.nombre " +
            "FROM EL_GRUPO.ItemFactura AS itf  " +
            "join EL_GRUPO.Producto as p on p.codigo = itf.producto_codigo " +
            "join EL_GRUPO.Factura as f on f.numero = itf.factura_numero " +
            "JOIN EL_GRUPO.Empleado AS e ON e.dni = f.empleado_dni  " +
            FILTRO_CATEGORIA +
            "GROUP BY e.dni, e.nombre, e.apellido " +
            "ORDER BY sum(itf.cantidad) DESC, e.dni ";

        private static readonly String PREMIUM_MEJORES_CATEGORIAS =
            "SELECT c.nombre, " +
            "(" + CATEGORIA_CANT_SUBCATEGORIAS + ") as sub_cats, " +
            "(" + CATEGORIA_MONTO + ") as monto, " +
            "(" + CATEGORIA_PROD_MAS_VENDIDO + ") as prod_mas_vendido," +
            "(" + CATEGORIA_PROD_MAS_FACTURADO + ") as prod_mas_facturado, " +
            "(" + CATEGORIA_PROD_MAS_CARO + ") as prod_mas_caro, " +
            "(" + CATEGORIA_MEJOR_VENEDOR + ") as mejor_vendedor " +
            "FROM EL_GRUPO.Categoria AS c " +
            "WHERE categoria_padre IS NULL " + 
            "ORDER BY ("+CATEGORIA_MONTO+") DESC";


    }
}
