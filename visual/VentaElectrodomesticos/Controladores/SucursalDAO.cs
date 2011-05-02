using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.Controladores {
    class SucursalDAO {
        private Connection connection;
        public SucursalDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Sucursal), new SucursalMapper());
        }

        class SucursalMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Sucursal( (int)sdr.GetValue(0) ) {
                    direccion = (string)sdr.GetValue(1),
                    telefono = (string)sdr.GetValue(2),
                    tipoSucursalId = (Byte)sdr.GetValue(3),
                    provinciaId = (Byte)sdr.GetValue(4)
                };
            }
        }

        private List<Sucursal> cache = null;

        public List<Sucursal> load() {
            if (cache == null) {
                QueryBuilder q = new QueryBuilder();
                q.select().from("la_huerta.Sucursal");
                cache = connection.query<Sucursal>(q.build(), q.getParams());
            }
            return cache;
        }

        public Sucursal findByProvincia(byte id) {
            if (cache == null)
                load();

            return cache.Find(
                delegate(Sucursal suc) {
                    return suc.provinciaId == id;
                }
            );
        }
    }

}
