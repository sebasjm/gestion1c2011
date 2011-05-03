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
            float precioDesde ,
            float precioHasta) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Producto")
                .filterIf(codigo_producto != null && codigo_producto.Length != 0, " codigo like '%{0}%'", codigo_producto)
                .filterIf(nombre != null && nombre.Length != 0, " nombre like '%{1}%'", nombre)
                .filterIf(marca != 0 , " marca_id ={2}", marca)
                .filterIf(categoria != 0 , " categoria_id = {3}", categoria)
                .filterIf(precioDesde != 0, " precio >= {4}", precioDesde)
                .filterIf(precioHasta != 0, " precio <= {5}", precioHasta)
                ;
            return connection.query<Producto>( q.build(), q.getParams() );
        }
        class ProductoMapper : Mapper<Object>
        {
            public Object getInstance(SqlDataReader sdr)
            {
                int codigo = (int)sdr.GetValue(0);
                

                float preciox = (sdr.GetValue(3) == DBNull.Value) ? (float)0 : float.Parse(sdr.GetValue(3).ToString());

                String nombrex = sdr.IsDBNull(1) ? "" : (String)sdr.GetValue(1);
                String descripcionx = sdr.IsDBNull(2) ? "" : (String)sdr.GetValue(2);
                int marca = (sdr.IsDBNull(4) || sdr.GetValue(4) != null ) ? 0 : (int)sdr.GetValue(4);
                int categoria = (sdr.IsDBNull(4) || sdr.GetValue(4) != null) ? 0 : (int)sdr.GetValue(5);
                return new Producto(codigo)
                {
                    nombre = (String)nombrex,
                    descripcion = (String)descripcionx,
                    precio = preciox,
                    marca_id = marca,
                    categoria_id = categoria
                };
            }
        }
        
    }
}
