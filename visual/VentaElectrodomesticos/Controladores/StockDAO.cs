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
                return new Stock
                {
                    sucursal_id = (Byte)sdr.GetValue(0),
                    producto_codigo = (Byte)sdr.GetValue(1),
                    stock = (Byte)sdr.GetValue(2)
                };
            }
        }

           }

}
