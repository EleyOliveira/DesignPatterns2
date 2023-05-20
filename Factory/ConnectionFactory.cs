using MySql.Data.MySqlClient;
using System.Data;

namespace Factory
{
    internal class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new MySqlConnection()
            {
                ConnectionString = "Server=localhost;DataBase=geek_shopping_product_api;Uid=root;Pwd=admin123"
            };
            return connection;
        }
    }
}
