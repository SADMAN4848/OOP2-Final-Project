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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void btSearchEmployee_Click(object sender, EventArgs e)
        {
            string EmployeeID = tbSearchID.Text;
            
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("select * from Employees where EmpID='{0}'", EmployeeID);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Employee Exists");
            }
            else
            {
                MessageBox.Show("Employee Doesn't Exist");
            }
            conn.Close();
        }
    }
}
