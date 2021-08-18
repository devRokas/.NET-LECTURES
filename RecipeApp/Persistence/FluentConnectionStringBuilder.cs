using MySql.Data.MySqlClient;

namespace Persistence
{
    public class FluentConnectionStringBuilder
    {
        private readonly MySqlConnectionStringBuilder _connectionStringBuilder;

        public FluentConnectionStringBuilder()
        {
            _connectionStringBuilder = new MySqlConnectionStringBuilder();
        }

        public FluentConnectionStringBuilder AddServer(string server)
        {
            _connectionStringBuilder.Server = server;
            
            return this;
        }
        
        public FluentConnectionStringBuilder AddPort(uint port)
        {
            _connectionStringBuilder.Port = port;
            
            return this;
        }
        
        public FluentConnectionStringBuilder AddUserId(string userId)
        {
            _connectionStringBuilder.UserID = userId;
            
            return this;
        }
        
        public FluentConnectionStringBuilder AddPassword(string password)
        {
            _connectionStringBuilder.Password = password;
            
            return this;
        }
        
        public FluentConnectionStringBuilder AddDatabase(string database)
        {
            _connectionStringBuilder.Database = database;
            
            return this;
        }

        public string BuildConnectionString(bool includePassword)
        {
            return _connectionStringBuilder.GetConnectionString(includePassword);
        }
    }
}