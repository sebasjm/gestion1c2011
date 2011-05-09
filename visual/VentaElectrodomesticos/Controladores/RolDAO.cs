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
    }
}
