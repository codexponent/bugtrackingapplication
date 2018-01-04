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

namespace BugTrackingApplication {
    public partial class ManagerDashboard : MetroForm {
        DataTable dataTable;
        public ManagerDashboard() {
            InitializeComponent();
        }

        public void getManagerInformation(string email) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            string sqlQuery = "SELECT * FROM userTable WHERE email = '" + email + "'";   //SQL Query for Select
            
            dataTable = dataconnection.selectDataConnectionStart(sqlQuery);
            foreach(DataRow row in dataTable.Rows) {
                string name = row["name"].ToString();
                string userName = row["username"].ToString();
                nameTextLabel.Text = name;
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
            developerInformation.Show();
        }

        private void testersToolStripMenuItem_Click(object sender, EventArgs e) {
            TesterInformation testerInformation = new TesterInformation();
            testerInformation.Show();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e) {
            ProjectInformation projectInformation = new ProjectInformation();
            projectInformation.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }
    }
}
