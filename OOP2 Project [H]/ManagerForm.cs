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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ManagerID = tbManagerID.Text;
            string ManagerPassword = tbManagerPassword.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("select * from Manager where ManID='{0}' and ManPassword='{1}'", ManagerID, ManagerPassword);
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                new ManagerDashboard().Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            conn.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }
    }
}
