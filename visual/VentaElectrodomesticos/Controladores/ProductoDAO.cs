using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;
using VentaElectrodomesticos.Controladores;
namespace VentaElectrodomesticos.Controladores {
    class ProductoDAO {
        private Connection connection;
        public ProductoDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Producto), new ProductoMapper());
        }
        public List<Producto> search(
            string codigo_producto,
            string nombre,
            int marca,
            int categoria,
            float precioDesde,
            float precioHasta) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Producto")
                .filterIf(codigo_producto != null && codigo_producto.Length != 0, " codigo like '%{0}%'", codigo_producto)
                .filterIf(nombre != null && nombre.Length != 0, " nombre like '%{1}%'", nombre)
                .filterIf(marca != 0, " marca_id ={2}", marca)
                .filterIf(categoria != 0, " {3} in (select * from dbo.categoria_id_collection(categoria_id))", categoria)
                .filterIf(precioDesde != 0, " precio >= {4}", precioDesde)
                .filterIf(precioHasta != 0, " precio <= {5}", precioHasta)
                .filter(" activo = 1 ");
            return connection.query<Producto>(q.build(), q.getParams());
        }
        class ProductoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Producto(sdr.GetInt32(0)) {
                    nombre = sdr.GetString(1),
                    descripcion = sdr.GetString(2),
                    precio = sdr.GetDouble(3),
                    marca_id = sdr.GetInt16(4),
                    categoria_id = sdr.GetInt16(5)
                };
            }
        }
        private static readonly String INSERT = "INSERT INTO la_huerta.producto VALUES( {0} , '{1}' , '{2}' , {3} , {4} ,  {5} , 1 )";
        private static readonly String UPDATE = "UPDATE [la_huerta].[Producto] SET codigo={0},nombre='{1}',descripcion='{2}',precio={3},marca_id={4},categoria_id={5},activo=1 WHERE codigo={0}";
        private static readonly String DELETE = "UPDATE la_huerta.producto SET activo=0 WHERE dni={0}";

        public void insertar(Producto producto) {
            connection.update(
                INSERT,
                    producto.codigo,
                    producto.nombre,
                    producto.descripcion,
                    producto.precio,
                    producto.marca_id,
                    producto.categoria_id
            );
        }
        public void modificar(Producto producto) {
            connection.update(
                UPDATE,
                    producto.codigo,
                    producto.nombre,
                    producto.descripcion,
                    producto.precio,
                    producto.marca_id,
                    producto.categoria_id
            );
        }
        public void eliminar(int codigo) {
            connection.update(
                DELETE,
                codigo
            );
        }
    }
}
