using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Controladores {
    class Context {

        private static Context _instance;
        public static Context instance {
            get { if (_instance == null) _instance = new Context(); return _instance; }
            private set { _instance = value; }
        }

        public Security security {
            get;
            private set;
        }

        public DAOContext dao {
            get; private set;
        }

        public static readonly string database_user = "gd";
        public static readonly string database_passwd = "gd2011";
        public static readonly string database_server = "localhost\\SQLSERVER2005;";
        public static readonly string database_db = "GD1C2011";
        
        public Context() {
            dao = new DAOContext(database_user, database_passwd, database_server, database_db);
            security = new SecurityMock();
        }

        public void authenticate(string user, string passwd) {
            security = new Security(user, passwd);
        }



    }
}
