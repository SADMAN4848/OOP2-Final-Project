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
    public partial class UpdatePhone : Form
    {
        public UpdatePhone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EmpIDPhone = tbEmpIDPhone.Text;
            string EmpPasswordPhone = tbEmpPasswordPhn.Text;
            string NewPhoneNo = tbEmpNewPhn.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("Update Employees set EmpPhone = '{0}' where EmpID='{1}' and EmpPassword='{2}'", NewPhoneNo, EmpIDPhone, EmpPasswordPhone);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Password Changed");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            conn.Close();
        }

       
    }
}
