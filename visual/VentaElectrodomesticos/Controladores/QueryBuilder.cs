using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Controladores {
    class QueryBuilder {

        private string query;
        private List<object> filters;

        public QueryBuilder() {
            query = "";
            filters = new List<object>();
        }

        public QueryBuilder select() {
            query += "SELECT * ";
            return this;
        }

        public QueryBuilder from(string table) {
            query += "FROM " + table;
            return this;
        }

        private bool firstFilter = true;

        public QueryBuilder filterIf(bool condition, string filter, object param) {
            if (condition) {
                query += (firstFilter ? " WHERE " : " and ") + filter;
                filters.Add(param);
                firstFilter = false;
            }
            return this;
        }

        public string build() {
            return query;
        }

        public object[] getParams() {
            return filters.ToArray();
        }
    }
}
