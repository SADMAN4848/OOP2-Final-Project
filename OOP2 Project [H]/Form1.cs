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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagerForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeForm().Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Md. Sadman Rahman    18-38832-3\nNiaz Rahman Bhuiyan   18-38770-3\nSumaiya Sarwar              19-40319-1");
        }
    }

}

