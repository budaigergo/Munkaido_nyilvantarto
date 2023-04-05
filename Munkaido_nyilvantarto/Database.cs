using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Munkaido_nyilvantarto
{
    internal class Database
    {
        public MySqlCommand comm;
        public MySqlConnection conn;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "munkaidonyilvantarto";
             conn = new MySqlConnection(builder.ConnectionString);
             comm = conn.CreateCommand();
        }
    }
}