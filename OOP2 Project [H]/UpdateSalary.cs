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
    public partial class UpdateSalary : Form
    {
        public UpdateSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SalaryID = tbSalaryID.Text;
            string NewSalary = tbNewSalary.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("Update Employees set Salary = '{0}' where EmpID='{1}'", NewSalary, SalaryID);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Salary Updated");
            }
            else
            {
                MessageBox.Show("Salary Not Updated");
            }
            conn.Close();
        }
    }
}
