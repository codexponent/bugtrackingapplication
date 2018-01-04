using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using MetroFramework.Forms;
using MetroFramework;

namespace BugTrackingApplication {
    public partial class BugReport : MetroForm {
        int testerId;
        int projectId;
        int developerId;
        DataTable dataTable;
        public BugReport() {
            InitializeComponent();
        }

        private void BugReport_Load(object sender, EventArgs e) {

            //TextEditor
            textEditorControl1.SetHighlighting("C#");

            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.userTable);
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.projectTable' table. You can move, or remove it, as needed.
            this.projectTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.projectTable);

            //Loading the Items on the Combo Box
            DataConnection dataConnection = new DataConnection();
            /**string sqlSelectQuery = "SELECT * FROM projeTable WHERE projectName = '" + projectTextBox.Text + "'";
            dataTable = dataConnection.selectDataConnectionStart(sqlSelectQuery);
            foreach (DataRow row in dataTable.Rows) {
                projectId = (int)row["id"];
            }**/
            string developersName;
            string sqlDevelopersSelectQuery = "SELECT * FROM userTable WHERE role = 201";
            dataTable = dataConnection.selectDataConnectionStart(sqlDevelopersSelectQuery);
            foreach (DataRow row in dataTable.Rows) {
                developersName = (string)row["name"];
                //Console.WriteLine(developersName);
                comboBox1.Items.Add(developersName);
            }

            string projectName;
            string sqlProjectSelectQuery = "SELECT * FROM projectTable";
            dataTable = dataConnection.selectDataConnectionStart(sqlProjectSelectQuery);
            foreach (DataRow row in dataTable.Rows) {
                projectName = (string)row["projectname"];
                //Console.WriteLine(developersName);
                projectTextBox.Items.Add(projectName);
            }

        }

        public void getTesterId(int id) {
            testerId = id;
        }

        private void reportButton_Click(object sender, EventArgs e) {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void gitButton_Click(object sender, EventArgs e) {
            
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            try {
                VisitLink();
            } catch (Exception ex) {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink() {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            //gitLabel.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("http://www.bitbucket.com/lynxcorporative/" + projectTextBox.Text);
        }

        private void gitLabel_Click(object sender, EventArgs e) {

        }

        private void projectTextBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void testButton_Click(object sender, EventArgs e) {
            
        }

        private void gitButton_Click_1(object sender, EventArgs e) {
            try {
                VisitLink();
            } catch (Exception ex) {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void reportButton_Click_1(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            int fixValue = 0;

            //Getting the Project ID
            string sqlSelectProjectQuery = "SELECT * FROM projectTable WHERE projectName = '" + projectTextBox.Text + "'";
            dataTable = dataconnection.selectDataConnectionStart(sqlSelectProjectQuery);
            foreach (DataRow row in dataTable.Rows) {
                projectId = (int)row["id"];
            }

            //Getting the Developer's ID
            string sqlSelectDeveloperQuery = "SELECT * FROM userTable WHERE userName = '" + comboBox1.Text + "'";
            dataTable = dataconnection.selectDataConnectionStart(sqlSelectDeveloperQuery);
            foreach (DataRow row in dataTable.Rows) {
                developerId = (int)row["id"];
            }

            //Debugging Here
            Console.WriteLine("TesterValue");
            Console.WriteLine(testerId);
            Console.WriteLine("ProjectValue");
            Console.WriteLine(projectId);
            Console.WriteLine("DeveloperValue");
            Console.WriteLine(developerId);
            //Debugging Here
            if (bugNameBox.Text != "" &
                bugDescriptionBox.Text != "" &
                textEditorControl1.Text != "" &
                projectId != 0 &
                developerId != 0 &
                testerId != 0) {

                string sqlInsertQuery = "INSERT INTO bugTable (bugname, bugdescription, syntax, project, developer, tester, fix) VALUES ('" + bugNameBox.Text + "','" + bugDescriptionBox.Text + "','" + textEditorControl1.Text + "'," + projectId + "," + developerId + "," + testerId + "," + fixValue + ")";
                if (dataconnection.insertConnectionStart(sqlInsertQuery) == "1") {
                    // Bug Reported Successfull
                    MetroMessageBox.Show(this, "Bug Report Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                } else {
                    // Bug Reported Unsuccessfull
                    MetroMessageBox.Show(this, "Bug Report Failed", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataconnection.connectionStop();
                TesterDashboard testerDashboard = new TesterDashboard();
                testerDashboard.Show();
                this.Hide();
            } else {
                MetroMessageBox.Show(this, "Bug Report Failed. Please check the Data Entries Correctly", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            TesterDashboard testerDashboard = new TesterDashboard();
            testerDashboard.Show();
            this.Hide();
        }
    }
}
