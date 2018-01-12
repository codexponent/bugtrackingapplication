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
    public partial class ReportProject : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        private string developerEmail;
        public ReportProject() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Developer Information
        /// </summary>
        /// <param name="email">Developer Email</param>
        public void getDeveloperInformation(string email) {
            developerEmail = email;
        }
        /// <summary>
        /// Adding a Git Buttton on the Data Grid View
        /// </summary>
        private void gitButton() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "GIT";
            btn.Name = "gitButton";
            btn.Text = "GIT";
            dataGridView1.Columns.Add(btn);
        }

        private void ReportProject_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from projectTable");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            gitButton();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            TesterDashboard testerDashboard = new TesterDashboard();
            testerDashboard.getTesterInformation(developerEmail);
            testerDashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            string projectName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["projectname"].FormattedValue);
            if (e.ColumnIndex == 3) {
                try {
                    System.Diagnostics.Process.Start("http://www.bitbucket.com/sulabhShrestha04/" + projectName);
                } catch (Exception ex) {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }
        }
    }
}
