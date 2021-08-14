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

            var query = @$"INSERT INTO Customers2 (first_name,last_name,email,street,city,state,age) 
                            VALUES (@first_name, @last_name, @email, @street, @city, @state, @age)";

            using var command = new MySqlCommand(query, connection);

            var customers = GenerateCustomers(100);

            foreach (var customer in customers)
            {
                command.Parameters.AddWithValue("@first_name", customer.FirstName);
                command.Parameters.AddWithValue("@last_name", customer.LastName);
                command.Parameters.AddWithValue("@email", customer.Email);
                command.Parameters.AddWithValue("@street", customer.Street);
                command.Parameters.AddWithValue("@city", customer.City);
                command.Parameters.AddWithValue("@state", customer.State);
                command.Parameters.AddWithValue("@age", customer.Age);
                
                command.ExecuteNonQuery();
                
                command.Parameters.Clear();
            }

            // var query = "SELECT * FROM Customers";
            //
            // using var command = new MySqlCommand(query, connection);
            //
            // var reader = command.ExecuteReader();
            //
            // var customers = new List<Customer>();
            //
            // while (reader.Read())
            // {
            //     customers.Add(new Customer
            //     {
            //         CustomerId = reader.GetInt32(0),
            //         FirstName = reader.GetString(1),
            //         LastName = reader.GetString(2),
            //         Email = reader.GetString(3),
            //         Street = reader.GetString(4),
            //         City = reader.GetString(5),
            //         State = reader.GetString(6),
            //         Age = reader.GetInt32(7)
            //     });
            // }
            //
            // foreach (var customer in customers)
            // {
            //     Console.WriteLine(customer);
            // }
            
            connection.Close();
        }
        
        public static IEnumerable<Customer> GenerateCustomers(int count)
        {
            for (var i = 0; i < count; i++)
            {
                yield return new Customer
                {
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last(),
                    Email = Faker.Internet.Email(),
                    Street = Faker.Address.StreetAddress(),
                    City = Faker.Address.City(),
                    State = Faker.Country.Name(),
                    Age = Faker.RandomNumber.Next(18, 100)
                };
            }
        }
    }
}