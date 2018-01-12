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
using System.Security.Cryptography;

namespace BugTrackingApplication {
    public partial class LogInForm : MetroForm {
        RegexUtilities util = new RegexUtilities();
        public LogInForm() {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e) {
            this.TopMost = true;
        }

        private void loginButton_Click_1(object sender, EventArgs e) {
            string passwordHashed;
            using (SHA256 shaM = new SHA256Managed()) {
                passwordHashed = BitConverter.ToString(shaM.ComputeHash(Encoding.UTF8.GetBytes(passwordTextBox.Text)));
            }
            string sliced = passwordHashed;
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection

            if (util.IsValidEmail(emailTextBox.Text)) {
                string sqlQuery = "SELECT COUNT(*) FROM userTable WHERE email = '" + emailTextBox.Text + "' AND password = '" + sliced + "'";   //SQL Query for Select
                if (dataconnection.selectConnectionStart(sqlQuery) == "1") {
                    dataconnection.connectionStop();
                    // Query to get the flag of the selected individual
                    string sqlQuery1 = "SELECT flag FROM userTable WHERE email = '" + emailTextBox.Text + "' AND password = '" + sliced + "'";   //SQL Query for Select
                    // This if condition exists to check the flags for managers, developers and testers
                    if (Int32.Parse(dataconnection.selectConnectionStart(sqlQuery1)) == 1) {
                        // Login Successfull
                        //MessageBox.Show("Login Successful");
                        MetroMessageBox.Show(this, "You Are Now Logged In As " + emailTextBox.Text, "Log In Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        dataconnection.connectionStop();
                        // Query to get the role data of the corresponding indvidual
                        string sqlQuery2 = "SELECT role FROM userTable WHERE email = '" + emailTextBox.Text + "' AND password = '" + sliced + "'";   //SQL Query for Select
                        //Redirect to the Dashboard Page
                        redirectDashboard(dataconnection.selectConnectionStart(sqlQuery2));        //A generic method for dashboard    
                        dataconnection.connectionStop();
                    } else {
                        // Account Not Activated
                        MetroMessageBox.Show(this, "Your Account Is Not Activated", "Log In Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    // Login Unsuccessfull
                    MetroMessageBox.Show(this, "The Email Or The Password Doesn't Match", "Log In Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MetroMessageBox.Show(this, "The Email Is Invalid", "Log In Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void registerButton_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            
        }
        /// <summary>
        /// Redirects to the page according to the parameter Role
        /// </summary>
        /// <param name="role">Role defines Manager/Tester/Developer</param>
        private void redirectDashboard(string role) {
            if (role == "200") {
                ManagerDashboard managerDashboard = new ManagerDashboard();
                managerDashboard.getManagerInformation(emailTextBox.Text);

                ManagerIdentification managerIdentification = new ManagerIdentification();
                managerIdentification.getMangerInformation(emailTextBox.Text);

                managerDashboard.Show();
                this.Hide();
            }else if (role == "201") {
                DeveloperDashboard developerDashboard = new DeveloperDashboard();
                developerDashboard.getDeveloperInformation(emailTextBox.Text);
                developerDashboard.Show();
                this.Hide();
            } else {
                TesterDashboard testerDashboard = new TesterDashboard();
                testerDashboard.getTesterInformation(emailTextBox.Text);
                testerDashboard.Show();
                this.Hide();
            }
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }
    }
}
