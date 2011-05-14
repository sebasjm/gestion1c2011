using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VentaElectrodomesticos.Controladores {
    class RolDAO {
        private Connection connection;
        public RolDAO(Connection connection)
        {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Rol), new RolMapper());
        }
        public List<Rol> getRoles([Optional, DefaultParameterValue(-1)] int rol_id, [Optional, DefaultParameterValue("")] string nombre )
        {
            string rol = (rol_id >= 0) ? " AND id = " + rol_id : "";
            List<Rol> rolList = connection.query<Rol>(
                    "SELECT * FROM la_huerta.rol WHERE LOWER(nombre) like LOWER('%{0}%') " + rol , nombre);
             return rolList ;
        }
        class RolMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Rol(sdr.GetByte(0)) {
                    nombre = sdr.GetString(1),
                    descripcion = sdr.GetString(2)
                };
            }
        }
        public void delete(Rol _rol)
        {
            List<Campo> campos = new List<Campo>();
            campos.Add(new Campo("activo", (int)0));
            QueryBuilder q = new QueryBuilder();
            q.update("la_huerta.rol")
                .valores_update(campos)
                .filterIf(_rol.id != 0, "id = {0}", _rol.id);
            connection.query<Rol>(q.build(), q.getParams());
        }
    }
}
