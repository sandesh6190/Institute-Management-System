using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thsemprj1
{
    public static class Connection
    {
        public static IDbConnection GetDbConnection()
        {
            return new MySqlConnection("Server=localhost;Database=db_institution;Uid=root;pwd=;");
        }
    }
}
