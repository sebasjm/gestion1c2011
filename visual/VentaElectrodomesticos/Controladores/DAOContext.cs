using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Controladores;
using VentaElectrodomesticos.Modelo;

namespace VentaElectrodomesticos.Controladores {
    class DAOContext {

        public Dictionary<Type, Mapper<Object>> mappers {
            get; private set;
        }

        public Connection connection;

        public DAOContext(string user, string passwd, string server, string db) {
            connection = new Connection( 
                new SqlConnection( buildConnectionURL(user, passwd, server, db) )
            );
            mappers = new Dictionary<Type, Mapper<object>>();
        }

        public void addMapper(Type type, Mapper<Object> mapper) {
            mappers.Add(type, mapper);
        }

        // TODO : SE deberia usar refletion
        private UserDAO _user;
        public UserDAO user {
            get { if (_user == null) _user = new UserDAO(connection); return _user; }
            private set { _user = value; }
        }

        private SucursalDAO _sucursal;
        public SucursalDAO sucursal
        {
            get { if (_sucursal == null) _sucursal = new SucursalDAO(connection); return _sucursal; }
            private set { _sucursal = value; }
        }

        private ProvinciaDAO _provincia;
        public ProvinciaDAO provincia
        {
            get { if (_provincia == null) _provincia = new ProvinciaDAO(connection); return _provincia; }
            private set { _provincia = value; }
        }
        private TipoEmpleadoDAO _tipoEmpleado;
        public TipoEmpleadoDAO tipoEmpleado
        {
            get { if (_tipoEmpleado == null) _tipoEmpleado = new TipoEmpleadoDAO(connection); return _tipoEmpleado; }
            private set { _tipoEmpleado = value; }
        }
        private EmpleadoDAO _empleado;
        public EmpleadoDAO empleado
        {
            get { if (_empleado == null) _empleado = new EmpleadoDAO(connection); return _empleado; }
            private set { _empleado = value; }
        }
        private ClienteDAO _cliente;
        public ClienteDAO cliente
        {
            get { if (_cliente == null) _cliente = new ClienteDAO(connection); return _cliente; }
            private set { _cliente = value; }
        }

        private static string buildConnectionURL(string user, string passwd, string server, string db) {
            return "user id=" + user 
                + ";password=" + passwd + ";server=" + server + ";" + "database=" + db + "; ";
        }
    }
}
