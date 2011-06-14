using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace VentaElectrodomesticos.Controladores {
    class TipoEmpleadoDAO {
        private Connection connection;
        public TipoEmpleadoDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(TipoEmpleado), new TipoEmpleadoMapper());
        }
        private List<TipoEmpleado> cache = null;
        public List<TipoEmpleado> load() {
            if (cache == null) {
                QueryBuilder q = new QueryBuilder();
                q.select().from("EL_GRUPO.TipoEmpleado");
                cache = connection.query<TipoEmpleado>(q.build(), q.getParams());
            }
            return new List<TipoEmpleado>( cache );
        }
        public TipoEmpleado findById(Byte id) {
            if (cache == null)
                load();
            return cache.Find(
                delegate(TipoEmpleado tipo) {
                    return tipo.id == id;
                }
            );
        }
        class TipoEmpleadoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new TipoEmpleado( sdr.GetByte(0) )  {
                    nombre = sdr.GetString(1)
                };
            }
        }
    }
}
