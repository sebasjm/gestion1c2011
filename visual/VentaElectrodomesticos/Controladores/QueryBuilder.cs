using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentaElectrodomesticos.Controladores {
    class QueryBuilder {
        private string query;
        private List<object> filters;
        private bool firstFilter = true;
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
        public QueryBuilder filter(string filter) { return filterIf(true, filter); }
        public QueryBuilder filter(string filter, object param) { return filterIf(true, filter, param); }
        public QueryBuilder filterIf(bool condition, string filter) { return filterIf(condition, filter, null); }
        public QueryBuilder filterIf(bool condition, string filter, object param) {
            if (condition) {
                query += (firstFilter ? " WHERE " : " and ") + filter;
                firstFilter = false;
            }
            if (param != null) filters.Add(param);
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
