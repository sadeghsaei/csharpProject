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
    public partial class ShowRecords : Form
    {
        public ShowRecords()
        {
            InitializeComponent();

            DBConnection listEmpNo = new DBConnection();
            //string[] empList = listEmpNo.readEmpNoFromDB();


            //foreach (string empno in empList)
            //{
            //    comboBox1.Items.Add(empno);
            //}
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {
                errorProvider.SetError(comboBox1, "Select an EMPno");
            }
            else
            {
                string empno = comboBox1.SelectedItem.ToString();
                DBConnection showSelect = new DBConnection();
                int rowCount = showSelect.recordCount(empno);
                string[,] result = new string[rowCount,3];
                //result = showSelect.readFromDB(empno);
                listBox1.Items.Clear();

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    Record record = new Record();
                    //record.empno = Int32.Parse(result[i, 0]);
                    //record.rDate = result[i, 1];
                    //record.hours = Int32.Parse(result[i, 2]);
                    listBox1.Items.Add(record);
                }
                errorProvider.SetError(comboBox1, string.Empty);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}
