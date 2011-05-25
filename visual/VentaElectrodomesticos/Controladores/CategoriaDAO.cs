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
        public CategoriaDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Categoria), new CategoriaMapper());
        }
        public List<Categoria> search(int codigo, string nombre) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Categoria")
                .filterIf(codigo != 0, "id = {0}", codigo)
                .filterIf(nombre.Length != 0, "nombre like '%{1}%' ", nombre);
            return connection.query<Categoria>(q.build(), q.getParams());
        }
        class CategoriaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Categoria(sdr.GetInt16(0)) {
                    categoria_padre = (sdr.IsDBNull(1)) ? (Int16?)null : sdr.GetInt16(1),
                    nombre = sdr.GetString(2)
                };
            }
        }
        public Categoria findById(int id) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.categoria")
                .filterIf(id != 0, "id = {0}", id);
            return connection.find<Categoria>(q.build(), q.getParams());
        }

        public List<Categoria> load() {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Categoria");
            return connection.query<Categoria>(q.build() + " order by categoria_padre", q.getParams());
        }
    }
}
