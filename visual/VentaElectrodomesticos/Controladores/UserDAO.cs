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
        public void insertar(Usuario usuario)
        {
            List<String> valores = new List<String>();
            List<String> columnas = new List<String>();

            columnas.Add("username");
            columnas.Add("password");

            valores.Add(usuario.username);
            valores.Add(usuario.password);

            QueryBuilder q = new QueryBuilder();
            q.insert("la_huerta.usuario")
            
                .columns(columnas)
                .values(valores);

            connection.query<Usuario>(q.build(), q.getParams());
        }
        public List<Usuario> search(string username)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.usuario")
                .filterIf(username.Length != 0, "username like '%{0}%' ", username);
            return connection.query<Usuario>(q.build(), q.getParams());
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

