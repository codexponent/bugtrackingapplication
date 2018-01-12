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
    public partial class BugStatus : MetroForm {
        private int bugId;
        private int bugFlag;
        private int developerId;
        RegexUtilities util = new RegexUtilities();
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public BugStatus() {
            InitializeComponent();
        }
        /// <summary>
        /// Get the Bug ID
        /// </summary>
        /// <param name="id">Bug Id</param>
        public void getBugId(int id) {
            bugId = id;
        }
        /// <summary>
        /// Get the Developer Id
        /// </summary>
        /// <param name="id">Develoepr Id</param>
        public void getDeveloperId(int id) {
            developerId = id;
        }

        private void BugStatus_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            string sqlSelectQuery = "SELECT  * from bugTable WHERE id = '" + bugId + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                bugNameTextBox.Text = row["bugname"].ToString();
            }
            if (bugFlag == 0) {
                metroCheckBox1.Checked = false;
            } else {
                metroCheckBox1.Checked = true;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e) {
            if (metroCheckBox1.Checked == true) {
                bugFlag = 1;
            } else {
                bugFlag = 0;
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            if (bugFlag == 0) {
                //update for developer note only
                //first
                string sqlQuery = "UPDATE bugTable SET developernote = '" + noteTextBox.Text + "' WHERE id = " + bugId;
                if (dataconnection.updateConnectionStart(sqlQuery) == "1") {
                    // Update Successfull
                    MetroMessageBox.Show(this, "Developer Note Updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    // Update Unsuccessfull
                    MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataconnection.connectionStop();
                //second 
                developerNoted();
                redirectBugInformation();
            } else {
                //update for developer note as well as fixing the flag
                //first
                string sqlQuery = "UPDATE bugTable SET developernote = '" + noteTextBox.Text + "', fix = " + bugFlag + " WHERE id = " + bugId;
                if (dataconnection.updateConnectionStart(sqlQuery) == "1") {
                    // Update Successfull
                    MetroMessageBox.Show(this, "Problem Solved", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    // Update Unsuccessfull
                    MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataconnection.connectionStop();
                //second
                developerNoted();
                redirectBugInformation();
            }
        }
        /// <summary>
        /// Inserting into noteTable Table
        /// </summary>
        private void developerNoted() {
            DataConnection dataconnection = new DataConnection();
            //DateTime date1 = new DateTime();
            //DateTime dateOnly = date1.Date;

            DateTime dateTime = DateTime.Today;
            string sqlQuery = "INSERT INTO noteTable(bug, developernote, fixeddate) VALUES (" + bugId + ", '" + noteTextBox.Text + "', '" + dateTime.ToString("d") + "')";
            if (dataconnection.insertConnectionStart(sqlQuery) == "1") {
                // Update Successfull
                //MetroMessageBox.Show(this, "Bug Updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                // Update Unsuccessfull
                MetroMessageBox.Show(this, "Something Wrong, Please Check the Values", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Redirecting into BugInformation Form
        /// </summary>
        private void redirectBugInformation() {
            BugInformation bugInformation = new BugInformation();
            bugInformation.getDeveloperId(developerId);
            bugInformation.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            redirectBugInformation();
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            try {
                using (var repo = new Repository("C:/Users/LENOVO/Documents/" + folderName.Text)) {
                    Commands.Stage(repo, "*");

                    // Create the committer's signature and commit
                    Signature author = new Signature("sulabhShrestha04", "sulabh4@hotmail.com", DateTime.Now);
                    Signature committer = author;

                    // Commit to the repository
                    Commit commit = repo.Commit(noteTextBox.Text, author, committer);

                    //Push
                    Remote remote = repo.Network.Remotes["origin"];
                    var options = new PushOptions();
                    options.CredentialsProvider = (_url, _user, _cred) =>
                        new UsernamePasswordCredentials { Username = "sulabhShrestha04", Password = "Abp4952Gfj1069" };
                    repo.Network.Push(remote, @"refs/heads/master", options);

                }
            } catch (Exception exc) {
                throw exc;
            }
            
            MetroMessageBox.Show(this, "Code Pushed Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//metroButton2_click

        private void folderName_Click(object sender, EventArgs e) {

        }
    }
}
