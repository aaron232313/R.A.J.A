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
    public partial class Form2 : Form
    {
        function fn = new function();
        String query;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username = '" + txtUsername.Text + "' and pass = '" + txtPass.Text + "'";
            DataSet ds = fn.getData(query);


            if (ds.Tables[0].Rows.Count != 0)
            {
                Form1 dash = new Form1();
                this.Hide();
                dash.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPass.Clear();
            }
        }
    }
}
