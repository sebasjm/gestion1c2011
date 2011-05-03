using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VentaElectrodomesticos.Controladores;

namespace VentaElectrodomesticos.Controladores {
    class CategoriaDAO {
        private Connection connection;
        public CategoriaDAO(Connection connection)
        {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Categoria), new CategoriaMapper());
        }
        public List<Categoria> search(string nombre)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Categoria")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre);
            return connection.query<Categoria>(q.build(), q.getParams());
        }
        class CategoriaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                // TODO : Ver como resolver categoria padre con nulo

                String nom = (sdr.GetValue(2) == DBNull.Value) ? "" : (String)sdr.GetValue(2) ;
                Int16 padre = (sdr.GetValue(1) == DBNull.Value) ? (Int16)0 : (Int16)sdr.GetValue(1);
                return new Categoria {
                    id = (Int16)sdr.GetValue(0),
                    categoria_padre =padre,
                    nombre = nom
                };
            }
        }
    }
}
