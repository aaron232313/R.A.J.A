using System;
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
    public partial class UC_Records : UserControl
    {
        function fn = new function();
        String query;
        public UC_Records()
        {
            InitializeComponent();
        }

        private void UC_Records_Load(object sender, EventArgs e)
        {
            query = "SELECT details.cid,details.lastname, details.firstname, details.mobile, details.email, details.idproof, details.checkin, details.additional, rooms.roomNo, rooms.roomType, rooms.price FROM details FULL OUTER JOIN rooms ON details.roomid = rooms.roomid where chekout ='NO'";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
            DataGridView1.Refresh();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT  details.cid,details.lastname, details.firstname, details.mobile, details.email, details.idproof, details.checkin, details.additional, rooms.roomNo, rooms.roomType, rooms.price FROM details FULL OUTER JOIN rooms ON details.roomid = rooms.roomid where lastname like '" + txtName.Text + "%' and chekout = 'NO' ";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
           
        }
        int id;
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                
            {
                id = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
               
            }
            DataGridView1.Refresh();
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if(MessageBox.Show("Are You Sure?","Confirmantion",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update details set chekout = 'YES',checkout='"+cdate+"' where cid ="+id+"update rooms set booked ='NO' where roomNo ='"+txtRoom.Text+"' ";
                    fn.setData(query, "Check Out Successfully");
                    UC_Records_Load(this, null);
                    clearAll();
                }
                
            }
            else
            {
                MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
