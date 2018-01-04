using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace BugTrackingApplication {
    public partial class AdminLogInForm : MetroForm {
        RegexUtilities util = new RegexUtilities();
        public AdminLogInForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
        }

        private void registerButton_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void AdminLogInForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void AdminLogInForm_Load(object sender, EventArgs e) {
            this.TopMost = true;
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void adminLoginButton_Click(object sender, EventArgs e) {
            if (util.IsValidEmail(emailBox.Text)) {
                DataConnection dataconnection = new DataConnection();       // Getting Database Connection
                string sqlQuery = "SELECT COUNT(*) FROM adminTable WHERE email = '" + emailBox.Text + "' AND password = '" + passwordBox.Text + "'";   //SQL Query for Select
                if (dataconnection.selectConnectionStart(sqlQuery) == "1") {
                    // Login Successfull
                    MetroMessageBox.Show(this, "You Are Now Logged In As " + emailBox.Text, "Log In Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //Redirect to the Admin Panel
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                } else {
                    // Login Unsuccessfull
                    MetroMessageBox.Show(this, "The Email Or The Password Doesn't Match", "Log In Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataconnection.connectionStop();
            } else {
                MetroMessageBox.Show(this, "The Email Is Invalid", "Log In Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
