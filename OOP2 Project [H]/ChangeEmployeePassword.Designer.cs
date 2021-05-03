
namespace OOP2_Project__H_
{
    partial class ChangeEmployeePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbChangePassEmpID = new System.Windows.Forms.TextBox();
            this.tbChangePassNewPassEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbManID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChangePassOldEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChangePassEmpID
            // 
            this.tbChangePassEmpID.Location = new System.Drawing.Point(225, 144);
            this.tbChangePassEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.tbChangePassEmpID.Name = "tbChangePassEmpID";
            this.tbChangePassEmpID.Size = new System.Drawing.Size(188, 22);
            this.tbChangePassEmpID.TabIndex = 20;
            // 
            // tbChangePassNewPassEmp
            // 
            this.tbChangePassNewPassEmp.Location = new System.Drawing.Point(225, 251);
            this.tbChangePassNewPassEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbChangePassNewPassEmp.Name = "tbChangePassNewPassEmp";
            this.tbChangePassNewPassEmp.Size = new System.Drawing.Size(188, 22);
            this.tbChangePassNewPassEmp.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "New Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(236, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbManID
            // 
            this.tbManID.AutoSize = true;
            this.tbManID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManID.Location = new System.Drawing.Point(67, 144);
            this.tbManID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbManID.Name = "tbManID";
            this.tbManID.Size = new System.Drawing.Size(119, 21);
            this.tbManID.TabIndex = 16;
            this.tbManID.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Change Employee Password";
            // 
            // tbChangePassOldEmp
            // 
            this.tbChangePassOldEmp.Location = new System.Drawing.Point(225, 198);
            this.tbChangePassOldEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbChangePassOldEmp.Name = "tbChangePassOldEmp";
            this.tbChangePassOldEmp.Size = new System.Drawing.Size(188, 22);
            this.tbChangePassOldEmp.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Old Password";
            // 
            // ChangeEmployeePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 401);
            this.Controls.Add(this.tbChangePassOldEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbChangePassEmpID);
            this.Controls.Add(this.tbChangePassNewPassEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbManID);
            this.Controls.Add(this.label1);
            this.Name = "ChangeEmployeePassword";
            this.Text = "ChangeEmployeePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChangePassEmpID;
        private System.Windows.Forms.TextBox tbChangePassNewPassEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tbManID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChangePassOldEmp;
        private System.Windows.Forms.Label label2;
    }
}