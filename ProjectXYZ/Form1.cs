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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AddRecord formAddRecord;
        private void AddRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(formAddRecord == null)
            {
                formAddRecord = new AddRecord();
                formAddRecord.MdiParent = this;
                formAddRecord.FormClosed += new FormClosedEventHandler(formAddRecord_FormClosed);
                formAddRecord.Show();
            }
            else
            {
                formAddRecord.Activate();
            }
        }

        private void formAddRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAddRecord = null;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Modify modifyForm;
        private void ModifyRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyForm == null)
            {
                modifyForm = new Modify();
                modifyForm.MdiParent = this;
                modifyForm.FormClosed += ModifyForm_FormClosed;
                modifyForm.Show();
            }
            else
            {
                modifyForm.Activate();
            }
        }

        private void ModifyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            modifyForm = null;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (modifyForm == null)
            {
                modifyForm = new Modify();
                modifyForm.MdiParent = this;
                modifyForm.FormClosed += ModifyForm_FormClosed;
                modifyForm.Show();
            }
            else
            {
                modifyForm.Activate();
            }
        }

        FileToDB filetodb;
        private void FileToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filetodb == null)
            {
                filetodb = new FileToDB();
                filetodb.MdiParent = this;
                filetodb.FormClosed += Filetodb_FormClosed;
                filetodb.Show();
            }
            else
            {
                filetodb.Activate();
            }
        }

        private void Filetodb_FormClosed(object sender, FormClosedEventArgs e)
        {
            filetodb = null;
        }

        DisplayAllFromFile DisplayFromFile;
        private void InFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DisplayFromDB == null)
            {
                DisplayFromFile = new DisplayAllFromFile();
                DisplayFromFile.MdiParent = this;
                DisplayFromFile.FormClosed += DisplayFromFile_FormClosed; ;
                DisplayFromFile.Show();
            }
            else
            {
                DisplayFromFile.Activate();
            }
        }

        private void DisplayFromFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplayFromFile = null;
        }

        DisplayAllFromDB DisplayFromDB;
        private void InDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DisplayFromDB == null)
            {
                DisplayFromDB = new DisplayAllFromDB();
                DisplayFromDB.MdiParent = this;
                DisplayFromDB.FormClosed += DisplayFromDB_FormClosed;
                DisplayFromDB.Show();
            }
            else
            {
                DisplayFromDB.Activate();
            }
        }

        private void DisplayFromDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplayFromDB = null;
        }
    }
}
