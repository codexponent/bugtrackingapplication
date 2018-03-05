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
    public partial class TesterTable : MetroForm {
        private int testerId;
        private int testerFlag;
        RegexUtilities util = new RegexUtilities();
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public TesterTable() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Tester Id
        /// </summary>
        /// <param name="id">Tester Id</param>
        public void getTesterId(int id) {
            testerId = id;
        }

        private string managerEmail;
        /// <summary>
        /// Gets the Manager Information
        /// </summary>
        /// <param name="email">Manager Email</param>
        public void getManagerInformation(string email) {
            managerEmail = email;
        }

        private void TesterTable_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.groupTable' table. You can move, or remove it, as needed.
            this.groupTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.groupTable);
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.projectTable' table. You can move, or remove it, as needed.
            this.projectTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.projectTable);
            DataConnection dataconnection = new DataConnection();
            string sqlSelectQuery = "SELECT  * from userTable WHERE id = '" + testerId + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                nameTextBox.Text = row["name"].ToString();
                testerFlag = (int)row["flag"];
            }
            if (testerFlag == 0) {
                metroCheckBox1.Checked = false;
            } else {
                metroCheckBox1.Checked = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            TesterInformation testerInformation = new TesterInformation();
            testerInformation.Show();
            this.Hide();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e) {
            if (metroCheckBox1.Checked == true) {
                testerFlag = 1;
            } else {
                testerFlag = 0;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e) {
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
            string sqlQuery = "UPDATE userTable SET name = '" + nameTextBox.Text + "', project = '" + projectValue + "', role = '" + roleValue + "', flag = " + testerFlag + "WHERE id = " + testerId;
            if (dataconnection.updateConnectionStart(sqlQuery) == "1") {
                // Update Successfull
                MetroMessageBox.Show(this, "Update Process Completed and you are Registered As " + nameTextBox.Text, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                redirectTesterTable();
            } else {
                // Update Unsuccessfull
                MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataconnection.connectionStop();
        }
        /// <summary>
        /// Redirects to the TesterInformation Form
        /// </summary>
        private void redirectTesterTable() {
            TesterInformation testerInformation = new TesterInformation();
            testerInformation.getManagerEmail(managerEmail);
            testerInformation.Show();
            this.Hide();
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
