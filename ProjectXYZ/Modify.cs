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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xYZ_Travel_AgencyDataSet.t_ivp' table. You can move, or remove it, as needed.
            this.t_ivpTableAdapter.Fill(this.xYZ_Travel_AgencyDataSet.t_ivp);
            textBoxName.Enabled = false;
            textBoxAddress.Enabled = false;
            comboBoxIVP.Enabled = false;
            monthCalendar.Enabled = false;
            textBoxCalendar.Enabled = false;
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRegistrationID.Text.Trim()))
            {
                errorProvider1.SetError(textBoxRegistrationID, "Registration ID is required.");
            }
            else
            {
                errorProvider1.SetError(textBoxRegistrationID, string.Empty);

                string registrationID = textBoxRegistrationID.Text;

                DBConnection readFromDB = new DBConnection();
                Record result = readFromDB.searchRecord(registrationID);
                if(result.registrationID == "0")
                {
                    MessageBox.Show("No record found");
                }
                else
                {
                    textBoxRegistrationID.Enabled = false;
                    textBoxName.Enabled = true;
                    textBoxAddress.Enabled = true;
                    comboBoxIVP.Enabled = true;
                    monthCalendar.Enabled = true;
                    textBoxCalendar.Enabled = true;
                    textBoxName.Text = result.name;
                    textBoxAddress.Text = result.address;
                    comboBoxIVP.SelectedIndex = result.ivp_id;
                    monthCalendar.SetDate(result.date);
                    textBoxCalendar.Text = monthCalendar.SelectionRange.Start.ToShortDateString();
                }
                
            }
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxCalendar.Text = monthCalendar.SelectionRange.Start.ToShortDateString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxRegistrationID.Enabled = true;
            textBoxName.Enabled = false;
            textBoxAddress.Enabled = false;
            comboBoxIVP.Enabled = false;
            monthCalendar.Enabled = false;
            textBoxCalendar.Enabled = false;
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            comboBoxIVP.SelectedIndex = 0;
            monthCalendar.SetDate(DateTime.Now);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text.Trim()))
            {
                errorProvider1.SetError(textBoxName, "Client name is required.");
            }
            else if (string.IsNullOrEmpty(textBoxAddress.Text.Trim()))
            {
                errorProvider1.SetError(textBoxName, "Client Address is required.");
            }
            else
            {
                errorProvider1.SetError(textBoxName, string.Empty);
                errorProvider1.SetError(textBoxAddress, string.Empty);

                string id = textBoxRegistrationID.Text;
                Record newRecord = new Record();

                newRecord.registrationID = id;
                newRecord.name = textBoxName.Text;
                newRecord.address = textBoxAddress.Text;
                newRecord.date = monthCalendar.SelectionRange.Start;
                newRecord.ivp_id = comboBoxIVP.SelectedIndex;

                MessageBox.Show("Record Modified!\nRegistrationID: " + id);
                DBConnection insertRecordToDB = new DBConnection();
                insertRecordToDB.modifyRecord(newRecord);
            }
        }
    }
}
