using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIBM_Management_System
{
    internal class Connection
    {
        public static MySqlConnection connectionDB()
        {
            String connection_string = "server=127.0.0.1;user=root;database=nibmdb;password=";
            MySqlConnection con = new MySqlConnection(connection_string);
            return con;
        }
    }
}
