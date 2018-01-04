using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingApplication {
    public partial class DeveloperDashboard : Form {
        DataTable dataTable;
        int developerId;
        public DeveloperDashboard() {
            InitializeComponent();
        }

        public void getDeveloperInformation(string email) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            string sqlQuery = "SELECT * FROM userTable WHERE email = '" + email + "'";   //SQL Query for Select

            dataTable = dataconnection.selectDataConnectionStart(sqlQuery);
            foreach (DataRow row in dataTable.Rows) {
                string name = row["name"].ToString();
                string userName = row["username"].ToString();
                developerId = (int)row["id"];
                nameTextLabel.Text = name;
            }
        }

        private void DeveloperDashboard_Load(object sender, EventArgs e) {

        }

        private void DeveloperDashboard_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e) {
            BugInformation bugInformation = new BugInformation();
            bugInformation.getDeveloperId(developerId);
            bugInformation.Show();
        }
    }
}
