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

namespace BugTrackingApplication {
    public partial class TesterDashboard : MetroForm {
        DataTable dataTable;
        RouteInformation routeInformation;
        int testerId;
        public TesterDashboard() {
            InitializeComponent();
        }

        public void getTesterInformation(string email) {
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
    }
}
