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
    public partial class ChangeEmployeePassword : Form
    {
        public ChangeEmployeePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmpID = tbChangePassEmpID.Text;
            string EmpOldPassword = tbChangePassOldEmp.Text;
            string EmpNewPassword = tbChangePassNewPassEmp.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("Update Employees set EmpPassword = '{0}' where EmpID='{1}' and EmpPassword='{2}'", EmpNewPassword, EmpID, EmpOldPassword);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Phone Updated");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            conn.Close();
        }
    }
}
