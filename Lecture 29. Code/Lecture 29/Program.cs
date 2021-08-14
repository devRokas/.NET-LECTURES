using System;
using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;

namespace Lecture_29
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Part 1 - sql connection string craetion
            var connectionStringBuilder = new MySqlConnectionStringBuilder();
            
            connectionStringBuilder.Server = "localhost";
            connectionStringBuilder.Port = 3306;
            connectionStringBuilder.UserID = "root";
            connectionStringBuilder.Password = "testas";
            connectionStringBuilder.Database = "LearningSQL";
            //
            // var connectionString = connectionStringBuilder.GetConnectionString(true);
            //
            // // Part 2 - sql connection creation and execution
            // using var connection = new MySqlConnection(connectionString);
            //
            // var sql = "SELECT * FROM Customers2";
            //
            // var customers = connection.Query<Customer>(sql);
            //
            // var query = @"INSERT INTO Customers2 (first_name,last_name,email,street,city,state,age) 
            //                 VALUES (@first_name, @last_name, @email, @street, @city, @state, @age)";
            //
            // var deleteSql = "DELETE FROM Customers2 Where age = @age";
            //
            // var rowsAffected = connection.Execute(deleteSql, new {Age = 27});
            //
            // Console.WriteLine(rowsAffected);
            
            var sqlClient = new SqlClient(connectionStringBuilder.GetConnectionString(true));

            var selectSql = "SELECT * FROM Customers2 WHERE age > @age";

            var customers = sqlClient.Query<Customer>(selectSql, new {Age = 30});
            
            var deleteSql = "DELETE FROM Customers2 Where age = @age";

            var rowsAffected = sqlClient.Execute(deleteSql, new { Age = 38 });

            Console.WriteLine(rowsAffected);

            // foreach (var customer in customers)
            // {
            //     Console.WriteLine(customer);
            // }
        }
        
        public static IEnumerable<Customer> GenerateCustomers(int count)
        {
            for (var i = 0; i < count; i++)
            {
                yield return new Customer
                {
                    First_Name = Faker.Name.First(),
                    Last_Name = Faker.Name.Last(),
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