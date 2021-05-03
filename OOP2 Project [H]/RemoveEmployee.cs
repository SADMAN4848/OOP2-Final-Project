using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP2_Project__H_
{
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void btSearchEmployee_Click(object sender, EventArgs e)
        {
            string employeIDremove  = tbEmployeeID.Text;
            
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("delete from Employees where EmpID='{0}'", employeIDremove);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Employee Removed");
            }
            else
            {
                MessageBox.Show("Error");
            }
            conn.Close();
        }

        
    }
}
