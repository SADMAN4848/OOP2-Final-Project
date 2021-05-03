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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewEmployeeName = tbNewEmployeeName.Text;
            string NewEmployeePhone = tbNewEmployeePhone.Text; 
            string NewEmployeeID = tbNewEmployeeID.Text; 
            string NewEmployeePosition = tbNewEmployeePosition.Text; 
            string NewEmployeeSalary = tbNewEmployeeSalary.Text;
            string NewEmployeePassword = tbNewEmployeePassword.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("insert into Employees values ('{0}','{1}','{2}','{3}','{4}', '{5}') ", NewEmployeeID, NewEmployeeName, NewEmployeePhone, NewEmployeePosition, NewEmployeeSalary, NewEmployeePassword);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Employee Added");
            }
            else
            {
                MessageBox.Show("Employee not added");
            }
            conn.Close();
        }

        private void nameee_Click(object sender, EventArgs e)
        {

        }

        private void tbManID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
