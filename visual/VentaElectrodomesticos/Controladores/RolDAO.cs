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
        public RolDAO(Connection connection)
        {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Rol), new RolMapper());
        }
        class RolMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Rol( sdr.GetByte(0) ) {
                    nombre = sdr.GetString(1),
                    descripcion = sdr.GetString(2)
                };
            }
        }
        private List<Rol> cache = null;
        public List<Rol> load() {
            if (cache == null) {
                QueryBuilder q = new QueryBuilder();
                q.select().from("la_huerta.Rol");
                cache = connection.query<Rol>(q.build(), q.getParams());
            }
            return cache;
        }
        public static readonly String DELETE_FUNCIONALIDADES_DEL_ROL = "DELETE FROM la_huerta.RolFuncionalidad WHERE rol_id= {0}";
        public void limpiarFuncionalidades(Rol rol)
        {
            connection.update(DELETE_FUNCIONALIDADES_DEL_ROL, rol.id);
        }
        public List<Rol> search(string nombre, List<string> lista)
        {
            QueryBuilder q = new QueryBuilder();
            q.select().from("[la_huerta].rol as r")
                        .filterIf(nombre.Length != 0, "nombre like '%{0}%'", nombre);
                        foreach(string funcionalidad in lista) {
                            QueryBuilder q2 = new QueryBuilder();
                            q2.select().from("[la_huerta].RolFuncionalidad");
                            q2.filter("rol_id = r.id");
                            q2.filter("funcionalidad_id= " + funcionalidad);
                            q.filter("exists (" + q2.build() + ")");
                        }
            return connection.query<Rol>(q.build(), q.getParams());
        }
        public List<Funcionalidad> getFuncionalidades(Byte? id)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("[la_huerta].[Funcionalidad] as f JOIN [la_huerta].[RolFuncionalidad] as rf ON rf.funcionalidad_id = f.id")
                .filterIf(id != 0, "rf.rol_id = {0} ", id);
            return connection.query<Funcionalidad>(q.build(), q.getParams());
        }
        public List<Rol> search(string nombre)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.rol")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre);
            return connection.query<Rol>(q.build(), q.getParams());
        }
        public Rol findByNombre(string nombre)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.rol")
                .filterIf(nombre.Length != 0, "nombre = '{0}' ", nombre);
           List<Rol> roles = connection.query<Rol>(q.build(), q.getParams());
           return roles[0];
        }
        private static readonly String INSERT_ROL = "INSERT INTO la_huerta.rol (nombre, descripcion) values ('{0}','{1}')";
        public void insertar(Rol rol)
        {
            connection.update(INSERT_ROL, rol.nombre, rol.descripcion);
        }
        private static readonly String UPDATE_ROL = "UPDATE la_huerta.rol set nombre= '{0}', descripcion= '{1}' WHERE id = {2}";
        public void modificar(Rol _rol)
        {
            
            connection.update(UPDATE_ROL, _rol.nombre, _rol.descripcion, _rol.id);
        }
        public void delete(Rol _rol)
        {
            QueryBuilder q = new QueryBuilder();
            connection.query<Rol>(q.build(), q.getParams());
        }
        public List<Rol> findBy(Usuario usuario) {
            QueryBuilder q = new QueryBuilder();
            q.select().from("la_huerta.Rol as r JOIN la_huerta.UsuarioRol as ur on r.id = ur.rol_id")
                .filter("usuario_id = {0}", usuario.id);
            return connection.query<Rol>(q.build(), q.getParams());
            
        }
    }
}
