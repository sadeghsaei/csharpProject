using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timesheetRecordSaving
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
            monthCalendar.SetDate(DateTime.Now);
        }

        
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text.Trim()))
            {
                errorProvider.SetError(textBoxName, "Client name is required.");
            }
            else if (string.IsNullOrEmpty(textBoxAddress.Text.Trim()))
            {
                errorProvider1.SetError(textBoxName, "Client Address is required.");
            }
            else
            {
                errorProvider.SetError(textBoxName, string.Empty);
                errorProvider1.SetError(textBoxAddress, string.Empty);


                Record newRecord = new Record();

                long ticks = DateTime.Now.Ticks;
                byte[] bytes = BitConverter.GetBytes(ticks);
                string id = Convert.ToBase64String(bytes)
                                        .Replace('+', 'P')
                                        .Replace('/', 'D')
                                        .Replace('I', 'R')
                                        .Replace('l', 'K')
                                        .TrimEnd('=');
                Console.WriteLine(id);

                newRecord.registrationID = id;
                newRecord.name = textBoxName.Text;
                newRecord.address = textBoxAddress.Text;
                newRecord.date = monthCalendar.SelectionRange.Start;
                newRecord.ivp_id = comboBoxIVP.SelectedIndex;

                MessageBox.Show("Record inserted to DB!\nRegistrationID: " + id);
                DBConnection insertRecordToDB = new DBConnection();
                insertRecordToDB.saveToDB(newRecord);
            }
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            comboBoxIVP.SelectedIndex = 0;
            monthCalendar.SetDate(DateTime.Now);
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxCalendar.Text = monthCalendar.SelectionRange.Start.ToShortDateString();
        }

        private void TextBoxEmpNo_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text.Trim()))
            {
                errorProvider.SetError(textBoxName, "Employee Number is required.");
            }
            else
            {
                errorProvider.SetError(textBoxName, string.Empty);
            }
        }

        private void TextBoxEmpNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxHours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'xYZ_Travel_AgencyDataSet.t_ivp' table. You can move, or remove it, as needed.
            this.t_ivpTableAdapter.Fill(this.xYZ_Travel_AgencyDataSet.t_ivp);

        }
    }
}
