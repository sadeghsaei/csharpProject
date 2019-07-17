namespace timesheetRecordSaving
{
    partial class Group_Forming
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
            this.label2 = new System.Windows.Forms.Label();
            this.xYZ_Travel_AgencyDataSet = new timesheetRecordSaving.XYZ_Travel_AgencyDataSet();
            this.xYZTravelAgencyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xYZ_Travel_AgencyDataSet1 = new timesheetRecordSaving.XYZ_Travel_AgencyDataSet1();
            this.tivpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ivpTableAdapter = new timesheetRecordSaving.XYZ_Travel_AgencyDataSet1TableAdapters.t_ivpTableAdapter();
            this.textBoxNumberOfClients = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZTravelAgencyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tivpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select number of clients in each group";
            // 
            // xYZ_Travel_AgencyDataSet
            // 
            this.xYZ_Travel_AgencyDataSet.DataSetName = "XYZ_Travel_AgencyDataSet";
            this.xYZ_Travel_AgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xYZTravelAgencyDataSetBindingSource
            // 
            this.xYZTravelAgencyDataSetBindingSource.DataSource = this.xYZ_Travel_AgencyDataSet;
            this.xYZTravelAgencyDataSetBindingSource.Position = 0;
            // 
            // xYZ_Travel_AgencyDataSet1
            // 
            this.xYZ_Travel_AgencyDataSet1.DataSetName = "XYZ_Travel_AgencyDataSet1";
            this.xYZ_Travel_AgencyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tivpBindingSource
            // 
            this.tivpBindingSource.DataMember = "t_ivp";
            this.tivpBindingSource.DataSource = this.xYZ_Travel_AgencyDataSet1;
            // 
            // t_ivpTableAdapter
            // 
            this.t_ivpTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxNumberOfClients
            // 
            this.textBoxNumberOfClients.Location = new System.Drawing.Point(207, 29);
            this.textBoxNumberOfClients.Name = "textBoxNumberOfClients";
            this.textBoxNumberOfClients.Size = new System.Drawing.Size(52, 20);
            this.textBoxNumberOfClients.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Group_Forming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 141);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNumberOfClients);
            this.Controls.Add(this.label2);
            this.Name = "Group_Forming";
            this.Text = "Group_Forming";
            this.Load += new System.EventHandler(this.Group_Forming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZTravelAgencyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xYZ_Travel_AgencyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tivpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource xYZTravelAgencyDataSetBindingSource;
        private XYZ_Travel_AgencyDataSet xYZ_Travel_AgencyDataSet;
        private XYZ_Travel_AgencyDataSet1 xYZ_Travel_AgencyDataSet1;
        private System.Windows.Forms.BindingSource tivpBindingSource;
        private XYZ_Travel_AgencyDataSet1TableAdapters.t_ivpTableAdapter t_ivpTableAdapter;
        private System.Windows.Forms.TextBox textBoxNumberOfClients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}