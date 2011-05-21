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
            //q.delete("la_huerta.rolFuncionalidad")
            //    .filterIf(rol.id != 0, " rol_id = {0} ", rol.id);
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
            return connection.query<Rol>(q.build(), q.getParams());
        }
        public List<Funcionalidad> getFuncionalidades(Byte? id)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("[la_huerta].[Funcionalidad] as func")
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
            QueryBuilder q = new QueryBuilder();
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void modificar(Rol _rol)
        {
            QueryBuilder q = new QueryBuilder();
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void delete(Rol _rol)
        {
            QueryBuilder q = new QueryBuilder();
            connection.query<Rol>(q.build(), q.getParams());
        }
    }
}
