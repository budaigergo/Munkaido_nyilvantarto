using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Nem sikerült csatlakozni az adatbázis szerverhez!");
                Environment.Exit(0);
            }
        }
    }
}