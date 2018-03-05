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
    public partial class ReportBug : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        private string developerEmail;
        public ReportBug() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Developer Email
        /// </summary>
        /// <param name="mail">Developer Email</param>
        public void getDeveloperInformation(string mail) {
            developerEmail = mail;
        }

        private void ReportBug_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.bugTable' table. You can move, or remove it, as needed.
            //this.bugTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.bugTable);

            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from bugTable");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();

        }

        private void metroButton1_Click(object sender, EventArgs e) {
            DeveloperDashboard developerDashboard = new DeveloperDashboard();
            developerDashboard.getDeveloperInformation(developerEmail);
            developerDashboard.Show();
            this.Hide();
        }
    }
}
