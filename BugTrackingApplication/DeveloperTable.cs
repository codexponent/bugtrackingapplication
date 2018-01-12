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
using LibGit2Sharp;

namespace BugTrackingApplication {
    public partial class DeveloperTable : MetroForm {
        private int developerId;
        private int developerFlag;
        RegexUtilities util = new RegexUtilities();
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public DeveloperTable() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Developer Id
        /// </summary>
        /// <param name="id">Developer Id</param>
        public void getDeveloperId(int id) {
            developerId = id;
        }

        private string managerEmail;
        /// <summary>
        /// Gets the Manager Information
        /// </summary>
        /// <param name="email">Manager Email</param>
        public void getManagerInformation(string email) {
            managerEmail = email;
        }

        private void DeveloperTable_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.projectTable' table. You can move, or remove it, as needed.
            this.projectTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.projectTable);
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.groupTable' table. You can move, or remove it, as needed.
            this.groupTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.groupTable);
            DataConnection dataconnection = new DataConnection();
            string sqlSelectQuery = "SELECT  * from userTable WHERE id = '" + developerId + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                nameTextBox.Text = row["name"].ToString();
                developerFlag = (int)row["flag"];
            }
            if (developerFlag == 0) {
                metroCheckBox1.Checked = false;
            } else {
                metroCheckBox1.Checked = true;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e) {

            int projectValue = 0;
            int roleValue = 0;
            //Getting the projectId and GroupId
            DataConnection dataconnection = new DataConnection();
            string sqlSelectQuery = "SELECT  * from projectTable WHERE projectname = '" + projectComboBox.Text + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                projectValue = (int)row["id"];
            }
            dataconnection.connectionStop();
            string sqlSelectGroupQuery = "SELECT  * from groupTable WHERE groupname = '" + roleComboBox.Text + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectGroupQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                roleValue = (int)row["id"];
            }
            dataconnection.connectionStop();


            dataconnection.connectionStop();
            string sqlQuery = "UPDATE userTable SET name = '" + nameTextBox.Text + "', project = '" + projectValue + "', role = '" + roleValue + "', flag = " + developerFlag + "WHERE id = " + developerId;
            if (dataconnection.updateConnectionStart(sqlQuery) == "1") {
                // Update Successfull
                MetroMessageBox.Show(this, "Update Process Completed and you are Registered As " + nameTextBox.Text, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                redirectDeveloperTable();
            } else {
                // Update Unsuccessfull
                MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataconnection.connectionStop();
        }
        /// <summary>
        /// Redirects to the Developer Table
        /// </summary>
        private void redirectDeveloperTable() {
            DeveloperInformation developerInformation = new DeveloperInformation();
            developerInformation.getManagerEmail(managerEmail);
            developerInformation.Show();
            this.Hide();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e) {
            if (metroCheckBox1.Checked == true) {
                developerFlag = 1;
            } else {
                developerFlag = 0;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            redirectDeveloperTable();
        }

        private void metroButton3_Click(object sender, EventArgs e) {
            using (var repo = new Repository("C:/Users/LENOVO/Documents/btaReport")) {
                Commands.Stage(repo, "*");

                // Create the committer's signature and commit
                Signature author = new Signature("Sulabh", "sulabh4@hotmail.com", DateTime.Now);
                Signature committer = author;

                // Commit to the repository
                Commit commit = repo.Commit("Here's a commit i made!", author, committer);
            }
        }
    }
}
