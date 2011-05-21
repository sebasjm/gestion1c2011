using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
namespace VentaElectrodomesticos.Controladores {
    class UserDAO {
        private Connection connection;
        // Clase para manejar passwords
        Security sec = new Security();

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
        public List<Usuario> search(string username)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.usuario")
                .filterIf(username.Length != 0, "username like '%{0}%' ", username)
                .filterIf(true, "activo = {1} ", 1); ;
            return connection.query<Usuario>(q.build(), q.getParams());
        }
        public Usuario searchById(int id)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.usuario")
                .filterIf(id != 0, "id = {0}", id);
            List<Usuario> us = connection.query<Usuario>(q.build(), q.getParams());
            return us[0];
        }
        public Usuario findUserWithPassword(string user, string passwd) {
            List<Usuario> found = connection.query<Usuario>(
                "SELECT * FROM la_huerta.Usuario WHERE username = '{0}' and password = '{1}'",
                user,
                passwd
            );
            return found.Count == 1 ? found.First() : null;
        }
        //CRUD
        public void insertar(Usuario usuario)
        {
            QueryBuilder q = new QueryBuilder();
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void modificar(Usuario usuario)
        {
            QueryBuilder q = new QueryBuilder();
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void delete(Usuario usuario)
        {
            QueryBuilder q = new QueryBuilder();
            connection.query<Usuario>(q.build(), q.getParams());
        }
    }
}

