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
    public partial class AdminProjectTable : MetroForm {
        public AdminProjectTable() {
            InitializeComponent();
        }

        private void AdminProjectTable_Load(object sender, EventArgs e) {

        }

        private void metroButton1_Click(object sender, EventArgs e) {
            //Submit the data
            DataConnection dataconnection = new DataConnection();
            string sqlQuery = "INSERT INTO projectTable  (projectname, projectdescription) VALUES ('" + nameTextBox.Text + "', '" + descriptionTextBox.Text + "')";
            if (dataconnection.insertConnectionStart(sqlQuery) == "1") {
                // Update Successfull
                MetroMessageBox.Show(this, "Insert Process Completed and you are Project is Registered As " + nameTextBox.Text, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                redirect();
            } else {
                // Update Unsuccessfull
                MetroMessageBox.Show(this, "The Values Doesnt Match Up", "Update UnSuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataconnection.connectionStop();
        }

        private void redirect() {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            redirect();
        }
    }
}
