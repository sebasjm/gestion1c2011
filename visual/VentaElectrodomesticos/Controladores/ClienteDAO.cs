using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace VentaElectrodomesticos.Controladores {
    class ClienteDAO {
        private Connection connection;
        public ClienteDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Cliente), new ClienteMapper());
        }
        public List<Cliente> getClientes(string nombre, string apellido, int dni)
        {
            String strDNI = (dni >= 0) ? strDNI = " AND dni=" + dni : "";
            List<Cliente> clientes = connection.query<Cliente>(
                "SELECT * FROM la_huerta.cliente WHERE " +
                " LOWER(nombre) like  LOWER('%{0}%') AND" +
                " LOWER(apellido) like  LOWER('%{1}%')" +
                strDNI,
                nombre,
                apellido
            );
            return clientes;
        }
        class ClienteMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Cliente {
                    dni = (int)sdr.GetValue(0),
                    nombre = (string)sdr.GetValue(1),
                    apellido = (string)sdr.GetValue(2),
                    mail = (string)sdr.GetValue(3)
                };
            }
        }
    }
}
