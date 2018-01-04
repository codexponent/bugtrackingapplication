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
    public partial class Intro : MetroForm {
        RouteInformation routeInformation = new RouteInformation();
        public Intro() {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e) {
            this.TopMost = true;
        }

        private void metroTile2_Click(object sender, EventArgs e) {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            routeInformation.getRouteList("Log In Form");
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            routeInformation.getRouteList("Register Form");
            this.Hide();
        }

        private void Intro_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void metroTile3_Click(object sender, EventArgs e) {
            AdminLogInForm adminLogInForm = new AdminLogInForm();
            adminLogInForm.Show();
            routeInformation.getRouteList("Admin Form");
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
