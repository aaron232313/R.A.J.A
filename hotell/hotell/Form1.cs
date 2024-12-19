using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerDetails1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_Records1.Visible = false;
            uC_Register1.Visible = true;
            uC_Employee1.Visible = false;
            btnRegister.PerformClick();

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_Records1.Visible = true;
            uC_Register1.Visible = false;
            uC_Employee1.Visible = false;
            uC_Records1.BringToFront();
           
        }

        private void btnAddroom_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = false;
            uC_Records1.Visible = false;
            uC_AddRoom1.Visible = true;
            uC_Register1.Visible = false;
            uC_Employee1.Visible = false;
            uC_AddRoom1.BringToFront();
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = false;
            uC_Records1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_Register1.Visible = true;
            uC_Employee1.Visible = false;
            uC_Register1.BringToFront();

        }

        private void uC_Register1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_Records1.Visible = false;
            uC_Register1.Visible = false;
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();

        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = true;
            uC_AddRoom1.Visible = false;
            uC_Records1.Visible = false;
            uC_Register1.Visible = false;
            uC_Employee1.Visible = false;
           customerDetails1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user selects "No", cancel the logout
            if (result == DialogResult.No)
            {
                return;
            }

            // Show confirmation message
            MessageBox.Show("You have been successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to login form
            var Form2 = new Form2();
            Form2.Show();
            this.Hide();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
