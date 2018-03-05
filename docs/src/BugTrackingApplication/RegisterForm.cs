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
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BugTrackingApplication {
    public partial class RegisterForm : MetroForm {
        RegexUtilities util = new RegexUtilities();
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public RegisterForm() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void RegisterForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.projectTable' table. You can move, or remove it, as needed.
            this.projectTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.projectTable);
            this.TopMost = true;
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.groupTable' table. You can move, or remove it, as needed.
            this.groupTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.groupTable);
        }


        private void button1_Click(object sender, EventArgs e) {
            
        }

        private void button2_Click(object sender, EventArgs e) {
            
        }
        /// <summary>
        /// Redirects to the LoginForm Form
        /// </summary>
        private void redirectLoginForm() {          // A generic class to get to the login form
            LogInForm loginForm = new LogInForm();      // A new loginform object
            loginForm.Show();
            this.Hide();
        }

        private void adminButton_Click(object sender, EventArgs e) {
            
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void metroTextBox6_Click(object sender, EventArgs e) {

        }

        private void registerButton_Click(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            int nullValues = 0;
            int groupValues = 0;
            int projectValues = 100;
            if (metroComboBox1.Text == "manager") {
                groupValues = 200;
            } else if (metroComboBox1.Text == "developer") {
                groupValues = 201;
            } else {
                groupValues = 202;
            }

            string sqlSelectProjectQuery = "SELECT  * from projectTable WHERE projectname = '" + metroComboBox2.Text + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectProjectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                projectValues = (int)row["id"];
            }

            if (util.IsValidEmail(emailTextBox.Text)) {
                string checkEmail = "";
                string sqlSelectQuery = "SELECT  * from userTable WHERE email = '" + emailTextBox.Text + "'";
                sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows) {
                    checkEmail = row["email"].ToString();
                }
                string passwordHashed;
                using (SHA256 shaM = new SHA256Managed()) {
                    passwordHashed = BitConverter.ToString(shaM.ComputeHash(Encoding.UTF8.GetBytes(passwordTextBox.Text)));
                }
                string sliced = passwordHashed;
                if (checkEmail != emailTextBox.Text) {
                    dataconnection.connectionStop();
                    if (rePasswordTextBox.Text == passwordTextBox.Text) {
                        if (metroComboBox1.Text == "manager") {
                            int managerValue = 1;
                            string sqlQuery = "INSERT INTO userTable (name ,username ,email ,password ,gender ,address ,role ,project, flag) VALUES ('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + emailTextBox.Text + "','" + sliced + "','" + genderTextBox.Text + "','" + addressTextBox.Text + "'," + groupValues + "," + projectValues + "," + managerValue + ")";
                            if (dataconnection.insertConnectionStart(sqlQuery) == "1") {
                                // Register Successfull
                                MetroMessageBox.Show(this, "You Are Now Registered As " + emailTextBox.Text, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                                redirectLoginForm();            // Redirects to the Login Form
                            } else {
                                // Register Unsuccessfull
                                MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Registration UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            dataconnection.connectionStop();
                        } else {
                            string sqlQuery = "INSERT INTO userTable (name ,username ,email ,password ,gender ,address ,role ,project, flag) VALUES ('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + emailTextBox.Text + "','" + sliced + "','" + genderTextBox.Text + "','" + addressTextBox.Text + "'," + groupValues + "," + projectValues + "," + nullValues + ")";
                            if (dataconnection.insertConnectionStart(sqlQuery) == "1") {
                                // Register Successfull
                                MetroMessageBox.Show(this, "You Are Now Registered As " + emailTextBox.Text, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                                redirectLoginForm();            // Redirects to the Login Form
                            } else {
                                // Register Unsuccessfull
                                MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Registration UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            dataconnection.connectionStop();
                        }
                    } else {
                        MetroMessageBox.Show(this, "Password Doesn't Match", "Registration UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MetroMessageBox.Show(this, "Email Already Registered", "Registration UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MetroMessageBox.Show(this, "The Email Doesn't Match To Our Standards", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginButton_Click(object sender, EventArgs e) {
            redirectLoginForm();
        }

        private void adminGroupLogin_Click(object sender, EventArgs e) {
            AdminLogInForm adminLogInForm = new AdminLogInForm();
            adminLogInForm.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }
    }
}
