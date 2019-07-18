namespace timesheetRecordSaving
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllRecordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.groupingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.fileToDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addRecordToolStripMenuItem.Text = "Add Record";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.AddRecordToolStripMenuItem_Click);
            // 
            // fileToDatabaseToolStripMenuItem
            // 
            this.fileToDatabaseToolStripMenuItem.Name = "fileToDatabaseToolStripMenuItem";
            this.fileToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fileToDatabaseToolStripMenuItem.Text = "File to Database";
            this.fileToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.FileToDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Modify Record";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllRecordsToolStripMenuItem1,
            this.displayGroupsToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // displayAllRecordsToolStripMenuItem1
            // 
            this.displayAllRecordsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inFileToolStripMenuItem,
            this.inDBToolStripMenuItem});
            this.displayAllRecordsToolStripMenuItem1.Name = "displayAllRecordsToolStripMenuItem1";
            this.displayAllRecordsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.displayAllRecordsToolStripMenuItem1.Text = "Display All Records";
            // 
            // inFileToolStripMenuItem
            // 
            this.inFileToolStripMenuItem.Name = "inFileToolStripMenuItem";
            this.inFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inFileToolStripMenuItem.Text = "From Text File";
            this.inFileToolStripMenuItem.Click += new System.EventHandler(this.InFileToolStripMenuItem_Click);
            // 
            // inDBToolStripMenuItem
            // 
            this.inDBToolStripMenuItem.Name = "inDBToolStripMenuItem";
            this.inDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inDBToolStripMenuItem.Text = "From Database";
            this.inDBToolStripMenuItem.Click += new System.EventHandler(this.InDBToolStripMenuItem_Click);
            // 
            // displayGroupsToolStripMenuItem
            // 
            this.displayGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromDatabaseToolStripMenuItem});
            this.displayGroupsToolStripMenuItem.Name = "displayGroupsToolStripMenuItem";
            this.displayGroupsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayGroupsToolStripMenuItem.Text = "Display Groups";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fromFileToolStripMenuItem.Text = "From File";
            // 
            // fromDatabaseToolStripMenuItem
            // 
            this.fromDatabaseToolStripMenuItem.Name = "fromDatabaseToolStripMenuItem";
            this.fromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fromDatabaseToolStripMenuItem.Text = "From Database";
            // 
            // groupingToolStripMenuItem
            // 
            this.groupingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.groupingToolStripMenuItem.Name = "groupingToolStripMenuItem";
            this.groupingToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.groupingToolStripMenuItem.Text = "Grouping";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Group Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 549);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " XYZ Travel Agency";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllRecordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

