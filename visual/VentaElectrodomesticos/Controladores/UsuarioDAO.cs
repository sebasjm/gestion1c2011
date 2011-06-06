﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using VentaElectrodomesticos.Controladores;
using System.Data.SqlClient;
namespace VentaElectrodomesticos.Controladores {
    class UsuarioDAO {
        private Connection connection;
        // Clase para manejar passwords
        Security sec = new Security();
        public UsuarioDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Usuario), new UserMapper());
        }
        class UserMapper: Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Usuario((int)sdr.GetValue(0)) {
                    username = sdr.GetString(1),
                    password = sdr.GetString(2),
                    empleado_dni =(int) sdr.GetValue(4)
                };
            }
        }
        public List<Usuario> search(string username, List<string> lista)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.usuario as u")
                .filterIf(username.Length != 0, "u.username like '%{0}%' ", username)
                .filter("u.activo = 1");

                foreach (string rol in lista) {
                    QueryBuilder q2 = new QueryBuilder();
                    q2.select().from("[la_huerta].UsuarioRol as ur");
                    q2.filter("ur.usuario_id = u.id");
                    q2.filter("ur.rol_id= " + rol);
                    q.filter("exists (" + q2.build() + ")");
                }

            return connection.query<Usuario>(q.build(), q.getParams());
        }
        public Usuario searchById(int id)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.usuario")
                .filterIf(id != 0, "id = {0}", id);
            return connection.find<Usuario>(q.build(), q.getParams());
        }
        public Usuario findUserWithPassword(string user, string passwd) {
            List<Usuario> found = connection.query<Usuario>(
                "SELECT * FROM la_huerta.Usuario WHERE username = '{0}' and password = '{1}'",
                user,
                passwd
            );
            return found.Count == 1 ? found.First() : null;
        }
        private static readonly String INSERT = "INSERT INTO la_huerta.Usuario (username, password, activo, empleado_dni)VALUES( '{0}' , '{1}' , 1 , {2})";
        private static readonly String UPDATE = "UPDATE la_huerta.Usuario SET username='{0}',password='{1}',activo=1 where id='{2}'";
        private static readonly String UPDATE_WITHOUT_PASS = "UPDATE la_huerta.Usuario SET username='{0}',activo=1 where id='{1}'";
        private static readonly String DELETE = "UPDATE la_huerta.Usuario SET activo=0 WHERE id={0}";

        public void insertar(Usuario usuario)
        {
            connection.update(
                INSERT,
                    usuario.username,
                    sec.sha256encrypt(usuario.password), 
                    usuario.empleado_dni
                    );
        }
        public void modificar(Usuario usuario)
        {
            if (usuario.password.Length != 0) {
                connection.update(
                    UPDATE,
                        usuario.username,
                        sec.sha256encrypt(usuario.password),
                        usuario.id
                );
            } else {
                connection.update(
                    UPDATE_WITHOUT_PASS,
                        usuario.username,
                        usuario.id
                );
            }
        }
        public void eliminar(int id)
        {
            connection.update(
                DELETE,
                id
            );
        }
        private static readonly String INSERT_ROL = "INSERT INTO la_huerta.UsuarioRol VALUES( {0} , {1} )";
        public void insertarRol(Usuario usuario, Rol rol) {
            connection.update(INSERT_ROL, usuario.id, rol.id);
        }

        public static readonly String DELETE_ROLES_DE_USUARIO = "DELETE FROM la_huerta.UsuarioRol WHERE usuario_id= {0}";
        
        public void limpiarRoles(Usuario usuario) {
            connection.update(DELETE_ROLES_DE_USUARIO, usuario.id);
        }


        public Usuario findBy(Empleado empleado) {
            QueryBuilder q = new QueryBuilder();
            q.select().from("la_huerta.Usuario")
                .filter("empleado_dni = {0}", empleado.dni);
            return connection.find<Usuario>(q.build(), q.getParams());
        }
        public Usuario findByName(string username) {
            QueryBuilder q = new QueryBuilder();
            q.select().from("la_huerta.Usuario")
                .filter("username = '{0}'", username);
            return connection.find<Usuario>(q.build(), q.getParams());
        }

    }
}
