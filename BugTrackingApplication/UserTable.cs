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
    public partial class UserTable : MetroForm {
        private int userId;
        private int userFlag;
        RegexUtilities util = new RegexUtilities();
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public UserTable() {
            InitializeComponent();
        }

        private void UserTable_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            string sqlSelectQuery = "SELECT  * from userTable WHERE id = '" + userId + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                nameTextBox.Text = row["name"].ToString();
                userNameTextBox.Text = row["username"].ToString();
                emailTextBox.Text = row["email"].ToString();
                passwordTextBox.Text = row["password"].ToString();
                genderTextBox.Text = row["gender"].ToString();
                addressTextBox.Text = row["address"].ToString();
                userFlag = (int)row["flag"];
            }
            if (userFlag == 0) {
                metroCheckBox1.Checked = false;
            } else {
                metroCheckBox1.Checked = true;
            }
        }
        /// <summary>
        /// Gets the User Id
        /// </summary>
        /// <param name="id">User Id</param>
        public void getUserId(int id) {
            userId = id;
        }

        private void updateButton_Click(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            if (util.IsValidEmail(emailTextBox.Text)) {
                string checkEmail = "";
                string sqlSelectQuery = "SELECT  * from userTable WHERE email = '" + emailTextBox.Text + "'";
                sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
                sqlDataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows) {
                    checkEmail = row["email"].ToString();
                }
                //if (checkEmail != emailTextBox.Text) {
                    dataconnection.connectionStop();
                    string sqlQuery = "UPDATE userTable SET name = '" + nameTextBox.Text + "', username = '" + userNameTextBox.Text + "', password = '" + passwordTextBox.Text + "', gender = '" + genderTextBox.Text + "', address = '" + addressTextBox.Text + "', flag = " + userFlag + "WHERE id = " + userId;
                    if (dataconnection.updateConnectionStart(sqlQuery) == "1") {
                        // Update Successfull
                        MetroMessageBox.Show(this, "Update Process Completed ", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        UserInformation userInformation = new UserInformation();
                        userInformation.Show();
                        this.Hide();
                    } else {
                        // Update Unsuccessfull
                        MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataconnection.connectionStop();
                //} else {
                    //MetroMessageBox.Show(this, "Email Already Registered", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            } else {
                MetroMessageBox.Show(this, "The Email Doesn't Match To Our Standards", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e) {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e) {
            if (metroCheckBox1.Checked == true) {
                userFlag = 1;
            } else {
                userFlag = 0;
            }
        }
    }
}
