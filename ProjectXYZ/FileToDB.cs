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
    public partial class FileToDB : Form
    {
        public FileToDB()
        {
            InitializeComponent();
        }
        string fileLocation;
        private void Button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label3.Text = openFileDialog1.FileName;
                fileLocation = openFileDialog1.FileName;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            string path = fileLocation;     //Path of the file
            List<Record> recordList = new List<Record>();        //This list will hold all the records
            DBConnection dbcon = new DBConnection();
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);   //Reading all lines in the file at once (open as well as close)
                int h = 0;
                foreach (string line in lines)
                {
                    string[] col = line.Split(new char[] { ',' });      //content of lines will be divided on the basis "," and placed in array
                    Record tmp = new Record();
                    
                    long ticks = DateTime.Now.Ticks;
                    ticks += h++;
                    byte[] bytes = BitConverter.GetBytes(ticks);
                    string id = Convert.ToBase64String(bytes)
                                            .Replace('+', 'P')
                                            .Replace('/', 'D')
                                            .Replace('I', 'R')
                                            .Replace('l', 'K')
                                            .TrimEnd('=');
                    
                    tmp.registrationID = id;
                    tmp.name = col[0] + col[1];
                    tmp.address = " ";
                    tmp.ivp_id = dbcon.findIVP(col[2]);
                    string a = col[3].Substring(0, 4);
                    string b = col[3].Substring(4);
                    if (a == "Jan")
                        a = "January";
                    if (a == "Feb")
                        a = "February";
                    if (a == "Mar")
                        a = "March";
                    if (a == "Apr")
                        a = "April";
                    if (a == "Jun")
                        a = "June";
                    if (a == "Jul")
                        a = "July";
                    if (a == "Aug")
                        a = "August";
                    if (a == "Sep")
                        a = "September";
                    if (a == "Oct")
                        a = "October";
                    if (a == "Nov")
                        a = "November";
                    if (a == "Dec")
                        a = "December";
                    string currentYear = DateTime.Now.Year.ToString();
                    string c = a + " " + b + " " + currentYear;
                    tmp.date = Convert.ToDateTime(c);
                    recordList.Add(tmp);
                }
                for (int i = 0; i < recordList.Count; i++)
                    dbcon.saveToDB(recordList[i]);

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
