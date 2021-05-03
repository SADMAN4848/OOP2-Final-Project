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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewOrderNo = tbOrderNo.Text;
            string NewOrderDate = tbOrderDate.Text;
            string NewOrderTime = tbOrderTime.Text;
            string NewFood1Name = tbFood1Name.Text;
            string NewFood1Price = tbFood1Price.Text;
            string NewFood2Name = tbFood2Name.Text;
            string NewFood2Price = tbFood2Price.Text;
            string NewFood3Name = tbFood3Name.Text;
            string NewFood3Price = tbFood3Price.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("insert into [Order] values ('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}') ", NewOrderNo, NewOrderDate, NewOrderTime, NewFood1Name, NewFood1Price, NewFood2Name, NewFood2Price, NewFood3Name, NewFood3Price);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Order Added");
            }
            else
            {
                MessageBox.Show("Error");
            }
            conn.Close();
        }
    }
}
