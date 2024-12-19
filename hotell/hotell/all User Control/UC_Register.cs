using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotell.all_User_Control
{
    public partial class UC_Register : UserControl
    {
        function fn = new function();
        String query;
        public UC_Register()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }

            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where roomType ='" + txtRoom.Text + "' and booked = 'NO' ";
            setComboBox(query, txtRoomNo);
        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo ='" + txtRoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());

           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text != "" && txtFirstname.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtIdProof.Text != "" && txtCheckIn.Text != "" && txtAditional.Text != "")
            {
                String lastname = txtLastname.Text;
                String firstname = txtFirstname.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;
                String idproof = txtIdProof.Text;
                String checkin = txtCheckIn.Text;
                String additional = txtAditional.Text;


                query = "insert into details (lastname,firstname,mobile,email,idproof,checkin,additional,roomid) values ('" + lastname + "', '" + firstname + "','" + mobile + "', '" + email + "', '" + idproof + "', '" + checkin + "','" + additional + "'," + rid + ")update rooms set booked = 'YES' where roomNo = '" + txtRoomNo.Text + "'";
                fn.setData(query, "roomNo" + txtRoomNo.Text + " Submitted Successfully.");


            }
            else
            {
                MessageBox.Show("fill All Fields.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll() //clear all items
        {
            txtLastname.Clear();
            txtFirstname.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtIdProof.Clear();
            txtCheckIn.ResetText();
            txtAditional.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();


        }

        private void UC_Register_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void UC_Register_Load(object sender, EventArgs e)
        {
          

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }


