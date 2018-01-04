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
            this.TopMost = true;
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.groupTable' table. You can move, or remove it, as needed.
            this.groupTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.groupTable);
        }


        private void button1_Click(object sender, EventArgs e) {
            
        }

        private void button2_Click(object sender, EventArgs e) {
            
        }

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
            if (roleTextBox.Text == "manager") {
                groupValues = 200;
            } else if (roleTextBox.Text == "developer") {
                groupValues = 201;
            } else {
                groupValues = 202;
            }

            if (util.IsValidEmail(emailTextBox.Text)) {
                string checkEmail = "";
                string sqlSelectQuery = "SELECT  * from userTable WHERE email = '" + emailTextBox.Text + "'";
                sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows) {
                    checkEmail = row["email"].ToString();
                }
                if (checkEmail != emailTextBox.Text) {
                    dataconnection.connectionStop();
                    string sqlQuery = "INSERT INTO userTable (name ,username ,email ,password ,gender ,address ,role ,project, flag) VALUES ('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + emailTextBox.Text + "','" + passwordTextBox.Text + "','" + genderTextBox.Text + "','" + addressTextBox.Text + "'," + groupValues + "," + projectValues + "," + nullValues + ")";
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
