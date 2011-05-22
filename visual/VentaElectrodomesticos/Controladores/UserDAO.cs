using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;
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
        private static readonly String INSERT = "INSERT INTO la_huerta.Usuario VALUES( {0} , '{1}' , 1 )";
        private static readonly String UPDATE = "UPDATE la_huerta.Usuario SET username={0},password='{1}',activo=1";
        private static readonly String DELETE = "UPDATE la_huerta.Usuario SET activo=0 WHERE id={0}";

        public void insertar(Usuario usuario)
        {
            connection.update(
                INSERT,
                    usuario.username,
                    sec.sha256encrypt(usuario.password)
                    );
        }
        public void modificar(Usuario usuario)
        {
            connection.update(
                UPDATE,
                    usuario.username,
                    sec.sha256encrypt(usuario.password)
            );
        }
        public void eliminar(int id)
        {
            connection.update(
                DELETE,
                id
            );
        }
    }
}

