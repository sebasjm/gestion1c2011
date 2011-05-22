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
        public Marca findById(int id)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.marca")
                .filterIf(id != 0, "id = {0}", id);
            List<Marca> lista = connection.query<Marca>(q.build(), q.getParams());
            return lista[0];
        }
        public List<Marca> load()
        {
            QueryBuilder q = new QueryBuilder();
            q.select().from("la_huerta.Marca");
            return connection.query<Marca>(q.build(), q.getParams());
        }
        public Marca findByNombre(string nombre)
        {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.marca")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre);
          List<Marca> marcas = connection.query<Marca>(q.build(), q.getParams());
          if (marcas.Count == 0)
              return null;
            return marcas[0];
        }
        class MarcaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Marca (sdr.GetInt16(0)){
                    nombre = sdr.GetString(1)
                };
            }
        }
        private static readonly String INSERT = "INSERT INTO la_huerta.Marca ( nombre , activo ) VALUES('{0}',1)";
        public void insertar(Marca marca)
        {
            connection.update(
                INSERT,
                marca.nombre
            );
        }
    }
}
