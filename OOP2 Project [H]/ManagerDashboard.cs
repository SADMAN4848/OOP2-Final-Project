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
using System.Collections;

namespace OOP2_Project__H_
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            new UpdateManager().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddEmployee().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new UpdateSalary().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new SearchEmployee().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new RemoveEmployee().Show();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {

            var list = GetEmployee();
            dtEmpAllDisplay.DataSource = list;
            
        }

        private List<Employee> GetEmployee()
        {
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("select * from Employees");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmpID = reader.GetString(reader.GetOrdinal("EmpID"));
                emp.EmpName = reader.GetString(reader.GetOrdinal("EmpName"));
                emp.EmpPhone = reader.GetString(reader.GetOrdinal("EmpPhone"));
                emp.EmpPosition = reader.GetString(reader.GetOrdinal("EmpPosition"));
                emp.EmpPassword = reader.GetString(reader.GetOrdinal("EmpPassword"));
                emp.Salary = reader.GetString(reader.GetOrdinal("Salary"));

                list.Add(emp);

            }
            conn.Close();
            return list;
        }

        private void LoadData(object sender, EventArgs e)
        {
            var list = GetEmployee();
            dtEmpAllDisplay.DataSource = list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
