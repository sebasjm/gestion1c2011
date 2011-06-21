using System;
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
        class UserMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Usuario((int)sdr.GetValue(0)) {
                    username = sdr.GetString(1),
                    password = sdr.GetString(2),
                    empleado_dni = (int)sdr.GetValue(4),
                    intentos = (Byte)sdr.GetValue(5),
                };
            }
        }
        public List<Usuario> search(string username, List<string> lista, Empleado empleado , bool activo) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("EL_GRUPO.usuario as u")
                .filterIf(username.Length != 0, "u.username like '%{0}%' ", username)
                .filterIf(empleado != null && empleado.dni != 0, "u.empleado_dni = {1} ", empleado != null ? empleado.dni : 0)
                .filter("u.activo = {2} ", activo ? 1 : 0);
            foreach (string rol in lista) {
               QueryBuilder q2 = new QueryBuilder();
               q2.select().from("[EL_GRUPO].UsuarioRol as ur");
               q2.filter("ur.usuario_id = u.id");
               q2.filter("ur.rol_id= " + rol);
               q.filter("exists (" + q2.build() + ")");
           }
            return connection.query<Usuario>(q.build(), q.getParams());
        }
        public Usuario searchById(int id) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("EL_GRUPO.usuario")
                .filterIf(id != 0, "id = {0}", id);
            return connection.find<Usuario>(q.build(), q.getParams());
        }
        public Usuario findUserWithPassword(string user, string passwd) {
            return connection.find<Usuario>(
                "SELECT * FROM EL_GRUPO.Usuario WHERE username = '{0}' and password = '{1}' and activo = 1",
                user,
                passwd
            );
        }

        private static readonly String INSERT = "INSERT INTO EL_GRUPO.Usuario (username, password, activo, empleado_dni)VALUES( '{0}' , '{1}' , 1 , {2})";
        private static readonly String UPDATE = "UPDATE EL_GRUPO.Usuario SET username='{0}',password='{1}',empleado_dni={2},activo=1 where id='{3}'";
        private static readonly String UPDATE_WITHOUT_PASS = "UPDATE EL_GRUPO.Usuario SET username='{0}',empleado_dni={1},activo=1 where id='{2}'";
        private static readonly String DELETE = "UPDATE EL_GRUPO.Usuario SET activo=0 WHERE id={0}";

        public void insertar(Usuario usuario) {
            connection.update(
                INSERT,
                    usuario.username,
                    sec.sha256encrypt(usuario.password),
                    usuario.empleado_dni
                    );
        }
        public void modificar(Usuario usuario) {
            if (usuario.password.Length != 0) {
                connection.update(
                    UPDATE,
                        usuario.username,
                        sec.sha256encrypt(usuario.password),
                        usuario.empleado_dni,
                        usuario.id
                );
            } else {
                connection.update(
                    UPDATE_WITHOUT_PASS,
                        usuario.username,
                        usuario.empleado_dni,
                        usuario.id
                );
            }
        }
        public void eliminar(Int32 id) {
            connection.update(
                DELETE,
                id
            );
        }
        private static readonly String INSERT_ROL = "INSERT INTO EL_GRUPO.UsuarioRol VALUES( {0} , {1} )";
        public void insertarRol(Usuario usuario, Rol rol) {
            connection.update(INSERT_ROL, usuario.id, rol.id);
        }

        public static readonly String DELETE_ROLES_DE_USUARIO = "DELETE FROM EL_GRUPO.UsuarioRol WHERE usuario_id= {0}";

        public void limpiarRoles(Usuario usuario) {
            connection.update(DELETE_ROLES_DE_USUARIO, usuario.id);
        }

        public Usuario findBy(Empleado empleado) {
            QueryBuilder q = new QueryBuilder();
            q.select().from("EL_GRUPO.Usuario")
                .filter("empleado_dni = {0}", empleado.dni);
            return connection.find<Usuario>(q.build(), q.getParams());
        }

        public Usuario findByName(string username) {
            QueryBuilder q = new QueryBuilder();
            q.select().from("EL_GRUPO.Usuario")
                .filter("username = '{0}'", username);
            return connection.find<Usuario>(q.build(), q.getParams());
        }
        private static readonly String FAIL_LOGIN = "UPDATE EL_GRUPO.Usuario set intentos = intentos + 1, activo = (CASE WHEN (intentos + 1 >= 3) THEN 0 ELSE 1 END) WHERE username = '{0}';";
        private static readonly String RESET_FAIL_LOGIN = "UPDATE EL_GRUPO.Usuario set intentos = 0 WHERE username = '{0}';";

        public void failLogin(String usuario) {
            connection.update(FAIL_LOGIN, usuario);
        }
        public void resetFailLogin(String user) {
            connection.update(RESET_FAIL_LOGIN, user);
        }

        private static readonly String DESHABILITAR = "UPDATE EL_GRUPO.Usuario SET activo=0 WHERE username='{0}'";
        public void desahabilitar(String usuario)
        {
            connection.update(DESHABILITAR, usuario);
        }

        private static readonly String HABILITAR = "UPDATE EL_GRUPO.Usuario SET activo=1 WHERE id={0}";

        public void habilitar(int id)
        {
            connection.update(
                HABILITAR,
                id
            );
        }
        private static readonly String FIND_PERMISSION_LIST = "select funcionalidad_id from el_grupo.UsuarioRol as ur join el_grupo.RolFuncionalidad as rf on rf.rol_id = ur.rol_id where usuario_id = {0} group by funcionalidad_id ";

        public List<byte> findPermissionList(int user_id) {
            return connection.query<byte>(FIND_PERMISSION_LIST,user_id);
        }

    }
}

