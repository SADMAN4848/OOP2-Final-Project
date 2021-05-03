using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP2_Project__H_
{
    class Database
    {
        public static SqlConnection COnnectDB() {
            string connString = @"Server=DESKTOP-CVSU4IE\SQLEXPRESS;Database=OOP2_Project;Integrated Security=true;";
            return new SqlConnection(connString);   
        }
    }
}
