// See https://aka.ms/new-console-template for more information
using Factory;
using MySql.Data.MySqlClient;
using System.Data;

ConnectionFactory factory = new ConnectionFactory();
IDbConnection connection = factory.GetConnection();

connection.Open();

MySqlCommand command = new()
{
    Connection = (MySqlConnection)connection,
    CommandText = "Select name from product",
};

MySqlDataReader reader = command.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(reader.GetString(0));
}

connection.Close();

