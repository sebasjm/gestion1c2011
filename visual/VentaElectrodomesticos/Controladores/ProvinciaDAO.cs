﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentaElectrodomesticos.Modelo;
using System.Data.SqlClient;

namespace VentaElectrodomesticos.Controladores {
    class ProvinciaDAO {
        private Connection connection;
        public ProvinciaDAO(Connection connection) {
            this.connection = connection;
            Context.instance.dao.addMapper(typeof(Provincia), new ProvinciaMapper());
        }

        class ProvinciaMapper : Mapper<Object> {
            public Object getInstance(SqlDataReader sdr) {
                return new Provincia( (Byte) sdr.GetValue(0) ) {
                    nombre = (string)sdr.GetValue(1)
                };
            }
        }

        private List<Provincia> cache = null;

        public List<Provincia> load() {
            if (cache == null) {
                QueryBuilder q = new QueryBuilder();
                q.select().from("la_huerta.Provincia");
                cache = connection.query<Provincia>(q.build(), q.getParams());
            }
            return cache;
        }
    }

}