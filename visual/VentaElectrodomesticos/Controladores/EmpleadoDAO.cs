using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;
namespace VentaElectrodomesticos.Controladores {
    class EmpleadoDAO {
        private Connection connection;
        public EmpleadoDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Empleado), new EmpleadoMapper());
        }
        class EmpleadoMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Empleado((Int32)sdr.GetValue(0)) {
                    nombre = sdr.GetString(1),
                    apellido = sdr.GetString(2),
                    mail = sdr.GetString(3),
                    telefono = sdr.GetString(4),
                    direccion = sdr.GetString(5),
                    tipoEmpleadoId = sdr.GetByte(6),
                    sucursalId = sdr.GetByte(7),                 
                };
            }
        }
        private static QueryBuilder buildQuerySearch(string nombre, string apellido, int dni, Sucursal suc, TipoEmpleado tipoEmp, bool activo) {
            return new QueryBuilder()
                .select()
                .from("EL_GRUPO.Empleado")
                .filterIf(nombre.Length != 0, "nombre like '%{0}%' ", nombre)
                .filterIf(apellido.Length != 0, "apellido like '%{1}%' ", apellido)
                .filterIf(dni != 0, "dni = {2} ", dni)
                .filterIf(suc != null && suc.id != 0, "sucursal_id = {3} ", suc != null ? suc.id : 0)
                .filterIf(tipoEmp != null && tipoEmp.id != 0, "tipoEmpleado_id = {4} ", tipoEmp != null ? tipoEmp.id : 0)
                .filter("activo = {5} ", activo ? 1 : 0);
        }
        public List<Empleado> search(string nombre, string apellido, int dni, Sucursal suc, TipoEmpleado tipoEmp, bool activo) {
            QueryBuilder q = buildQuerySearch(nombre,apellido,dni,suc,tipoEmp,activo);
            return connection.query<Empleado>(q.build(), q.getParams());
        }
        public List<Empleado> search(string nombre, string apellido, int dni, Sucursal suc, TipoEmpleado tipoEmp, bool activo, bool conUsuario) {
            QueryBuilder q = buildQuerySearch(nombre,apellido,dni,suc,tipoEmp,activo);
            if (conUsuario) {
                q.filter(" dni in (select empleado_dni from el_grupo.usuario) ");
            } else {
                q.filter(" dni not in (select empleado_dni from el_grupo.usuario) ");
            }
            return connection.query<Empleado>(q.build(), q.getParams());
        }

        private static readonly String INSERT = "INSERT INTO EL_GRUPO.Empleado VALUES({0},'{1}','{2}','{3}','{4}','{5}',{6},{7},1)";
        private static readonly String UPDATE = "UPDATE EL_GRUPO.Empleado SET nombre='{1}',apellido='{2}',mail='{3}',telefono='{4}',direccion='{5}',tipoEmpleado_id={6},sucursal_id={7} WHERE dni={0}";
        private static readonly String DELETE = "UPDATE EL_GRUPO.Empleado SET activo=0 WHERE dni={0}";
        private static readonly String HABILITAR = "UPDATE EL_GRUPO.Empleado SET activo=1 WHERE dni={0}";

        public void insertar(Empleado empleado) {
            //inhabilitar si existe
            Context.instance.dao.cliente.eliminar(empleado.dni);
            //crear
            connection.update(
                INSERT,
                empleado.dni,
                empleado.nombre,
                empleado.apellido,
                empleado.mail,
                empleado.telefono,
                empleado.direccion,
                empleado.tipoEmpleadoId,
                empleado.sucursalId
            );
        }
        public void modificar(Empleado empleado) {
            connection.update(
                UPDATE,
                empleado.dni,
                empleado.nombre,
                empleado.apellido,
                empleado.mail,
                empleado.telefono,
                empleado.direccion,
                empleado.tipoEmpleadoId,
                empleado.sucursalId
            );
        }
        public void eliminar(int dni) {
            connection.update(
                DELETE,
                dni
            );
        }
        public Empleado findByDni(int dni){
            QueryBuilder q = new QueryBuilder();
            q.select().from("EL_GRUPO.Empleado")
                .filter("dni = {0}", dni);
            return connection.find<Empleado>(q.build(), q.getParams());
        }
        public void habilitar(int dni) {
            connection.update(
                HABILITAR,
                dni
            );
        }
    }
}
