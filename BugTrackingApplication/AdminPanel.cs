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
    public partial class AdminPanel : MetroForm {
        public AdminPanel() {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e) {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void AdminPanel_Load(object sender, EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Welcome To Admin Panel", "Admin Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }
    }
}
