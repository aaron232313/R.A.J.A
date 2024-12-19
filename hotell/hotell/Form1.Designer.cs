namespace hotell
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnAddroom = new System.Windows.Forms.Button();
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.customerDetails1 = new hotell.all_User_Control.CustomerDetails();
            this.uC_Employee1 = new hotell.all_User_Control.UC_Employee();
            this.uC_Register1 = new hotell.all_User_Control.UC_Register();
            this.uC_Records1 = new hotell.all_User_Control.UC_Records();
            this.uC_AddRoom1 = new hotell.all_User_Control.UC_AddRoom();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.elipseControl3 = new ElipseToolDemo.ElipseControl();
            this.elipseControl4 = new ElipseToolDemo.ElipseControl();
            this.elipseControl5 = new ElipseToolDemo.ElipseControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::hotell.Properties.Resources.RAJA_BACKGROUD;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.btnEmployee);
            this.panel2.Controls.Add(this.btnRecords);
            this.panel2.Controls.Add(this.btnAddroom);
            this.panel2.Controls.Add(this.btnCustomerDetails);
            this.panel2.Location = new System.Drawing.Point(12, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 106);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::hotell.Properties.Resources.Copy_of_RAJA_Hote1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::hotell.Properties.Resources.Copy_of_RAJA_Hotel;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(1297, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 57);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.BackgroundImage = global::hotell.Properties.Resources.RAJA_BACKGROUD;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(158, 28);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(195, 59);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmployee.BackgroundImage = global::hotell.Properties.Resources.RAJA_BACKGROUD;
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployee.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmployee.Location = new System.Drawing.Point(1056, 28);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(191, 59);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRecords.BackgroundImage = global::hotell.Properties.Resources.RAJA_BACKGROUD;
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecords.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecords.Location = new System.Drawing.Point(380, 28);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(216, 59);
            this.btnRecords.TabIndex = 0;
            this.btnRecords.Text = "CHECK OUT";
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnAddroom
            // 
            this.btnAddroom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddroom.BackgroundImage = global::hotell.Properties.Resources.RAJA_BACKGROUD;
            this.btnAddroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddroom.FlatAppearance.BorderSize = 0;
            this.btnAddroom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddroom.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddroom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddroom.Location = new System.Drawing.Point(845, 28);
            this.btnAddroom.Name = "btnAddroom";
            this.btnAddroom.Size = new System.Drawing.Size(191, 59);
            this.btnAddroom.TabIndex = 1;
            this.btnAddroom.Text = "ADD ROOM";
            this.btnAddroom.UseVisualStyleBackColor = false;
            this.btnAddroom.Click += new System.EventHandler(this.btnAddroom_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCustomerDetails.BackgroundImage = global::hotell.Properties.Resources.RAJA_BACKGROUD;
            this.btnCustomerDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerDetails.FlatAppearance.BorderSize = 0;
            this.btnCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.Location = new System.Drawing.Point(630, 28);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(191, 59);
            this.btnCustomerDetails.TabIndex = 3;
            this.btnCustomerDetails.Text = "RECORDS";
            this.btnCustomerDetails.UseVisualStyleBackColor = false;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // customerDetails1
            // 
            this.customerDetails1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerDetails1.Location = new System.Drawing.Point(82, 104);
            this.customerDetails1.Name = "customerDetails1";
            this.customerDetails1.Size = new System.Drawing.Size(1228, 557);
            this.customerDetails1.TabIndex = 13;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Employee1.Location = new System.Drawing.Point(70, 104);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1228, 557);
            this.uC_Employee1.TabIndex = 12;
            // 
            // uC_Register1
            // 
            this.uC_Register1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Register1.Location = new System.Drawing.Point(12, 104);
            this.uC_Register1.Name = "uC_Register1";
            this.uC_Register1.Size = new System.Drawing.Size(1356, 557);
            this.uC_Register1.TabIndex = 11;
            this.uC_Register1.Load += new System.EventHandler(this.uC_Register1_Load);
            // 
            // uC_Records1
            // 
            this.uC_Records1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_Records1.Location = new System.Drawing.Point(12, 104);
            this.uC_Records1.Name = "uC_Records1";
            this.uC_Records1.Size = new System.Drawing.Size(1356, 557);
            this.uC_Records1.TabIndex = 10;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uC_AddRoom1.Location = new System.Drawing.Point(82, 104);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1228, 557);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.Load += new System.EventHandler(this.uC_AddRoom1_Load);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 0;
            this.elipseControl1.TargetControl = this;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 0;
            this.elipseControl2.TargetControl = this;
            // 
            // elipseControl3
            // 
            this.elipseControl3.CornerRadius = 0;
            this.elipseControl3.TargetControl = this;
            // 
            // elipseControl4
            // 
            this.elipseControl4.CornerRadius = 0;
            this.elipseControl4.TargetControl = this;
            // 
            // elipseControl5
            // 
            this.elipseControl5.CornerRadius = 0;
            this.elipseControl5.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotell.Properties.Resources.RAJA_BACKGROUD1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 673);
            this.Controls.Add(this.customerDetails1);
            this.Controls.Add(this.uC_Employee1);
            this.Controls.Add(this.uC_Register1);
            this.Controls.Add(this.uC_Records1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uC_AddRoom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private all_User_Control.UC_AddRoom uC_AddRoom1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnAddroom;
        private System.Windows.Forms.Button btnCustomerDetails;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private all_User_Control.UC_Records uC_Records1;
        private System.Windows.Forms.Button btnRegister;
        private all_User_Control.UC_Register uC_Register1;
        private ElipseToolDemo.ElipseControl elipseControl3;
        private ElipseToolDemo.ElipseControl elipseControl4;
        private all_User_Control.UC_Employee uC_Employee1;
        private ElipseToolDemo.ElipseControl elipseControl5;
        private all_User_Control.CustomerDetails customerDetails1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}