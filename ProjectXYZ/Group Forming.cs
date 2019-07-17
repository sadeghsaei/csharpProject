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
    public partial class Group_Forming : Form
    {
        public Group_Forming()
        {
            InitializeComponent();
        }

        private void Group_Forming_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xYZ_Travel_AgencyDataSet1.t_ivp' table. You can move, or remove it, as needed.
            this.t_ivpTableAdapter.Fill(this.xYZ_Travel_AgencyDataSet1.t_ivp);

        }

        private void ComboBoxIVP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int ivp_count;
            DBConnection dbcon = new DBConnection();
            for(int i = 0; i < dbcon.ivpRecordCount() ; i++)
            {

            }
        }
    }
}
