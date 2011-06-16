using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VentaElectrodomesticos.Controladores {
    class RolDAO {
        private Connection connection;
        public RolDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Rol), new RolMapper());
        }
        class RolMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Rol(sdr.GetByte(0)) {
                    nombre = sdr.GetString(1),
                    descripcion = sdr.GetString(2)
                };
            }
        }

        public List<Rol> load() {
            QueryBuilder q = new QueryBuilder();
            q.select().from("EL_GRUPO.Rol");
            return connection.query<Rol>(q.build(), q.getParams());
        }

        public static readonly String DELETE_FUNCIONALIDADES_DEL_ROL = "DELETE FROM EL_GRUPO.RolFuncionalidad WHERE rol_id= {0}";
        public void limpiarFuncionalidades(Rol rol) {
            connection.update(DELETE_FUNCIONALIDADES_DEL_ROL, rol.id);
        }
        public List<Rol> search(string nombre, List<string> lista ,bool activo) {
           QueryBuilder q = new QueryBuilder();
           q.select().from("[EL_GRUPO].rol as r")
              .filterIf(nombre.Length != 0, "nombre like '%{0}%'", nombre)
              .filter("activo = {1} ", activo ? 1 : 0);
            foreach (string funcionalidad in lista) {
               QueryBuilder q2 = new QueryBuilder();
               q2.select().from("[EL_GRUPO].RolFuncionalidad");
               q2.filter("rol_id = r.id");
               q2.filter("funcionalidad_id= " + funcionalidad);
               q.filter("exists (" + q2.build() + ")");
           }
           return connection.query<Rol>(q.build(), q.getParams());
        }
        public List<Funcionalidad> getFuncionalidades(Byte? id) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("[EL_GRUPO].[Funcionalidad] as f JOIN [EL_GRUPO].[RolFuncionalidad] as rf ON rf.funcionalidad_id = f.id")
                .filterIf(id != 0, "rf.rol_id = {0} ", id);
            return connection.query<Funcionalidad>(q.build(), q.getParams());
        }
        public List<Rol> search(string nombre , bool activo) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("EL_GRUPO.rol")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre)
                .filter("activo = {1} ", activo ? 1 : 0);
            return connection.query<Rol>(q.build(), q.getParams());
        }
        public Rol findByNombre(string nombre) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("EL_GRUPO.rol")
                .filterIf(nombre.Length != 0, "nombre = '{0}' ", nombre);
            List<Rol> roles = connection.query<Rol>(q.build(), q.getParams());
            return roles[0];
        }
        private static readonly String INSERT_ROL = "INSERT INTO EL_GRUPO.rol (nombre, descripcion) values ('{0}','{1}')";
        public void insertar(Rol rol) {
            connection.update(INSERT_ROL, rol.nombre, rol.descripcion);
        }
        private static readonly String UPDATE_ROL = "UPDATE EL_GRUPO.rol set nombre= '{0}', descripcion= '{1}' WHERE id = {2}";
        public void modificar(Rol _rol) {

            connection.update(UPDATE_ROL, _rol.nombre, _rol.descripcion, _rol.id);
        }
        public void delete(Rol _rol) {
            QueryBuilder q = new QueryBuilder();
            connection.query<Rol>(q.build(), q.getParams());
        }
        public List<Rol> findBy(Usuario usuario) {
            QueryBuilder q = new QueryBuilder();
            q.select().from("EL_GRUPO.Rol as r JOIN EL_GRUPO.UsuarioRol as ur on r.id = ur.rol_id")
                .filter("usuario_id = {0}", usuario.id);
            return connection.query<Rol>(q.build(), q.getParams());

        }

        private static readonly String HABILITAR = "UPDATE EL_GRUPO.Rol SET activo=1 WHERE id={0}";

        public void habilitar(int id)
        {
            connection.update(
                HABILITAR,
                id
            );
        }
        private static readonly String ELIMINAR = "UPDATE EL_GRUPO.Rol SET activo=0 WHERE id={0}";

        public void eliminar(int id)
        {
            connection.update(
                ELIMINAR,
                id
            );
        }
    }
}
