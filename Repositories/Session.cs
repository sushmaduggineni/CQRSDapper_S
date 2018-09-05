using CQRSWithDapper.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace CQRSWithDapper.Repositories
{
    public class Session : ISession
    {
        private readonly string _connectionString;

        public Session(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public virtual IEnumerable<T> Query<T>(string query, object param)
        {          
            using (var connection = GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                    return connection.Query<T>(query, param, transaction); ;
            }
        }

        public void Execute(string sql, object param)
        {
            using (var connection = GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                    connection.Execute(sql, param, transaction);
            }
        }
    }
}
