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
using System.Configuration;

namespace BugTrackingApplication {
    public partial class BugReport : MetroForm {
        int testerId;
        int projectId;
        int developerId;
        DataTable dataTable;
        string languageName = "C#";
        public BugReport() {
            InitializeComponent();
        }

        private void BugReport_Load(object sender, EventArgs e) {

            //TextEditor
            //textEditorControl1.SetHighlighting(languageName);

            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.userTable' table. You can move, or remove it, as needed.
            //this.userTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.userTable);
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.projectTable' table. You can move, or remove it, as needed.
            //this.projectTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.projectTable);

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
        /// <summary>
        /// Get the Tester ID
        /// </summary>
        /// <param name="id">Tester ID</param>
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
        /// <summary>
        /// Links to the Selected Link
        /// </summary>
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

            Console.WriteLine(bugNameBox.Text);
            Console.WriteLine(bugDescriptionBox.Text);
            Console.WriteLine(textEditorControl1.Text);
            Console.WriteLine(projectId);
            Console.WriteLine(developerId);
            Console.WriteLine(testerId);

            if (bugNameBox.Text != "" &
                bugDescriptionBox.Text != "" &
                textEditorControl1.Text != "" &
                projectId != 0 &
                developerId != 0 &
                testerId != 0) {

                string sqlInsertQuery = "INSERT INTO bugTable (bugname, bugdescription, developernote, syntax, project, developer, tester, fix) VALUES ('" + bugNameBox.Text + "','" + bugDescriptionBox.Text + "','" + developerNoteTextBox.Text + "','" + textEditorControl1.Text + "'," + projectId + "," + developerId + "," + testerId + "," + fixValue + ")";
                if (dataconnection.insertConnectionStart(sqlInsertQuery) == "1") {
                    // Bug Reported Successfull
                    //MetroMessageBox.Show(this, "Bug Report Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);

                    //Uploading on photo Table
                    int bugId = 300;
                    string sqlDevelopersSelectQuery = "SELECT * FROM bugTable where id = (select max(id) from bugTable)";
                    //SELECT* FROM bugTable where id = (select max(id) from bugTable);
                    dataTable = dataconnection.selectDataConnectionStart(sqlDevelopersSelectQuery);
                    foreach (DataRow row in dataTable.Rows) {
                        bugId = (int)row["id"];
                        Console.WriteLine(bugId);
                    }
                    dataconnection.connectionStop();

                    string sqlInsertPhotoQuery = "INSERT INTO photoTable (bug, photo) VALUES ('" + bugId + "','" + destFile +  "')";
                    if (dataconnection.insertConnectionStart(sqlInsertPhotoQuery) == "1") {
                    // Bug Reported Successfull
                        MetroMessageBox.Show(this, "Bug Report Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    } else {
                    // Bug Reported Unsuccessfull
                        MetroMessageBox.Show(this, "Bug Report Failed", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataconnection.connectionStop();

                    string sqlInsertStatusQuery = "INSERT INTO statusTable (bug, status) VALUES ('" + bugId + "','" + bugStatusComboBox.Text + "')";
                    if (dataconnection.insertConnectionStart(sqlInsertStatusQuery) == "1") {
                        // Bug Reported Successfull
                        MetroMessageBox.Show(this, "Bug Status Report Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    } else {
                        // Bug Reported Unsuccessfull
                        MetroMessageBox.Show(this, "Bug Status Report Failed", "UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataconnection.connectionStop();

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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            languageName = metroComboBox1.Text;
            textEditorControl1.SetHighlighting(languageName);
        }

        string fileName, directoryPath;
        string sourceFile, destFile, ImageFileName;

        private void bugStatusComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void uploadImage_Click(object sender, EventArgs e) {


            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK) {
                fileName = open.FileName;
                //pictureBox1.Image = new Bitmap(fileName);
                //pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                ImageFileName = open.SafeFileName;
                directoryPath = Path.GetDirectoryName(fileName);
            }

            string targetPath = Environment.CurrentDirectory + "\\" + ConfigurationManager.AppSettings["ImageFolder"] + "\\";

            sourceFile = System.IO.Path.Combine(directoryPath, ImageFileName);
            destFile = System.IO.Path.Combine(targetPath, ImageFileName);

            Console.WriteLine(sourceFile);
            Console.WriteLine(destFile);

            if (!System.IO.Directory.Exists(targetPath)) {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            System.IO.File.Copy(sourceFile, destFile, true);

            MetroMessageBox.Show(this, "File Uploaded Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
