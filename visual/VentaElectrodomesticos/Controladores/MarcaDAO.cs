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
    class MarcaDAO {
        private Connection connection;
        public MarcaDAO(Connection connection)
        {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Marca), new MarcaMapper());
        }
        public List<Marca> search(string nombre)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.marca")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre);
            return connection.query<Marca>(q.build(), q.getParams());
        }
        class MarcaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Marca (sdr.GetInt16(0)){
                    nombre = sdr.GetString(1)
                };
            }
        }
    }
}
