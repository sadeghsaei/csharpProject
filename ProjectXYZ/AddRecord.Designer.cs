﻿namespace timesheetRecordSaving
{
    partial class AddRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxCalendar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxIVP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.xYZ_Travel_AgencyDataSet = new timesheetRecordSaving.XYZ_Travel_AgencyDataSet();
            this.tivpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ivpTableAdapter = new timesheetRecordSaving.XYZ_Travel_AgencyDataSetTableAdapters.t_ivpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tivpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(140, 44);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(131, 67);
            this.textBoxAddress.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Client Address";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 366);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxCalendar
            // 
            this.textBoxCalendar.Location = new System.Drawing.Point(140, 147);
            this.textBoxCalendar.Name = "textBoxCalendar";
            this.textBoxCalendar.ReadOnly = true;
            this.textBoxCalendar.Size = new System.Drawing.Size(131, 20);
            this.textBoxCalendar.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxIVP
            // 
            this.comboBoxIVP.DataSource = this.tivpBindingSource;
            this.comboBoxIVP.DisplayMember = "name";
            this.comboBoxIVP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIVP.FormattingEnabled = true;
            this.comboBoxIVP.Location = new System.Drawing.Point(140, 120);
            this.comboBoxIVP.Name = "comboBoxIVP";
            this.comboBoxIVP.Size = new System.Drawing.Size(131, 21);
            this.comboBoxIVP.TabIndex = 4;
            this.comboBoxIVP.ValueMember = "ivp_id";
            this.comboBoxIVP.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHours_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " Interested Vacation Plan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(140, 18);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxEmpNo_TextChanged);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEmpNo_Validating_1);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(32, 192);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 5;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // xYZ_Travel_AgencyDataSet
            // 
            this.xYZ_Travel_AgencyDataSet.DataSetName = "XYZ_Travel_AgencyDataSet";
            this.xYZ_Travel_AgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tivpBindingSource
            // 
            this.tivpBindingSource.DataMember = "t_ivp";
            this.tivpBindingSource.DataSource = this.xYZ_Travel_AgencyDataSet;
            // 
            // t_ivpTableAdapter
            // 
            this.t_ivpTableAdapter.ClearBeforeFill = true;
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 427);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCalendar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxIVP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "AddRecord";
            this.Text = "Add Record";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tivpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBoxCalendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxIVP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private XYZ_Travel_AgencyDataSet xYZ_Travel_AgencyDataSet;
        private System.Windows.Forms.BindingSource tivpBindingSource;
        private XYZ_Travel_AgencyDataSetTableAdapters.t_ivpTableAdapter t_ivpTableAdapter;
    }
}