namespace BugTrackingApplication {
    partial class BugStatus {
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bugNameTextBox = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.noteTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.folderName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(288, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Bug Name";
            // 
            // bugNameTextBox
            // 
            this.bugNameTextBox.AutoSize = true;
            this.bugNameTextBox.Location = new System.Drawing.Point(375, 159);
            this.bugNameTextBox.Name = "bugNameTextBox";
            this.bugNameTextBox.Size = new System.Drawing.Size(18, 19);
            this.bugNameTextBox.TabIndex = 1;
            this.bugNameTextBox.Text = "...";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(193, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(167, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Developers Note (Commit)";
            // 
            // noteTextBox
            // 
            // 
            // 
            // 
            this.noteTextBox.CustomButton.Image = null;
            this.noteTextBox.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.noteTextBox.CustomButton.Name = "";
            this.noteTextBox.CustomButton.Size = new System.Drawing.Size(151, 151);
            this.noteTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noteTextBox.CustomButton.TabIndex = 1;
            this.noteTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noteTextBox.CustomButton.UseSelectable = true;
            this.noteTextBox.CustomButton.Visible = false;
            this.noteTextBox.Lines = new string[0];
            this.noteTextBox.Location = new System.Drawing.Point(376, 190);
            this.noteTextBox.MaxLength = 32767;
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.PasswordChar = '\0';
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noteTextBox.SelectedText = "";
            this.noteTextBox.SelectionLength = 0;
            this.noteTextBox.SelectionStart = 0;
            this.noteTextBox.ShortcutsEnabled = true;
            this.noteTextBox.Size = new System.Drawing.Size(369, 153);
            this.noteTextBox.TabIndex = 2;
            this.noteTextBox.UseSelectable = true;
            this.noteTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noteTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(818, 222);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Flag";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(867, 226);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(55, 15);
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Text = "Status";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(702, 380);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(159, 46);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(975, 245);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(105, 36);
            this.metroButton2.TabIndex = 6;
            this.metroButton2.Text = "Push to Git";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(769, 195);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "FolderName";
            // 
            // folderName
            // 
            // 
            // 
            // 
            this.folderName.CustomButton.Image = null;
            this.folderName.CustomButton.Location = new System.Drawing.Point(348, 1);
            this.folderName.CustomButton.Name = "";
            this.folderName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.folderName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.folderName.CustomButton.TabIndex = 1;
            this.folderName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.folderName.CustomButton.UseSelectable = true;
            this.folderName.CustomButton.Visible = false;
            this.folderName.Lines = new string[0];
            this.folderName.Location = new System.Drawing.Point(867, 190);
            this.folderName.MaxLength = 32767;
            this.folderName.Name = "folderName";
            this.folderName.PasswordChar = '\0';
            this.folderName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.folderName.SelectedText = "";
            this.folderName.SelectionLength = 0;
            this.folderName.SelectionStart = 0;
            this.folderName.ShortcutsEnabled = true;
            this.folderName.Size = new System.Drawing.Size(370, 23);
            this.folderName.TabIndex = 7;
            this.folderName.UseSelectable = true;
            this.folderName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.folderName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.folderName.Click += new System.EventHandler(this.folderName_Click);
            // 
            // BugStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 740);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.bugNameTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Name = "BugStatus";
            this.Text = "BugStatus";
            this.Load += new System.EventHandler(this.BugStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel bugNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox noteTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox folderName;
    }
}