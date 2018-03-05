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
    public partial class ReportTester : MetroForm {
        private string email;
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        public ReportTester() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Tester Email
        /// </summary>
        /// <param name="mail">Tester Email</param>
        public void getInformation(string mail) {
            email = mail;
        }

        private void ReportTester_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from userTable WHERE role = 202");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.getManagerInformation(email);
            managerDashboard.Show();
            this.Hide();
        }
    }
}
