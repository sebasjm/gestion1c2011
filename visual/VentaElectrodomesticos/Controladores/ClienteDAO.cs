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
        public List<Cliente> search(string nombre, string apellido, int dni) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Cliente")
                .filterIf(nombre != null && nombre.Length != 0, " nombre like '%{0}%'", nombre)
                .filterIf(apellido != null && apellido.Length != 0, " apellido like '%{1}%'", apellido)
                .filterIf(dni != 0, " dni = {2}", dni);

            return connection.query<Cliente>( q.build(), q.getParams() );
        }


        class ClienteMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Cliente((Int32)sdr.GetValue(0)) {
                    nombre = (String)sdr.GetValue(1),
                    apellido = (String)sdr.GetValue(2),
                    mail = (String)sdr.GetValue(3)
                };
            }
        }
    }
}
