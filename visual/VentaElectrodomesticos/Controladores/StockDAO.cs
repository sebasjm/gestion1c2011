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
    }
}
