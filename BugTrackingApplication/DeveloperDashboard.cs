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
    public partial class DeveloperDashboard : MetroForm {
        DataTable dataTable;
        int developerId;
        string developerEmail;
        public DeveloperDashboard() {
            InitializeComponent();
        }
        /// <summary>
        /// Get the Developer Information
        /// </summary>
        /// <param name="email">Developer Email</param>
        public void getDeveloperInformation(string email) {
            developerEmail = email;
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            string sqlQuery = "SELECT * FROM userTable WHERE email = '" + email + "'";   //SQL Query for Select

            dataTable = dataconnection.selectDataConnectionStart(sqlQuery);
            foreach (DataRow row in dataTable.Rows) {
                string name = row["name"].ToString();
                string userName = row["username"].ToString();
                developerId = (int)row["id"];
                //nameTextLabel.Text = name;
            }
        }

        private void DeveloperDashboard_Load(object sender, EventArgs e) {
        }

        private void DeveloperDashboard_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e) {
            // Clicked Bugs
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Welcome To Developer Dashboard", "Developer Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void solvedToolStripMenuItem_Click(object sender, EventArgs e) {
            //Solved
            BugSolvedInformation bugSolvedInformation = new BugSolvedInformation();
            bugSolvedInformation.getDeveloperId(developerId);
            bugSolvedInformation.Show();
            //this.Hide();
        }

        private void unSolvedToolStripMenuItem_Click(object sender, EventArgs e) {
            //UnSolved
            BugInformation bugInformation = new BugInformation();
            bugInformation.getDeveloperId(developerId);
            bugInformation.Show();
            //this.Hide();
        }
        /// <summary>
        /// Stored Procedure to get the Bug Number
        /// </summary>
        /// <returns>An Integer Number of the total Number of Bugs</returns>
        private string bugNumber() {
            SqlConnection sqlConnection;
            DataConnection dataConnection = new DataConnection();
            sqlConnection = dataConnection.retrieveConnecion();

            SqlCommand cmd = new SqlCommand("bugNumber", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = developerId;
            //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;
            sqlConnection.Open();

            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Check Here");
            //Console.WriteLine(cmd.ExecuteScalar().ToString());
            return cmd.ExecuteScalar().ToString();
        }

        private void metroLabel1_Click(object sender, EventArgs e) {
            
        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Number of Bugs Found: " + bugNumber(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bugsToolStripMenuItem1_Click(object sender, EventArgs e) {
            ReportBug reportBug = new ReportBug();
            reportBug.getDeveloperInformation(developerEmail);
            reportBug.Show();
            this.Hide();

        }
    }
}
