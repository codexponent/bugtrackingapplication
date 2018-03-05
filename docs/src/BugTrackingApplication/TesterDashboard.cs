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
    public partial class TesterDashboard : MetroForm {
        DataTable dataTable;
        string testerEmail;
        RouteInformation routeInformation;
        int testerId;
        public TesterDashboard() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Tester Information
        /// </summary>
        /// <param name="email">Tester Email</param>
        public void getTesterInformation(string email) {
            testerEmail = email;
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            string sqlQuery = "SELECT * FROM userTable WHERE email = '" + email + "'";   //SQL Query for Select

            dataTable = dataconnection.selectDataConnectionStart(sqlQuery);
            foreach (DataRow row in dataTable.Rows) {
                string name = row["name"].ToString();
                string userName = row["username"].ToString();
                testerId = (int)row["id"];
                //nameTextLabel.Text = name;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            BugReport bugReport = new BugReport();
            bugReport.getTesterId(testerId);
            //routeInformation.getRouteList("Bug Report");
            bugReport.Show();
        }

        private void TesterDashboard_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void TesterDashboard_Load(object sender, EventArgs e) {

        }

        private void testtestToolStripMenuItem_Click(object sender, EventArgs e) {
            Console.WriteLine("Test Here");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Welcome To Tester Dashboard ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Number of Projects Found: " + projectNumber(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Store Procedure to get the project number
        /// </summary>
        /// <returns>An Integer Value of total number of Projects</returns>
        private string projectNumber() {
            SqlConnection sqlConnection;
            DataConnection dataConnection = new DataConnection();
            sqlConnection = dataConnection.retrieveConnecion();

            SqlCommand cmd = new SqlCommand("projectNumber", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = developerId;
            //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;
            sqlConnection.Open();

            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Check Here");
            //Console.WriteLine(cmd.ExecuteScalar().ToString());
            return cmd.ExecuteScalar().ToString();
        }

        private void projectsToolStripMenuItem1_Click(object sender, EventArgs e) {
            //Report Here
            ReportProject reportProject = new ReportProject();
            reportProject.getDeveloperInformation(testerEmail);
            reportProject.Show();
            this.Hide();
        }
    }
}
