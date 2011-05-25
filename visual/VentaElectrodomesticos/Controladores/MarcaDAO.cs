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
        public MarcaDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Marca), new MarcaMapper());
        }

        public List<Marca> search(string nombre) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.marca")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre);
            return connection.query<Marca>(q.build(), q.getParams());
        }
        public Marca findById(int id) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.marca")
                .filter("id = {0}", id);
            return connection.find<Marca>(q.build(), q.getParams());
        }

        public List<Marca> load() {
            QueryBuilder q = new QueryBuilder();
            q.select().from("la_huerta.Marca");
            return connection.query<Marca>(q.build(), q.getParams());
        }

        public Marca findByNombre(string nombre) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.marca")
                .filter(" nombre = '{0}' ", nombre);
            return connection.find<Marca>(q.build(), q.getParams());
        }

        class MarcaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Marca(sdr.GetInt16(0)) {
                    nombre = sdr.GetString(1)
                };
            }
        }

        private static readonly String INSERT = "INSERT INTO la_huerta.Marca ( nombre , activo ) VALUES('{0}',1)";
        private static readonly String UPDATE = "UPDATE la_huerta.Marca SET nombre='{1}' WHERE id={0}";
        private static readonly String DELETE = "UPDATE la_huerta.Marca SET activo=0 WHERE id={0}";

        public void insertar(Marca marca) {
            connection.update(
                INSERT,
                marca.nombre
            );
        }

        public Marca findOrCreate(string p) {
            Marca m = findByNombre(p);
            if (m == null) insertar(new Marca(0) { nombre = p });
            return m == null ? findByNombre(p) : m;
        }

        public void modificar(Marca marca) {
            connection.update(
                UPDATE,
                marca.id,
                marca.nombre
            );
        }

        public void eliminar(int id) {
            connection.update(
                DELETE,
                id
            );
        }
    }
}
