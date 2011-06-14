using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VentaElectrodomesticos.Controladores;
namespace VentaElectrodomesticos.Controladores {
    class FuncionalidadDAO {
        private Connection connection;
        public FuncionalidadDAO(Connection connection)
        {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Funcionalidad), new FuncionalidadMapper());
        }
        public List<Funcionalidad> search(string nombre)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("EL_GRUPO.funcionalidad")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre);
            return connection.query<Funcionalidad>(q.build(), q.getParams());
        }

        public Funcionalidad findByNombre(string nombre)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("EL_GRUPO.funcionalidad")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre);
          List<Funcionalidad> funcionalidads = connection.query<Funcionalidad>(q.build(), q.getParams());
          if (funcionalidads.Count == 0)
              return null;
            return funcionalidads[0];
        }
        private List<Funcionalidad> cache = null;
        public List<Funcionalidad> load()
        {
            if (cache == null)
            {
                QueryBuilder q = new QueryBuilder();
                q.select().from("EL_GRUPO.Funcionalidad");
                cache = connection.query<Funcionalidad>(q.build(), q.getParams());
            }
            return cache;
        }
        class FuncionalidadMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Funcionalidad (sdr.GetByte(0)){
                    nombre = sdr.GetString(1),
                    descripcion = sdr.GetString(2)
                };
            }
        }
    }
}
