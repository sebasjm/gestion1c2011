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
                return new Sucursal( sdr.GetByte(0) ) {
                    direccion = sdr.GetString(1),
                    telefono = sdr.GetString(2),
                    tipoSucursalId = sdr.GetByte(3),
                    provinciaId = sdr.GetByte(4)
                };
            }
        }
        private List<Sucursal> cache = null;
        public List<Sucursal> load() {
            if (cache == null) {
                QueryBuilder q = new QueryBuilder();
                q.select().from("EL_GRUPO.Sucursal");
                cache = connection.query<Sucursal>(q.build(), q.getParams());
            }
            return new List<Sucursal>( cache );
        }
        public Sucursal findById(byte id) {
            if (cache == null)
                load();
            return cache.Find(
                delegate(Sucursal suc) {
                    return suc.id == id;
                }
            );
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
