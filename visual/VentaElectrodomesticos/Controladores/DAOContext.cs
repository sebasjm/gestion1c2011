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
        public ClienteDAO cliente {
            get { if (_cliente == null) _cliente = new ClienteDAO(connection); return _cliente; }
            private set { _cliente = value; }
        }

        private RolDAO _rol;
        public RolDAO rol {
            get { if (_rol == null) _rol = new RolDAO(connection); return _rol; }
            private set { _rol = value; }
        }

        private MarcaDAO _marca;
        public MarcaDAO marca
        {
            get { if (_marca == null) _marca = new MarcaDAO(connection); return _marca; }
            private set { _marca = value; }
        }

        private CategoriaDAO _categoria;
        public CategoriaDAO categoria
        {
            get { if (_categoria == null) _categoria = new CategoriaDAO(connection); return _categoria; }
            private set { _categoria = value; }
        }
        private ProductoDAO _producto;
        public ProductoDAO producto
        {
            get { if (_producto == null) _producto = new ProductoDAO(connection); return _producto; }
            private set { _producto = value; }
        }
        private StockDAO _stock;
        public StockDAO stock
        {
            get { if (_stock == null) _stock = new StockDAO(connection); return _stock; }
            private set { _stock = value; }
        }
        private static string buildConnectionURL(string user, string passwd, string server, string db) {
            return "user id=" + user 
                + ";password=" + passwd + ";server=" + server + ";" + "database=" + db + "; ";
        }
    }
}
