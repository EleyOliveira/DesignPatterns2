// See https://aka.ms/new-console-template for more information
using Factory;
using MySql.Data.MySqlClient;
using System.Data;

ConnectionFactory factory = new ConnectionFactory();

using (IDbConnection connection = factory.GetConnection())
{
    using (MySqlCommand command = new())
    {
        command.CommandText = "Select name from product";
        command.Connection = (MySqlConnection)connection;

        connection.Open();

        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader["name"]);
            }            
        }
    }    
}











