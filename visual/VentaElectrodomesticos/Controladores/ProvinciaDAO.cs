using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.Controladores {
    class ProvinciaDAO {
        private Connection connection;
        public ProvinciaDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Provincia), new ProvinciaMapper());
        }
        public List<Provincia> getProvincias()
        {
            List<Provincia> ProvinciaList = connection.query<Provincia>(
                    "SELECT * FROM la_huerta.Provincia");
            return ProvinciaList ;
        }
        class ProvinciaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                //MessageBox.Show("ID : " + sdr.GetValue(0) + "NOMBRE :" + sdr.GetValue(1));
                // TODO : Ver porque Provincia tiene un espacio en la primary
                String cadena = (string)sdr.GetValue(0).ToString();
                cadena.Trim(' ');
                return new Provincia {
                    id = (int)Int32.Parse(cadena),
                    nombre = (string)sdr.GetValue(1)
                };
            }
        }

    }

}
