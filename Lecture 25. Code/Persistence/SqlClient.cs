using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;

namespace Persistence
{
    public class SqlClient : ISqlClient
    {
        private readonly string _connectionString;

        public SqlClient(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Execute(string sql, object param = null)
        {
            using var connection = new MySqlConnection(_connectionString);

            connection.Open();
            
            return connection.Execute(sql, param);
        }

        public IEnumerable<T> Query<T>(string sql, object param = null)
        {
            using var connection = new MySqlConnection(_connectionString);

            connection.Open();

            return connection.Query<T>(sql, param);
        }
    }
}