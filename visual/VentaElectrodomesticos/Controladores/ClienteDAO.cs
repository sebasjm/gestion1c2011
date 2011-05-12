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
        public List<Cliente> search(string nombre, string apellido, int dni) {
            QueryBuilder q = new QueryBuilder();
            q.select()
                .from("la_huerta.Cliente")
                .filterIf(nombre != null && nombre.Length != 0, " nombre like '%{0}%'", nombre)
                .filterIf(apellido != null && apellido.Length != 0, " apellido like '%{1}%'", apellido)
                .filterIf(dni != 0, " dni = {2}", dni)
                .filterIf(true, "activo = {3} ", 1);

            return connection.query<Cliente>( q.build(), q.getParams() );
        }
        class ClienteMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Cliente(sdr.GetInt32(0)) {
                    nombre = sdr.GetString(1),
                    apellido = sdr.GetString(2),
                    mail = sdr.GetString(3),
                    telefono = sdr.GetString(4),
                    direccion = sdr.GetString(5),
                    provinciaId = sdr.GetByte(6)
                };
            }
        }
        //CRUD
        public void insertar(Cliente cliente)
        {
            List<Campo> campos = new List<Campo>();
            campos.Add(new Campo("nombre", (string)cliente.nombre));
            campos.Add(new Campo("apellido", (string)cliente.apellido));
            campos.Add(new Campo("dni", (int)cliente.dni));
            campos.Add(new Campo("mail", (string)cliente.mail));
            campos.Add(new Campo("telefono", (string)cliente.telefono));
            campos.Add(new Campo("direccion", (string)cliente.direccion));
            campos.Add(new Campo("provincia_id", (Byte)cliente.provinciaId));
            QueryBuilder q = new QueryBuilder();
            q.insert("la_huerta.cliente")
                .valores_insert(campos);
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void modificar(Cliente _cliente)
        {
            List<Campo> campos = new List<Campo>();
            campos.Add(new Campo("nombre", (string)_cliente.nombre));
            campos.Add(new Campo("apellido", (string)_cliente.apellido));
            campos.Add(new Campo("mail", (string)_cliente.mail));
            campos.Add(new Campo("telefono", (string)_cliente.telefono));
            campos.Add(new Campo("direccion", (string)_cliente.direccion));
            campos.Add(new Campo("provincia_id", (Byte)_cliente.provinciaId));
            QueryBuilder q = new QueryBuilder();
            q.update("la_huerta.cliente")
                .valores_update(campos)
                .filterIf(_cliente.dni != 0, "dni = {0}", _cliente.dni);
            connection.query<Usuario>(q.build(), q.getParams());
        }
        public void delete(Cliente _cliente)
        {
            List<Campo> campos = new List<Campo>();
            campos.Add(new Campo("activo", (int)0));
            QueryBuilder q = new QueryBuilder();
            q.update("la_huerta.cliente")
                .valores_update(campos)
                .filterIf(_cliente.dni != 0, "dni = {0}", _cliente.dni);
            connection.query<Usuario>(q.build(), q.getParams());
        }
    }
}
