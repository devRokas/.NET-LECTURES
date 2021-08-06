using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Lecture_28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 - sql connection string craetion
            var connectionStringBuilder = new MySqlConnectionStringBuilder();

            connectionStringBuilder.Server = "localhost";
            connectionStringBuilder.Port = 3306;
            connectionStringBuilder.UserID = "root";
            connectionStringBuilder.Password = "testas";
            connectionStringBuilder.Database = "LearningSQL";

            var connectionString = connectionStringBuilder.GetConnectionString(true);
            
            // Part 2 - sql connection creation and execution
            using var connection = new MySqlConnection(connectionString);
            
            connection.Open();

            var query = "SELECT * FROM Customers";

            using var command = new MySqlCommand(query, connection);
            
            var reader = command.ExecuteReader();

            var customers = new List<Customer>();
            
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    CustomerId = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Street = reader.GetString(4),
                    City = reader.GetString(5),
                    State = reader.GetString(6),
                    Age = reader.GetInt32(7)
                });
            }
            
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
            
            connection.Close();
        }
    }
}