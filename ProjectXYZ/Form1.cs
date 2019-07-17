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
            //throw new NotImplementedException();
            formAddRecord = null;
        }

        ShowRecords formShowRecord;
        private void ShowRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formShowRecord == null)
            {
                formShowRecord = new ShowRecords();
                formShowRecord.MdiParent = this;
                formShowRecord.FormClosed += new FormClosedEventHandler(formShowRecord_FormClosed);
                formShowRecord.Show();
            }
            else
            {
                formShowRecord.Activate();
            }
        }

        private void formShowRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            formShowRecord = null;
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

        ShowAllRecords showAll;
        private void DisplayAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showAll == null)
            {
                showAll = new ShowAllRecords();
                showAll.MdiParent = this;
                showAll.FormClosed += ShowAll_FormClosed; ;
                showAll.Show();
            }
            else
            {
                showAll.Activate();
            }
        }

        private void ShowAll_FormClosed(object sender, FormClosedEventArgs e)
        {
            showAll = null;
        }
    }
}
