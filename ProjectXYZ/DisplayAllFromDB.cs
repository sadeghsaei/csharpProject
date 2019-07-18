using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timesheetRecordSaving
{
    public partial class DisplayAllFromDB : Form
    {
        public DisplayAllFromDB()
        {
            InitializeComponent();
        }

        private void DisplayAllFromDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xYZ_Travel_AgencyDataSet11.t_userinfo' table. You can move, or remove it, as needed.
            //this.t_userinfoTableAdapter.Fill(this.xYZ_Travel_AgencyDataSet11.t_userinfo);
            // TODO: This line of code loads data into the 'xYZ_Travel_AgencyDataSet1.t_userinfo' table. You can move, or remove it, as needed.
            //this.t_userinfoTableAdapter.Fill(this.xYZ_Travel_AgencyDataSet1.t_userinfo);

            DBConnection dbcon = new DBConnection();
            DataSet ds = dbcon.ShowAllRecordsFromDB();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
