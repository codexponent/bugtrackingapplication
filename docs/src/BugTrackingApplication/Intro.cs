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
using LibGit2Sharp;

namespace BugTrackingApplication {
    public partial class Intro : MetroForm {
        RouteInformation routeInformation = new RouteInformation();
        public Intro() {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the Intro of the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Intro_Load(object sender, EventArgs e) {
            this.TopMost = true;
            SqlConnection sqlConnection;
            DataConnection dataConnection = new DataConnection();
            sqlConnection = dataConnection.retrieveConnecion();

            SqlCommand cmd = new SqlCommand("groupNumber", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txtFirstName.Text;
            //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;
            sqlConnection.Open();

            //cmd.ExecuteNonQuery();
            Console.WriteLine("Check Here");
            Console.WriteLine(cmd.ExecuteScalar().ToString());
        }
        /// <summary>
        /// Checks the Log In Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile2_Click(object sender, EventArgs e) {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            routeInformation.getRouteList("Log In Form");
            this.Hide();
        }
        /// <summary>
        /// Checks the Registration Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile1_Click(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            routeInformation.getRouteList("Register Form");
            this.Hide();
        }
        /// <summary>
        /// Closes the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Intro_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        /// <summary>
        /// Checks the Admin Log In Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile3_Click(object sender, EventArgs e) {
            AdminLogInForm adminLogInForm = new AdminLogInForm();
            adminLogInForm.Show();
            routeInformation.getRouteList("Admin Form");
            this.Hide();
        }
        /// <summary>
        /// Closes the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroTile4_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            //SqlConnection sqlConnection;
            //DataConnection dataConnection = new DataConnection();
            //sqlConnection = dataConnection.retrieveConnecion();

            //SqlCommand cmd = new SqlCommand("groupNumber", sqlConnection);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txtFirstName.Text;
            //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txtLastName.Text;
            //sqlConnection.Open();
                    
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Check Here");
            //Console.WriteLine(cmd.ExecuteScalar().ToString());
                
        }

        private void metroButton1_Click_1(object sender, EventArgs e) {
        }
    }
}
