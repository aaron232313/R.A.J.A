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
    public partial class CustomerDetails : UserControl
    {
        function fn = new function();
        String query;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (txtSearchBy.SelectedIndex == 0)

            {
                query = "SELECT  details.cid,details.lastname, details.firstname, details.mobile, details.email, details.idproof, details.checkin,  details.checkout, details.additional, rooms.roomNo, rooms.roomType, rooms.price FROM details FULL OUTER JOIN rooms ON details.roomid = rooms.roomid ";
                getRecord(query);
                
            }
            else if(txtSearchBy.SelectedIndex == 1)
            {
               query =  "SELECT  details.cid,details.lastname, details.firstname, details.mobile, details.email, details.idproof, details.checkin,  details.checkout, details.additional, rooms.roomNo, rooms.roomType, rooms.price FROM details FULL OUTER JOIN rooms ON details.roomid = rooms.roomid where checkout is null ";
                getRecord(query);
               
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "SELECT  details.cid,details.lastname, details.firstname, details.mobile, details.email, details.idproof, details.checkin,  details.checkout, details.additional, rooms.roomNo, rooms.roomType, rooms.price FROM details FULL OUTER JOIN rooms ON details.roomid = rooms.roomid where checkout is not null ";
                getRecord(query);
                

            }
        }
        private void getRecord(String query)
        {
         DataSet ds = fn.getData(query);
        dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
