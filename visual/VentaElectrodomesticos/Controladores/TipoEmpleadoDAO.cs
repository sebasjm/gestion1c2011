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
        public List<TipoEmpleado> getTipoEmpleadoes(long provincia_id)
        {
            string provincia = (provincia_id >= 0) ? " WHERE provincia_id = " + provincia_id : "";
            List<TipoEmpleado> TipoEmpleadoList = connection.query<TipoEmpleado>(
                    "SELECT * FROM la_huerta.TipoEmpleado" + provincia);
            return TipoEmpleadoList ;
        }
        class TipoEmpleadoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                //MessageBox.Show("ID : " + sdr.GetValue(0) + "NOMBRE :" + sdr.GetValue(1));
                // TODO : Ver porque tipo empleado tiene un espacio en la primary
                return new TipoEmpleado( (Byte) sdr.GetValue(0) )  {
                    nombre = (String)sdr.GetValue(1)
                };
            }
        }

    }

}
