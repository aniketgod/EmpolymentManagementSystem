
namespace EmpolymentManagementSystem
{
    partial class Employee
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
            this.EmployeeLogin = new System.Windows.Forms.Button();
            this.EmployeeDetails = new System.Windows.Forms.Button();
            this.Employeeupdate = new System.Windows.Forms.Button();
            this.EmployeeAttendance = new System.Windows.Forms.Button();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ManagerMode = new System.Windows.Forms.Button();
            this.HrMode = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.employeePassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeLogin
            // 
            this.EmployeeLogin.Location = new System.Drawing.Point(21, 157);
            this.EmployeeLogin.Name = "EmployeeLogin";
            this.EmployeeLogin.Size = new System.Drawing.Size(153, 52);
            this.EmployeeLogin.TabIndex = 3;
            this.EmployeeLogin.Text = "Login";
            this.EmployeeLogin.UseVisualStyleBackColor = true;
            this.EmployeeLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeDetails
            // 
            this.EmployeeDetails.Location = new System.Drawing.Point(579, 126);
            this.EmployeeDetails.Name = "EmployeeDetails";
            this.EmployeeDetails.Size = new System.Drawing.Size(332, 52);
            this.EmployeeDetails.TabIndex = 4;
            this.EmployeeDetails.Text = "Personal Details";
            this.EmployeeDetails.UseVisualStyleBackColor = true;
            this.EmployeeDetails.Click += new System.EventHandler(this.EmployeeDetails_Click);
            // 
            // Employeeupdate
            // 
            this.Employeeupdate.Location = new System.Drawing.Point(251, 312);
            this.Employeeupdate.Name = "Employeeupdate";
            this.Employeeupdate.Size = new System.Drawing.Size(153, 52);
            this.Employeeupdate.TabIndex = 5;
            this.Employeeupdate.Text = "update details";
            this.Employeeupdate.UseVisualStyleBackColor = true;
            this.Employeeupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmployeeAttendance
            // 
            this.EmployeeAttendance.Location = new System.Drawing.Point(680, 12);
            this.EmployeeAttendance.Name = "EmployeeAttendance";
            this.EmployeeAttendance.Size = new System.Drawing.Size(153, 52);
            this.EmployeeAttendance.TabIndex = 6;
            this.EmployeeAttendance.Text = "Attendence";
            this.EmployeeAttendance.UseVisualStyleBackColor = true;
            this.EmployeeAttendance.Click += new System.EventHandler(this.button4_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(21, 93);
            this.EmployeeID.Multiline = true;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(153, 50);
            this.EmployeeID.TabIndex = 7;
            this.EmployeeID.Text = "Employee ID";
            this.EmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(191, 91);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(141, 52);
            this.Password.TabIndex = 8;
            this.Password.Text = "Password";
            // 
            // ManagerMode
            // 
            this.ManagerMode.Location = new System.Drawing.Point(485, 22);
            this.ManagerMode.Name = "ManagerMode";
            this.ManagerMode.Size = new System.Drawing.Size(132, 49);
            this.ManagerMode.TabIndex = 20;
            this.ManagerMode.Text = "Manager Mode";
            this.ManagerMode.UseVisualStyleBackColor = true;
            this.ManagerMode.Click += new System.EventHandler(this.ManagerMode_Click);
            // 
            // HrMode
            // 
            this.HrMode.Location = new System.Drawing.Point(310, 22);
            this.HrMode.Name = "HrMode";
            this.HrMode.Size = new System.Drawing.Size(132, 49);
            this.HrMode.TabIndex = 21;
            this.HrMode.Text = "HR Mode";
            this.HrMode.UseVisualStyleBackColor = true;
            this.HrMode.Click += new System.EventHandler(this.HrMode_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(191, 159);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(141, 49);
            this.LogOut.TabIndex = 22;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Data
            // 
            this.Data.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Data.BackColor = System.Drawing.SystemColors.Info;
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Data.Location = new System.Drawing.Point(554, 185);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Data.Size = new System.Drawing.Size(398, 308);
            this.Data.TabIndex = 27;
            this.Data.Text = "\r\n";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(21, 255);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(206, 64);
            this.address.TabIndex = 28;
            this.address.Text = "address";
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // employeePassword
            // 
            this.employeePassword.Location = new System.Drawing.Point(21, 352);
            this.employeePassword.Multiline = true;
            this.employeePassword.Name = "employeePassword";
            this.employeePassword.Size = new System.Drawing.Size(194, 64);
            this.employeePassword.TabIndex = 29;
            this.employeePassword.Text = "password";
            this.employeePassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 546);
            this.Controls.Add(this.employeePassword);
            this.Controls.Add(this.address);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.HrMode);
            this.Controls.Add(this.ManagerMode);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.EmployeeAttendance);
            this.Controls.Add(this.Employeeupdate);
            this.Controls.Add(this.EmployeeDetails);
            this.Controls.Add(this.EmployeeLogin);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmployeeLogin;
        private System.Windows.Forms.Button EmployeeDetails;
        private System.Windows.Forms.Button Employeeupdate;
        private System.Windows.Forms.Button EmployeeAttendance;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ManagerMode;
        private System.Windows.Forms.Button HrMode;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox employeePassword;
    }
}

