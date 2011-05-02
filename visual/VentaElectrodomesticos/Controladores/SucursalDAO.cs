using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.Controladores {
    class SucursalDAO {
        private Connection connection;
        public SucursalDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Sucursal), new SucursalMapper());
        }
        public List<Sucursal> search(long provincia_id) {
            QueryBuilder q = new QueryBuilder();

            q.select()
                .from("la_huerta.Sucursal")
                .filterIf( true, " provincia_id = {0}", provincia_id);
            
            return connection.query<Sucursal>(q.build(), q.getParams());
        }

        class SucursalMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Sucursal( (int)sdr.GetValue(0) ) {
                    direccion = (string)sdr.GetValue(1)
                };
            }
        }

    }

}
