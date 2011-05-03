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
            int categoria,
            float precioDesde ,
            float precioHasta) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Producto")
                .filterIf(codigo_producto != null && codigo_producto.Length != 0, " codigo like '%{0}%'", codigo_producto)
                .filterIf(nombre != null && nombre.Length != 0, " nombre like '%{1}%'", nombre)
                .filterIf(categoria != 0 , " categoria_id = {2}", categoria)
                .filterIf(precioDesde != 0, " precio >= {3}", precioDesde)
                .filterIf(precioHasta != 0, " precio <= {4}", precioHasta)
                ;
            return connection.query<Producto>( q.build(), q.getParams() );
        }
        class ProductoMapper : Mapper<Object>
        {
            public Object getInstance(SqlDataReader sdr)
            {
                int codigo = (int)sdr.GetValue(0);

                return new Producto(codigo)
                {
                    /* nombre = (String)sdr.GetValue(1),
                    descripcion = (String)sdr.GetValue(2),
                    precio = (float)sdr.GetValue(3),
                    marca_id = (int)sdr.GetValue(4),
                    categoria_id = (int)sdr.GetValue(5) */
                };
            }
        }
        
    }
}
