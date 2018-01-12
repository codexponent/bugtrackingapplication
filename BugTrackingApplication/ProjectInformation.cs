using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace BugTrackingApplication {
    public partial class ProjectInformation : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        private int managerId;
        private string managerEmail;
        DataTable dataTable = new DataTable();
        
        public ProjectInformation() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Manager Information
        /// </summary>
        /// <param name="id">Manager Id</param>
        /// <param name="email">Manager Email</param>
        public void getManagerId(int id, string email) {
            managerId = id;
            managerEmail = email;
        }
        /// <summary>
        /// Adding a Edit Buttton on the Data Grid View
        /// </summary>
        private void addButton() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "Edit";
            btn.Name = "editButton";
            btn.Text = "Edit";
            dataGridView1.Columns.Add(btn);
        }

        private void ProjectInformation_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            //sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from projectTable WHERE projectmanager = " + managerId);
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT projectTable.id, projectTable.projectname, projectTable.projectdescription FROM projectTable INNER JOIN userTable ON projectTable.id = userTable.project WHERE userTable.id = " + managerId + " AND userTable.role = 200");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            addButton();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();
        }

        private void saveButton_Click(object sender, EventArgs e) {
            sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
            sqlDataAdapter.Update((DataTable)bindingSource1.DataSource);
            MessageBox.Show("SAVED");
        }

        private void metroButton2_Click(object sender, EventArgs e) {
            ProjectTable projectTable = new ProjectTable();
            projectTable.getManagerId(managerId, managerEmail);
            projectTable.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.getManagerInformation(managerEmail);
            managerDashboard.Show();
            this.Hide();
        }

        private void ProjectInformation_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            int projectId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue);

            //Console.WriteLine("userId: " + userId);
            //string hello = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            //MessageBox.Show(e.ColumnIndex + " is clicked with row " + userId);
            //r.Cells[3].Value

            if (e.ColumnIndex == 3) {
                ProjectStatus projectStatus = new ProjectStatus();
                projectStatus.getProjectId(projectId);
                projectStatus.getManagerId(managerId, managerEmail);
                projectStatus.Show();
                this.Hide();
            }
        }
    }
}
