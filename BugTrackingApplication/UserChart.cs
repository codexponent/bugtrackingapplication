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
    public partial class UserChart : MetroForm {
        public UserChart() {
            InitializeComponent();
        }

        private void UserChart_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.groupTable' table. You can move, or remove it, as needed.
            this.groupTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.groupTable);

        }

        private void metroButton1_Click(object sender, EventArgs e) {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
