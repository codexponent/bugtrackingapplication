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
    public partial class ProjectStatus : MetroForm {
        private int projectId;
        private int managerId;
        private string managerEmail;
        RegexUtilities util = new RegexUtilities();
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public ProjectStatus() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Project Id
        /// </summary>
        /// <param name="id">Project Id</param>
        public void getProjectId(int id) {
            projectId = id;
        }
        /// <summary>
        /// Gets the Manager Information
        /// </summary>
        /// <param name="id">Manager Id</param>
        /// <param name="email">Manager Email</param>
        public void getManagerId(int id, string email) {
            managerId = id;
            managerEmail = email;
        }

        private void ProjectStatus_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            string sqlSelectQuery = "SELECT  * from projectTable WHERE id = '" + projectId + "'";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                nameTextBox.Text = row["projectname"].ToString();
                descriptionTextBox.Text = row["projectdescription"].ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();
            string sqlQuery = "UPDATE projectTable SET projectname = '" + nameTextBox.Text + "', projectdescription = '" + descriptionTextBox.Text + "' WHERE id = " + projectId;
            if (dataconnection.updateConnectionStart(sqlQuery) == "1") {
                // Update Successfull
                MetroMessageBox.Show(this, "Update Process Completed and you are Project is Registered As " + nameTextBox.Text, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                redirectProjectTable();
            } else {
                // Update Unsuccessfull
                MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataconnection.connectionStop();
        }
        /// <summary>
        /// Redirects to the ProjectInformation Form
        /// </summary>
        private void redirectProjectTable() {
            ProjectInformation projectInformation = new ProjectInformation();
            projectInformation.getManagerId(managerId, managerEmail);
            projectInformation.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            redirectProjectTable();
        }
    }
}
