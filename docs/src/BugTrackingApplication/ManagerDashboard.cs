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
    public partial class ManagerDashboard : MetroForm {
        DataTable dataTable;
        int managerId;
        string managerEmail;
        public ManagerDashboard() {
            InitializeComponent();
        }
        /// <summary>
        /// Get the manager Email Information
        /// </summary>
        /// <param name="email">Manager Email</param>
        public void getManagerInformation(string email) {
            managerEmail = email;
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            string sqlQuery = "SELECT * FROM userTable WHERE email = '" + email + "'";   //SQL Query for Select
            
            dataTable = dataconnection.selectDataConnectionStart(sqlQuery);
            foreach(DataRow row in dataTable.Rows) {
                string name = row["name"].ToString();
                string userName = row["username"].ToString();
                //nameTextLabel.Text = name;
                managerId = (int)row["id"];
            }
        }

        private void ManagerDashboard_Load(object sender, EventArgs e) {
            this.TopMost = true;
        }

        private void ManagerDashboard_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e) {
            DeveloperInformation developerInformation = new DeveloperInformation();
            developerInformation.getManagerEmail(managerEmail);
            developerInformation.Show();
            this.Hide();
        }

        private void testersToolStripMenuItem_Click(object sender, EventArgs e) {
            TesterInformation testerInformation = new TesterInformation();
            testerInformation.getManagerEmail(managerEmail);
            testerInformation.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e) {
            ProjectInformation projectInformation = new ProjectInformation();
            //Check Here
            Console.WriteLine("Check Here");
            Console.WriteLine(managerId);
            Console.WriteLine(managerEmail);
            //Check here
            projectInformation.getManagerId(managerId, managerEmail);
            projectInformation.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Welcome To Manager Dashboard", "Manager Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Number of Users Found: " + userNumber(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string userNumber() {
            SqlConnection sqlConnection;
            DataConnection dataConnection = new DataConnection();
            sqlConnection = dataConnection.retrieveConnecion();

            SqlCommand cmd = new SqlCommand("userNumber", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@id", SqlDbType.Int).Value = developerId;
            //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;
            sqlConnection.Open();

            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Check Here");
            //Console.WriteLine(cmd.ExecuteScalar().ToString());
            return cmd.ExecuteScalar().ToString();
        }

        private void developersToolStripMenuItem1_Click(object sender, EventArgs e) {
            ReportDeveloper reportDeveloper = new ReportDeveloper();
            reportDeveloper.getInformation(managerEmail);
            reportDeveloper.Show();
            this.Hide();
        }

        private void testersToolStripMenuItem1_Click(object sender, EventArgs e) {
            ReportTester reportTester = new ReportTester();
            reportTester.getInformation(managerEmail);
            reportTester.Show();
            this.Hide();
        }
    }
}
