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
    public partial class AdminChart : MetroForm {
        public AdminChart() {
            InitializeComponent();
        }

        private void AdminChart_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.userTable' table. You can move, or remove it, as needed.
            // Manual Commenting
            // this.userTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.userTable);


            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.adminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.adminTable);
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.adminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.adminTable);
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.userTable' table. You can move, or remove it, as needed.

        }

        private void metroButton1_Click(object sender, EventArgs e) {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
