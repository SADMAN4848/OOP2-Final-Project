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
    public partial class OrderPayment : Form
    {
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PaymentOrderNo = tbPaymentOrderNo.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("Update [Order] set PaymentStatus = 'PAID' where OrderNo='{0}'", PaymentOrderNo);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("PAID");
            }
            else
            {
                MessageBox.Show("Order not found");
            }
            conn.Close();
        }
    }
}
