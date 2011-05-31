using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
namespace VentaElectrodomesticos.Controladores {
    class StockDAO {
        private Connection connection;
        public StockDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Stock), new StockMapper());
        }
        class StockMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Stock(sdr.GetByte(0), sdr.GetInt32(1)) {
                    stock = sdr.GetInt32(2)
                };
            }
        }
        public List<Stock> search(Sucursal sucursal, Producto producto) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Stock")
                .filterIf(sucursal != null && sucursal.id != 0, "sucursal_id = {0} ", sucursal != null ? sucursal.id : 0)
                .filterIf(producto != null && producto.codigo != 0, "producto_codigo = {1} ", producto != null ? producto.codigo : 0);

            return connection.query<Stock>(q.build(), q.getParams());
        }

        private static readonly String INSERT_INGRESO_STOCK = "INSERT INTO la_huerta.IngresoStock VALUES({0},{1},{2}, getdate() ,{3})";
        private static readonly String UPDATE_ADD_STOCK = "UPDATE la_huerta.Stock SET stock = stock + {0} WHERE sucursal_id = {1} and producto_codigo = {2}";

        public void add(Stock stock, Empleado auditor, int cant) {
            connection.update(INSERT_INGRESO_STOCK, stock.sucursal_id, stock.producto_codigo, auditor.dni, cant);
            connection.update(UPDATE_ADD_STOCK, cant, stock.sucursal_id, stock.producto_codigo);
        }
    }
}
