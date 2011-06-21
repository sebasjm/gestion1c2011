using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;
using VentaElectrodomesticos.Controladores;
namespace VentaElectrodomesticos.Controladores {
    class ClienteDAO {
        private Connection connection;
        public ClienteDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Cliente), new ClienteMapper());
        }
        public List<Cliente> search(string nombre, string apellido, int dni, Provincia provincia, bool activo) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("EL_GRUPO.Cliente")
                .filterIf(nombre != null && nombre.Length != 0, " nombre like '%{0}%'", nombre)
                .filterIf(apellido != null && apellido.Length != 0, " apellido like '%{1}%'", apellido)
                .filterIf(dni != 0, " dni = {2} ", dni)
                .filterIf(provincia != null && provincia.id != 0, " provincia_id = {3}", provincia != null ? provincia.id : 0)
                .filter("activo = {4} ", activo ? 1 : 0);

            return connection.query<Cliente>(q.build(), q.getParams());
        }
        class ClienteMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Cliente(sdr.GetInt32(0)) {
                    nombre = sdr.GetString(1),
                    apellido = sdr.GetString(2),
                    mail = sdr.GetString(3),
                    telefono = sdr.GetString(4),
                    direccion = sdr.GetString(5),
                    provinciaId = sdr.IsDBNull(6)? (Byte)0 : sdr.GetByte(6)
                };
            }
        }

        private static readonly String INSERT = "INSERT INTO EL_GRUPO.Cliente VALUES({0},'{1}','{2}','{3}','{4}','{5}',{6},1)";
        private static readonly String UPDATE = "UPDATE EL_GRUPO.Cliente SET nombre='{1}',apellido='{2}',mail='{3}',telefono='{4}',direccion='{5}',provincia_id={6} WHERE dni={0}";
        private static readonly String DELETE = "UPDATE EL_GRUPO.Cliente SET activo=0 WHERE dni={0}";

        public void insertar(Cliente cliente) {
            connection.update( 
                INSERT,
                cliente.dni,
                cliente.nombre,
                cliente.apellido,
                cliente.mail,
                cliente.telefono,
                cliente.direccion,
                cliente.provinciaId
            );
        }
        public void modificar(Cliente cliente) {
            connection.update(
                UPDATE,
                cliente.dni,
                cliente.nombre,
                cliente.apellido,
                cliente.mail,
                cliente.telefono,
                cliente.direccion,
                cliente.provinciaId
            );
        }

        public void eliminar(int dni) {
            connection.update(
                DELETE,
                dni
            );
        }

        private static readonly String HABILITAR = "UPDATE EL_GRUPO.cliente SET activo=1 WHERE dni={0}";

        public void habilitar(int dni)
        {
            connection.update(
                HABILITAR,
                dni
            );
        }

        public Cliente findByDni(int dni) {
            return connection.find<Cliente>("SELECT * FROM EL_GRUPO.Cliente WHERE dni = {0}", dni);
        }
    }
}
