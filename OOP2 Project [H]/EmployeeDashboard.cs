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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddOrder().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OrderPayment().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new UpdatePhone().Show();
        }

        private void btChangePasswordEmp_Click(object sender, EventArgs e)
        {
            new ChangeEmployeePassword().Show();
        }

        private List<Order> GetOrder()
        {
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("select * from [Order]");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Order> list = new List<Order>();
            while (reader.Read())
            {
                Order od = new Order();
                od.OrderNo = reader.GetString(reader.GetOrdinal("OrderNo"));
                od.OrderDate = reader.GetString(reader.GetOrdinal("OrderDate"));
                od.OrderTime = reader.GetString(reader.GetOrdinal("OrderTime"));
                od.Food1Name = reader.GetString(reader.GetOrdinal("Food1Name"));
                od.Food1Price = reader.GetInt32(reader.GetOrdinal("Food1Price"));
                od.Food2Name = reader.GetString(reader.GetOrdinal("Food2Name"));
                od.Food2Price = reader.GetInt32(reader.GetOrdinal("Food2Price"));
                od.Food3Name = reader.GetString(reader.GetOrdinal("Food3Name"));
                od.Food3Price = reader.GetInt32(reader.GetOrdinal("Food3Price"));
                od.TotalCost = reader.GetString(reader.GetOrdinal("TotalCost"));
                od.PaymentStatus = reader.GetString(reader.GetOrdinal("PaymentStatus"));

                list.Add(od);

            }
            conn.Close();
            return list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var list = GetOrder();
            dtAllOrders.DataSource = list;
        }
        private void LoadData(object sender, EventArgs e)
        {
            var list = GetOrder();
            dtAllOrders.DataSource = list;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
