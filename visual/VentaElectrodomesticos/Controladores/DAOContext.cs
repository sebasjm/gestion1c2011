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


        private UserDAO _user;
        public UserDAO user {
            get { if (_user == null) _user = new UserDAO(connection); return _user; }
            private set { _user = value; }
        }

        public void addMapper(Type type, Mapper<Object> mapper) {
            mappers.Add(type, mapper);
        }

        private static string buildConnectionURL(string user, string passwd, string server, string db) {
            return "user id=" + user + ";password=" + passwd + ";server=" + server + ";" + "database=" + db + "; ";
        }

    }
}
