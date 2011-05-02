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
                //MessageBox.Show("ID : " + sdr.GetValue(0) + "NOMBRE :" + sdr.GetValue(1));
                // TODO : Ver porque tipo empleado tiene un espacio en la primary
                String cadena = (string)sdr.GetValue(0).ToString().Trim(' ');
                String cadena2 = (string)sdr.GetValue(1).ToString().Trim(' ');
                return new Categoria {
                    id = (int)Int16.Parse(cadena),
                    categoria_padre = (int)Int16.Parse(cadena2),
                    nombre = (string)sdr.GetValue(1)
                };
            }
        }
    }
}
