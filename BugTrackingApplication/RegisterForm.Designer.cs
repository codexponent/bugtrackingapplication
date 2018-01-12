namespace BugTrackingApplication {
    partial class RegisterForm {
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
            this.groupTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtrackingapplicationDataSet = new BugTrackingApplication.bugtrackingapplicationDataSet();
            this.groupTableTableAdapter = new BugTrackingApplication.bugtrackingapplicationDataSetTableAdapters.groupTableTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.genderTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.addressTextBox = new MetroFramework.Controls.MetroTextBox();
            this.roleTextBox = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.registerButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.rePasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.projectTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectTableTableAdapter = new BugTrackingApplication.bugtrackingapplicationDataSetTableAdapters.projectTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTableBindingSource
            // 
            this.groupTableBindingSource.DataMember = "groupTable";
            this.groupTableBindingSource.DataSource = this.bugtrackingapplicationDataSet;
            // 
            // bugtrackingapplicationDataSet
            // 
            this.bugtrackingapplicationDataSet.DataSetName = "bugtrackingapplicationDataSet";
            this.bugtrackingapplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupTableTableAdapter
            // 
            this.groupTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(463, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Name";
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(514, 112);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(230, 23);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(433, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "User Name";
            // 
            // userNameTextBox
            // 
            // 
            // 
            // 
            this.userNameTextBox.CustomButton.Image = null;
            this.userNameTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.userNameTextBox.CustomButton.Name = "";
            this.userNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBox.CustomButton.TabIndex = 1;
            this.userNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBox.CustomButton.UseSelectable = true;
            this.userNameTextBox.CustomButton.Visible = false;
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(514, 140);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(230, 23);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.UseSelectable = true;
            this.userNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(463, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Email";
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.CustomButton.Image = null;
            this.emailTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.emailTextBox.CustomButton.Name = "";
            this.emailTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTextBox.CustomButton.TabIndex = 1;
            this.emailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTextBox.CustomButton.UseSelectable = true;
            this.emailTextBox.CustomButton.Visible = false;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(514, 169);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.ShortcutsEnabled = true;
            this.emailTextBox.Size = new System.Drawing.Size(230, 23);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.UseSelectable = true;
            this.emailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(445, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Password";
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(514, 198);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(230, 23);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(456, 256);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Gender";
            // 
            // genderTextBox
            // 
            // 
            // 
            // 
            this.genderTextBox.CustomButton.Image = null;
            this.genderTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.genderTextBox.CustomButton.Name = "";
            this.genderTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.genderTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.genderTextBox.CustomButton.TabIndex = 1;
            this.genderTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.genderTextBox.CustomButton.UseSelectable = true;
            this.genderTextBox.CustomButton.Visible = false;
            this.genderTextBox.Lines = new string[0];
            this.genderTextBox.Location = new System.Drawing.Point(514, 256);
            this.genderTextBox.MaxLength = 32767;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.PasswordChar = '\0';
            this.genderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.genderTextBox.SelectedText = "";
            this.genderTextBox.SelectionLength = 0;
            this.genderTextBox.SelectionStart = 0;
            this.genderTextBox.ShortcutsEnabled = true;
            this.genderTextBox.Size = new System.Drawing.Size(230, 23);
            this.genderTextBox.TabIndex = 6;
            this.genderTextBox.UseSelectable = true;
            this.genderTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.genderTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(448, 285);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Address";
            // 
            // addressTextBox
            // 
            // 
            // 
            // 
            this.addressTextBox.CustomButton.Image = null;
            this.addressTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.addressTextBox.CustomButton.Name = "";
            this.addressTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addressTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addressTextBox.CustomButton.TabIndex = 1;
            this.addressTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addressTextBox.CustomButton.UseSelectable = true;
            this.addressTextBox.CustomButton.Visible = false;
            this.addressTextBox.Lines = new string[0];
            this.addressTextBox.Location = new System.Drawing.Point(514, 285);
            this.addressTextBox.MaxLength = 32767;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.SelectionLength = 0;
            this.addressTextBox.SelectionStart = 0;
            this.addressTextBox.ShortcutsEnabled = true;
            this.addressTextBox.Size = new System.Drawing.Size(230, 23);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.UseSelectable = true;
            this.addressTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addressTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.addressTextBox.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // roleTextBox
            // 
            this.roleTextBox.AutoSize = true;
            this.roleTextBox.Location = new System.Drawing.Point(463, 314);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(35, 19);
            this.roleTextBox.TabIndex = 11;
            this.roleTextBox.Text = "Role";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.groupTableBindingSource;
            this.metroComboBox1.DisplayMember = "groupname";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(514, 314);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(230, 29);
            this.metroComboBox1.TabIndex = 8;
            this.metroComboBox1.UseSelectable = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(544, 394);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(117, 40);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseSelectable = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 64);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(424, 227);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Re-Password";
            // 
            // rePasswordTextBox
            // 
            // 
            // 
            // 
            this.rePasswordTextBox.CustomButton.Image = null;
            this.rePasswordTextBox.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.rePasswordTextBox.CustomButton.Name = "";
            this.rePasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.rePasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rePasswordTextBox.CustomButton.TabIndex = 1;
            this.rePasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rePasswordTextBox.CustomButton.UseSelectable = true;
            this.rePasswordTextBox.CustomButton.Visible = false;
            this.rePasswordTextBox.Lines = new string[0];
            this.rePasswordTextBox.Location = new System.Drawing.Point(514, 227);
            this.rePasswordTextBox.MaxLength = 32767;
            this.rePasswordTextBox.Name = "rePasswordTextBox";
            this.rePasswordTextBox.PasswordChar = '*';
            this.rePasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rePasswordTextBox.SelectedText = "";
            this.rePasswordTextBox.SelectionLength = 0;
            this.rePasswordTextBox.SelectionStart = 0;
            this.rePasswordTextBox.ShortcutsEnabled = true;
            this.rePasswordTextBox.Size = new System.Drawing.Size(230, 23);
            this.rePasswordTextBox.TabIndex = 5;
            this.rePasswordTextBox.UseSelectable = true;
            this.rePasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rePasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(454, 349);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Project";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataSource = this.projectTableBindingSource;
            this.metroComboBox2.DisplayMember = "projectname";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(514, 349);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(230, 29);
            this.metroComboBox2.TabIndex = 14;
            this.metroComboBox2.UseSelectable = true;
            // 
            // projectTableBindingSource
            // 
            this.projectTableBindingSource.DataMember = "projectTable";
            this.projectTableBindingSource.DataSource = this.bugtrackingapplicationDataSet;
            // 
            // projectTableTableAdapter
            // 
            this.projectTableTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 740);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.rePasswordTextBox);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "RegisterForm";
            this.Text = "Register Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtrackingapplicationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bugtrackingapplicationDataSet bugtrackingapplicationDataSet;
        private System.Windows.Forms.BindingSource groupTableBindingSource;
        private bugtrackingapplicationDataSetTableAdapters.groupTableTableAdapter groupTableTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox genderTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox addressTextBox;
        private MetroFramework.Controls.MetroLabel roleTextBox;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton registerButton;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox rePasswordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.BindingSource projectTableBindingSource;
        private bugtrackingapplicationDataSetTableAdapters.projectTableTableAdapter projectTableTableAdapter;
    }
}