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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new hotell.function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
           DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtType.Text != "" && txtStatus.Text != "" && txtPrice.Text !="")
            {
                String roomno = txtRoomNo.Text;
                String type = txtType.Text;
                String status = txtStatus.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo,roomType,roomstatus,price) values('"+roomno+ "', '" +type+ "','" +status+ "', '" +price+ "' )";
                fn.setData(query, "Room Added.");

                UC_AddRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
