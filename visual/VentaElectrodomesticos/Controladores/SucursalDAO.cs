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
        public List<Sucursal> getSucursales(long provincia_id)
        {
            string provincia = (provincia_id >= 0) ? " WHERE provincia_id = " + provincia_id : "";
            List<Sucursal> sucursalList = connection.query<Sucursal>(
                    "SELECT * FROM la_huerta.sucursal" + provincia);
            return sucursalList ;
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
