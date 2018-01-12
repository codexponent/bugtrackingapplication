namespace BugTrackingApplication {
    partial class DeveloperTable {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.projectComboBox = new MetroFramework.Controls.MetroComboBox();
            this.projectTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingapplicationDataSet = new BugTrackingApplication.bugtrackingapplicationDataSet();
            this.roleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.groupTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupTableTableAdapter = new BugTrackingApplication.bugtrackingapplicationDataSetTableAdapters.groupTableTableAdapter();
            this.projectTableTableAdapter = new BugTrackingApplication.bugtrackingapplicationDataSetTableAdapters.projectTableTableAdapter();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.projectTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(489, 141);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name";
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(593, 141);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(239, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(489, 173);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Project";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(489, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(35, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Role";
            // 
            // projectComboBox
            // 
            this.projectComboBox.DataSource = this.projectTableBindingSource;
            this.projectComboBox.DisplayMember = "projectname";
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.ItemHeight = 23;
            this.projectComboBox.Location = new System.Drawing.Point(593, 170);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(239, 29);
            this.projectComboBox.TabIndex = 2;
            this.projectComboBox.UseSelectable = true;
            // 
            // projectTableBindingSource
            // 
            this.projectTableBindingSource.DataMember = "projectTable";
            this.projectTableBindingSource.DataSource = this.bugtrackingapplicationDataSet;
            // 
            // bugtrackingapplicationDataSet
            // 
            this.bugtrackingapplicationDataSet.DataSetName = "bugtrackingapplicationDataSet";
            this.bugtrackingapplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataSource = this.groupTableBindingSource;
            this.roleComboBox.DisplayMember = "groupname";
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.ItemHeight = 23;
            this.roleComboBox.Location = new System.Drawing.Point(593, 204);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(239, 29);
            this.roleComboBox.TabIndex = 2;
            this.roleComboBox.UseSelectable = true;
            // 
            // groupTableBindingSource
            // 
            this.groupTableBindingSource.DataMember = "groupTable";
            this.groupTableBindingSource.DataSource = this.bugtrackingapplicationDataSet;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(489, 237);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Flag";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(593, 240);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(55, 15);
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Text = "Status";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(613, 270);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(166, 35);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Update";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupTableTableAdapter
            // 
            this.groupTableTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableTableAdapter
            // 
            this.projectTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(24, 64);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Back";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // DeveloperTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 740);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "DeveloperTable";
            this.Text = "DeveloperTable";
            this.Load += new System.EventHandler(this.DeveloperTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox projectComboBox;
        private MetroFramework.Controls.MetroComboBox roleComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private bugtrackingapplicationDataSet bugtrackingapplicationDataSet;
        private System.Windows.Forms.BindingSource groupTableBindingSource;
        private bugtrackingapplicationDataSetTableAdapters.groupTableTableAdapter groupTableTableAdapter;
        private System.Windows.Forms.BindingSource projectTableBindingSource;
        private bugtrackingapplicationDataSetTableAdapters.projectTableTableAdapter projectTableTableAdapter;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}