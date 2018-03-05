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
    public partial class ProjectTable : MetroForm {
        private int managerId;
        private string managerEmail;
        public ProjectTable() {
            InitializeComponent();
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

        private void ProjectTable_Load(object sender, EventArgs e) {

        }

        private void metroButton1_Click(object sender, EventArgs e) {
            //submit
            DataConnection dataconnection = new DataConnection();
            string sqlQuery = "INSERT INTO projectTable  (projectname, projectdescription) VALUES ('" + nameTextBox.Text + "', '" + descriptionTextBox.Text + "')";
            if (dataconnection.insertConnectionStart(sqlQuery) == "1") {
                // Update Successfull
                MetroMessageBox.Show(this, "Insert Process Completed and you are Project is Registered As " + nameTextBox.Text, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //redirect
            redirectProjectTable();
        }
    }
}
