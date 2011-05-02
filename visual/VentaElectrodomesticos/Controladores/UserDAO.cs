using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.Controladores {
    class UserDAO {

        private Connection connection;

        public UserDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Usuario), new UserMapper());
        }

        class UserMapper: Mapper<Object> {

            public Object getInstance(SqlDataReader sdr) {
                return new Usuario((int)sdr.GetValue(0)) {
                    username = (string)sdr.GetValue(1),
                    password = (string)sdr.GetValue(2)
                };
            }
        }

        public Usuario findUserWithPassword(string user, string passwd) {
            List<Usuario> found = connection.query<Usuario>(
                "SELECT * FROM la_huerta.Usuario WHERE username = '{0}' and password = '{1}'",
                user,
                passwd
            );
            return found.Count == 1 ? found.First() : null;
        }


    }

}
