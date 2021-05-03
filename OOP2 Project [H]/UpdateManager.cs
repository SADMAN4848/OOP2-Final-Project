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
    public partial class UpdateManager : Form
    {
        public UpdateManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ManagerName = tbNewManagerName.Text;
            string ManagerID = tbNewManagerID.Text;
            string ManagerPassword = tbNewManagerPassword.Text;
            var conn = Database.COnnectDB();
            conn.Open();
            string query = string.Format("Update Manager set ManName = '{0}', ManID = '{1}', ManPassword='{2}' where ManID='18388323'", ManagerName, ManagerID, ManagerPassword);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r>0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            conn.Close();
        }

        
    }
}
