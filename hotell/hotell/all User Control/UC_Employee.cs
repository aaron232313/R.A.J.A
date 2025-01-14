﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotell.all_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMAXID();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtMobile.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                String gender = txtGender.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;

                query = "insert into employee (ename,gender,mobile,emailid,username,pass)values('" + name + "','" + gender + "', '" + mobile + "', '" + email + "','" + username + "', '" + pass + "') ";
                fn.setData(query, "Employee Registered");

                clearAll();
                getMAXID();


            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(dataGridView1);

            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(dataGridView2);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "Delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Record deleted.");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        //=========================================================REQUIRED METHOD============================================================
        public void getMAXID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();

            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtMobile.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        public void setEmployee(DataGridView dgv)
        {
            query = " select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

      
    }
}
