
namespace OOP2_Project__H_
{
    partial class UpdateManager
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
            this.tbNewManagerPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbManID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewManagerID = new System.Windows.Forms.TextBox();
            this.tbNewManagerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewManagerPassword
            // 
            this.tbNewManagerPassword.Location = new System.Drawing.Point(159, 239);
            this.tbNewManagerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewManagerPassword.Name = "tbNewManagerPassword";
            this.tbNewManagerPassword.Size = new System.Drawing.Size(188, 22);
            this.tbNewManagerPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(247, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Change Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbManID
            // 
            this.tbManID.AutoSize = true;
            this.tbManID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManID.Location = new System.Drawing.Point(68, 182);
            this.tbManID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbManID.Name = "tbManID";
            this.tbManID.Size = new System.Drawing.Size(31, 21);
            this.tbManID.TabIndex = 7;
            this.tbManID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter New Manager Informations";
            // 
            // tbNewManagerID
            // 
            this.tbNewManagerID.Location = new System.Drawing.Point(159, 182);
            this.tbNewManagerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewManagerID.Name = "tbNewManagerID";
            this.tbNewManagerID.Size = new System.Drawing.Size(188, 22);
            this.tbNewManagerID.TabIndex = 12;
            // 
            // tbNewManagerName
            // 
            this.tbNewManagerName.Location = new System.Drawing.Point(159, 132);
            this.tbNewManagerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewManagerName.Name = "tbNewManagerName";
            this.tbNewManagerName.Size = new System.Drawing.Size(188, 22);
            this.tbNewManagerName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // UpdateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 412);
            this.Controls.Add(this.tbNewManagerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewManagerID);
            this.Controls.Add(this.tbNewManagerPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbManID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateManager";
            this.Text = "UpdateManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewManagerPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tbManID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewManagerID;
        private System.Windows.Forms.TextBox tbNewManagerName;
        private System.Windows.Forms.Label label2;
    }
}