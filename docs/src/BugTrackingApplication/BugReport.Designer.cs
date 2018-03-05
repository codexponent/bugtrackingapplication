namespace BugTrackingApplication {
    partial class BugReport {
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
            this.projectTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingapplicationDataSet = new BugTrackingApplication.bugtrackingapplicationDataSet();
            this.projectTableTableAdapter = new BugTrackingApplication.bugtrackingapplicationDataSetTableAdapters.projectTableTableAdapter();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new BugTrackingApplication.bugtrackingapplicationDataSetTableAdapters.userTableTableAdapter();
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bugNameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.reportButton = new MetroFramework.Controls.MetroButton();
            this.bugDescriptionBox = new MetroFramework.Controls.MetroTextBox();
            this.gitButton = new MetroFramework.Controls.MetroButton();
            this.projectTextBox = new MetroFramework.Controls.MetroComboBox();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.developerNoteTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uploadImage = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.projectTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // projectTableTableAdapter
            // 
            this.projectTableTableAdapter.ClearBeforeFill = true;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "userTable";
            this.userTableBindingSource.DataSource = this.bugtrackingapplicationDataSet;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.IsReadOnly = false;
            this.textEditorControl1.Location = new System.Drawing.Point(694, 183);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(454, 151);
            this.textEditorControl1.TabIndex = 4;
            this.textEditorControl1.Text = "Syntax Here";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(635, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Bug Name";
            // 
            // bugNameBox
            // 
            // 
            // 
            // 
            this.bugNameBox.CustomButton.Image = null;
            this.bugNameBox.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.bugNameBox.CustomButton.Name = "";
            this.bugNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.bugNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bugNameBox.CustomButton.TabIndex = 1;
            this.bugNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bugNameBox.CustomButton.UseSelectable = true;
            this.bugNameBox.CustomButton.Visible = false;
            this.bugNameBox.Lines = new string[0];
            this.bugNameBox.Location = new System.Drawing.Point(581, 102);
            this.bugNameBox.MaxLength = 32767;
            this.bugNameBox.Name = "bugNameBox";
            this.bugNameBox.PasswordChar = '\0';
            this.bugNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bugNameBox.SelectedText = "";
            this.bugNameBox.SelectionLength = 0;
            this.bugNameBox.SelectionStart = 0;
            this.bugNameBox.ShortcutsEnabled = true;
            this.bugNameBox.Size = new System.Drawing.Size(210, 23);
            this.bugNameBox.TabIndex = 1;
            this.bugNameBox.UseSelectable = true;
            this.bugNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bugNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(444, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Bug Description";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(548, 533);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Project";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(548, 568);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Developer";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(873, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Syntax";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(635, 605);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(127, 37);
            this.reportButton.TabIndex = 7;
            this.reportButton.Text = "Report ";
            this.reportButton.UseSelectable = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click_1);
            // 
            // bugDescriptionBox
            // 
            // 
            // 
            // 
            this.bugDescriptionBox.CustomButton.Image = null;
            this.bugDescriptionBox.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.bugDescriptionBox.CustomButton.Name = "";
            this.bugDescriptionBox.CustomButton.Size = new System.Drawing.Size(143, 143);
            this.bugDescriptionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bugDescriptionBox.CustomButton.TabIndex = 1;
            this.bugDescriptionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bugDescriptionBox.CustomButton.UseSelectable = true;
            this.bugDescriptionBox.CustomButton.Visible = false;
            this.bugDescriptionBox.Lines = new string[0];
            this.bugDescriptionBox.Location = new System.Drawing.Point(338, 186);
            this.bugDescriptionBox.MaxLength = 32767;
            this.bugDescriptionBox.Multiline = true;
            this.bugDescriptionBox.Name = "bugDescriptionBox";
            this.bugDescriptionBox.PasswordChar = '\0';
            this.bugDescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bugDescriptionBox.SelectedText = "";
            this.bugDescriptionBox.SelectionLength = 0;
            this.bugDescriptionBox.SelectionStart = 0;
            this.bugDescriptionBox.ShortcutsEnabled = true;
            this.bugDescriptionBox.Size = new System.Drawing.Size(326, 148);
            this.bugDescriptionBox.TabIndex = 2;
            this.bugDescriptionBox.UseSelectable = true;
            this.bugDescriptionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bugDescriptionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gitButton
            // 
            this.gitButton.Location = new System.Drawing.Point(716, 148);
            this.gitButton.Name = "gitButton";
            this.gitButton.Size = new System.Drawing.Size(75, 23);
            this.gitButton.TabIndex = 3;
            this.gitButton.Text = "Git";
            this.gitButton.UseSelectable = true;
            this.gitButton.Click += new System.EventHandler(this.gitButton_Click_1);
            // 
            // projectTextBox
            // 
            this.projectTextBox.FormattingEnabled = true;
            this.projectTextBox.ItemHeight = 23;
            this.projectTextBox.Location = new System.Drawing.Point(635, 533);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(206, 29);
            this.projectTextBox.TabIndex = 5;
            this.projectTextBox.UseSelectable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(635, 568);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 29);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "C#",
            "HTML",
            "XML"});
            this.metroComboBox1.Location = new System.Drawing.Point(1027, 148);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(635, 348);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(102, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Developer Note";
            // 
            // developerNoteTextBox
            // 
            // 
            // 
            // 
            this.developerNoteTextBox.CustomButton.Image = null;
            this.developerNoteTextBox.CustomButton.Location = new System.Drawing.Point(180, 2);
            this.developerNoteTextBox.CustomButton.Name = "";
            this.developerNoteTextBox.CustomButton.Size = new System.Drawing.Size(143, 143);
            this.developerNoteTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.developerNoteTextBox.CustomButton.TabIndex = 1;
            this.developerNoteTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.developerNoteTextBox.CustomButton.UseSelectable = true;
            this.developerNoteTextBox.CustomButton.Visible = false;
            this.developerNoteTextBox.Lines = new string[0];
            this.developerNoteTextBox.Location = new System.Drawing.Point(530, 370);
            this.developerNoteTextBox.MaxLength = 32767;
            this.developerNoteTextBox.Multiline = true;
            this.developerNoteTextBox.Name = "developerNoteTextBox";
            this.developerNoteTextBox.PasswordChar = '\0';
            this.developerNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.developerNoteTextBox.SelectedText = "";
            this.developerNoteTextBox.SelectionLength = 0;
            this.developerNoteTextBox.SelectionStart = 0;
            this.developerNoteTextBox.ShortcutsEnabled = true;
            this.developerNoteTextBox.Size = new System.Drawing.Size(326, 148);
            this.developerNoteTextBox.TabIndex = 2;
            this.developerNoteTextBox.UseSelectable = true;
            this.developerNoteTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.developerNoteTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(449, 370);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(75, 23);
            this.uploadImage.TabIndex = 14;
            this.uploadImage.Text = "Upload";
            this.uploadImage.UseSelectable = true;
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // BugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 740);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.projectTextBox);
            this.Controls.Add(this.gitButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.developerNoteTextBox);
            this.Controls.Add(this.bugDescriptionBox);
            this.Controls.Add(this.bugNameBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.textEditorControl1);
            this.Name = "BugReport";
            this.Text = "Bug Report";
            this.Load += new System.EventHandler(this.BugReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bugtrackingapplicationDataSet bugtrackingapplicationDataSet;
        private System.Windows.Forms.BindingSource projectTableBindingSource;
        private bugtrackingapplicationDataSetTableAdapters.projectTableTableAdapter projectTableTableAdapter;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private bugtrackingapplicationDataSetTableAdapters.userTableTableAdapter userTableTableAdapter;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox bugNameBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton reportButton;
        private MetroFramework.Controls.MetroTextBox bugDescriptionBox;
        private MetroFramework.Controls.MetroButton gitButton;
        private MetroFramework.Controls.MetroComboBox projectTextBox;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox developerNoteTextBox;
        private MetroFramework.Controls.MetroButton uploadImage;
    }
}