namespace timesheetRecordSaving
{
    partial class DisplayAllFromDB
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xYZ_Travel_AgencyDataSet1 = new timesheetRecordSaving.XYZ_Travel_AgencyDataSet1();
            this.tuserinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_userinfoTableAdapter = new timesheetRecordSaving.XYZ_Travel_AgencyDataSet1TableAdapters.t_userinfoTableAdapter();
            this.xYZ_Travel_AgencyDataSet11 = new timesheetRecordSaving.XYZ_Travel_AgencyDataSet1();
            this.xYZTravelAgencyDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tuserinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new timesheetRecordSaving.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuserinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZTravelAgencyDataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuserinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(566, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // xYZ_Travel_AgencyDataSet1
            // 
            this.xYZ_Travel_AgencyDataSet1.DataSetName = "XYZ_Travel_AgencyDataSet1";
            this.xYZ_Travel_AgencyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tuserinfoBindingSource
            // 
            this.tuserinfoBindingSource.DataMember = "t_userinfo";
            this.tuserinfoBindingSource.DataSource = this.xYZ_Travel_AgencyDataSet1;
            // 
            // t_userinfoTableAdapter
            // 
            this.t_userinfoTableAdapter.ClearBeforeFill = true;
            // 
            // xYZ_Travel_AgencyDataSet11
            // 
            this.xYZ_Travel_AgencyDataSet11.DataSetName = "XYZ_Travel_AgencyDataSet1";
            this.xYZ_Travel_AgencyDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xYZTravelAgencyDataSet11BindingSource
            // 
            this.xYZTravelAgencyDataSet11BindingSource.DataSource = this.xYZ_Travel_AgencyDataSet11;
            this.xYZTravelAgencyDataSet11BindingSource.Position = 0;
            // 
            // tuserinfoBindingSource1
            // 
            this.tuserinfoBindingSource1.DataMember = "t_userinfo";
            this.tuserinfoBindingSource1.DataSource = this.xYZTravelAgencyDataSet11BindingSource;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DisplayAllFromDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayAllFromDB";
            this.Text = "DisplayAllFromDB";
            this.Load += new System.EventHandler(this.DisplayAllFromDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuserinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZTravelAgencyDataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuserinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private XYZ_Travel_AgencyDataSet1 xYZ_Travel_AgencyDataSet1;
        private System.Windows.Forms.BindingSource tuserinfoBindingSource;
        private XYZ_Travel_AgencyDataSet1TableAdapters.t_userinfoTableAdapter t_userinfoTableAdapter;
        private System.Windows.Forms.BindingSource xYZTravelAgencyDataSet11BindingSource;
        private XYZ_Travel_AgencyDataSet1 xYZ_Travel_AgencyDataSet11;
        private System.Windows.Forms.BindingSource tuserinfoBindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Button button1;
    }
}