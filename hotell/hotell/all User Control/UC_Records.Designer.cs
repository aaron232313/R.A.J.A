namespace hotell.all_User_Control
{
    partial class UC_Records
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.myHotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myHotelDataSet = new hotell.myHotelDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new hotell.myHotelDataSetTableAdapters.roomsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myHotelDataSet2 = new hotell.myHotelDataSet2();
            this.myHotelDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTableAdapter = new hotell.myHotelDataSet2TableAdapters.detailsTableAdapter();
            this.roomsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter1 = new hotell.myHotelDataSet2TableAdapters.roomsTableAdapter();
            this.detailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.detailsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHECK OUT";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(25, 97);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1311, 352);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // myHotelDataSetBindingSource
            // 
            this.myHotelDataSetBindingSource.DataSource = this.myHotelDataSet;
            this.myHotelDataSetBindingSource.Position = 0;
            // 
            // myHotelDataSet
            // 
            this.myHotelDataSet.DataSetName = "myHotelDataSet";
            this.myHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.myHotelDataSetBindingSource;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(561, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "SEARCH";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(565, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 28);
            this.txtName.TabIndex = 34;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "rooms";
            this.roomsBindingSource1.DataSource = this.myHotelDataSetBindingSource;
            // 
            // myHotelDataSet2
            // 
            this.myHotelDataSet2.DataSetName = "myHotelDataSet2";
            this.myHotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myHotelDataSet2BindingSource
            // 
            this.myHotelDataSet2BindingSource.DataSource = this.myHotelDataSet2;
            this.myHotelDataSet2BindingSource.Position = 0;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "details";
            this.detailsBindingSource.DataSource = this.myHotelDataSet2BindingSource;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource2
            // 
            this.roomsBindingSource2.DataMember = "rooms";
            this.roomsBindingSource2.DataSource = this.myHotelDataSet2BindingSource;
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // detailsBindingSource1
            // 
            this.detailsBindingSource1.DataMember = "details";
            this.detailsBindingSource1.DataSource = this.myHotelDataSet2BindingSource;
            // 
            // detailsBindingSource2
            // 
            this.detailsBindingSource2.DataMember = "details";
            this.detailsBindingSource2.DataSource = this.myHotelDataSet2BindingSource;
            // 
            // detailsBindingSource3
            // 
            this.detailsBindingSource3.DataMember = "details";
            this.detailsBindingSource3.DataSource = this.myHotelDataSet2BindingSource;
            // 
            // detailsBindingSource4
            // 
            this.detailsBindingSource4.DataMember = "details";
            this.detailsBindingSource4.DataSource = this.myHotelDataSet2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnCheckOut);
            this.panel2.Controls.Add(this.txtRoom);
            this.panel2.Controls.Add(this.txtCheckOutDate);
            this.panel2.Controls.Add(this.txtCName);
            this.panel2.Location = new System.Drawing.Point(25, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 88);
            this.panel2.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(301, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 24);
            this.label14.TabIndex = 55;
            this.label14.Text = "LAST NAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(842, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 24);
            this.label13.TabIndex = 54;
            this.label13.Text = "ROOM NO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(581, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 24);
            this.label11.TabIndex = 53;
            this.label11.Text = "DATE CHECK OUT";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackgroundImage = global::hotell.Properties.Resources.AUD;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(1018, 30);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(187, 39);
            this.btnCheckOut.TabIndex = 52;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtRoom
            // 
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(846, 42);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(146, 28);
            this.txtRoom.TabIndex = 51;
            this.txtRoom.TextChanged += new System.EventHandler(this.txtRoom_TextChanged);
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.CustomFormat = "MM/dd/yyyy   hh : mm tt";
            this.txtCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCheckOutDate.Location = new System.Drawing.Point(585, 41);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.Size = new System.Drawing.Size(241, 28);
            this.txtCheckOutDate.TabIndex = 50;
            // 
            // txtCName
            // 
            this.txtCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(305, 41);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(248, 28);
            this.txtCName.TabIndex = 49;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // UC_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Records";
            this.Size = new System.Drawing.Size(1356, 559);
            this.Load += new System.EventHandler(this.UC_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myHotelDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.BindingSource myHotelDataSetBindingSource;
        private myHotelDataSet myHotelDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private myHotelDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.BindingSource myHotelDataSet2BindingSource;
        private myHotelDataSet2 myHotelDataSet2;
        private myHotelDataSet2TableAdapters.detailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.BindingSource detailsBindingSource4;
        private System.Windows.Forms.BindingSource roomsBindingSource2;
        private myHotelDataSet2TableAdapters.roomsTableAdapter roomsTableAdapter1;
        private System.Windows.Forms.BindingSource detailsBindingSource1;
        private System.Windows.Forms.BindingSource detailsBindingSource2;
        private System.Windows.Forms.BindingSource detailsBindingSource3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.DateTimePicker txtCheckOutDate;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
