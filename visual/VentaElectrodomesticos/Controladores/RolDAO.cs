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
        public void limpiarFuncionalidades(Rol rol)
        {
            QueryBuilder q = new QueryBuilder();
            q.delete("la_huerta.rolFuncionalidad")
                .filterIf(rol.id != 0, " rol_id = {0} ", rol.id);
            connection.query<Funcionalidad>(q.build(), q.getParams());
        }
        public List<Rol> search(string nombre, CheckedListBox lista)
        {
            List<string> valores = new List<string>(); // Create new list of strings
            foreach(Funcionalidad funcionalidad in lista.CheckedItems) {
                valores.Add(""+funcionalidad.id);
            }
            String cadenaFuncionalidades = String.Join(",", valores.ToArray());
            QueryBuilder q = new QueryBuilder();
            q.select_distinc(" rol.* ")
                .from("[la_huerta].[Rol] as rol")
                .inner_join("[la_huerta].[RolFuncionalidad] as rolfun" , "rolfun.rol_id = rol.id")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre)
                .filterIf(lista.CheckedItems.Count > 0, "funcionalidad_id in ( {1} ) ", String.Join(",", valores.ToArray()));
            return connection.query<Rol>(q.build(), q.getParams());
        }
        public List<Funcionalidad> getFuncionalidades(Byte? id)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("[la_huerta].[Funcionalidad] as func")
                .inner_join("[la_huerta].[RolFuncionalidad] as rolfun", "rolfun.funcionalidad_id = func.id")
                .filterIf(id != 0, "rolfun.rol_id = {0} ", id);
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
        public void insertar(Rol rol)
        {
            List<Campo> campos = new List<Campo>();
            campos.Add(new Campo("nombre", (string)rol.nombre));
            campos.Add(new Campo("descripcion", (string)rol.descripcion));
            QueryBuilder q = new QueryBuilder();
            q.insert("la_huerta.rol")
                .valores_insert(campos);
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void modificar(Rol _rol)
        {
            List<Campo> campos = new List<Campo>();
            campos.Add(new Campo("nombre", (string)_rol.nombre));
            campos.Add(new Campo("descripcion", (string)_rol.descripcion));
            QueryBuilder q = new QueryBuilder();
            q.update("la_huerta.rol")
                .valores_update(campos)
                .filterIf(_rol.id != 0, "id = {0}", _rol.id);
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void delete(Rol _rol)
        {
            List<Campo> campos = new List<Campo>();
            campos.Add(new Campo("activo", (int)0));
            QueryBuilder q = new QueryBuilder();
            q.update("la_huerta.rol")
                .valores_update(campos)
                .filterIf(_rol.id != 0, "id = {0}", _rol.id);
            connection.query<Rol>(q.build(), q.getParams());
        }
    }
}
