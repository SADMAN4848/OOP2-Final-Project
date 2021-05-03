
namespace OOP2_Project__H_
{
    partial class ManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbManID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbManagerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbManagerPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Login";
            // 
            // tbManID
            // 
            this.tbManID.AutoSize = true;
            this.tbManID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManID.Location = new System.Drawing.Point(32, 110);
            this.tbManID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbManID.Name = "tbManID";
            this.tbManID.Size = new System.Drawing.Size(28, 21);
            this.tbManID.TabIndex = 1;
            this.tbManID.Text = "ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(201, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbManagerID
            // 
            this.tbManagerID.Location = new System.Drawing.Point(123, 110);
            this.tbManagerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbManagerID.Name = "tbManagerID";
            this.tbManagerID.Size = new System.Drawing.Size(188, 22);
            this.tbManagerID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // tbManagerPassword
            // 
            this.tbManagerPassword.Location = new System.Drawing.Point(123, 166);
            this.tbManagerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbManagerPassword.Name = "tbManagerPassword";
            this.tbManagerPassword.Size = new System.Drawing.Size(188, 22);
            this.tbManagerPassword.TabIndex = 5;
            this.tbManagerPassword.UseSystemPasswordChar = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 321);
            this.Controls.Add(this.tbManagerPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbManagerID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbManID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbManID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbManagerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbManagerPassword;
    }
}