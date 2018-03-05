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
    public partial class ReportDeveloper : MetroForm {
        private string email;
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        public ReportDeveloper() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Developer Email
        /// </summary>
        /// <param name="mail">Developer Email</param>
        public void getInformation(string mail) {
            email = mail;
        }

        private void ReportDeveloper_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from userTable WHERE role = 201");
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
