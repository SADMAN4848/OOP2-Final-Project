﻿
namespace OOP2_Project__H_
{
    partial class SearchEmployee
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
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSearchEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSearchID
            // 
            this.tbSearchID.Location = new System.Drawing.Point(151, 109);
            this.tbSearchID.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(188, 22);
            this.tbSearchID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Employee ID";
            // 
            // btSearchEmployee
            // 
            this.btSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchEmployee.Location = new System.Drawing.Point(195, 177);
            this.btSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btSearchEmployee.Name = "btSearchEmployee";
            this.btSearchEmployee.Size = new System.Drawing.Size(137, 41);
            this.btSearchEmployee.TabIndex = 31;
            this.btSearchEmployee.Text = "Search";
            this.btSearchEmployee.UseVisualStyleBackColor = true;
            this.btSearchEmployee.Click += new System.EventHandler(this.btSearchEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search Employee";
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 266);
            this.Controls.Add(this.tbSearchID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSearchEmployee);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchEmployee";
            this.Text = "SearchEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSearchEmployee;
        private System.Windows.Forms.Label label1;
    }
}