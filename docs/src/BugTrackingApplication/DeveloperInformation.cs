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
    public partial class DeveloperInformation : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        public DeveloperInformation() {
            InitializeComponent();
        }

        private string managerEmail;
        /// <summary>
        /// Gets the Manager Email
        /// </summary>
        /// <param name="email">Manager Email</param>
        public void getManagerEmail(string email) {
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

        private void DeveloperInformation_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'bugtrackingapplicationDataSet.userTable' table. You can move, or remove it, as needed.
            //this.userTableTableAdapter.Fill(this.bugtrackingapplicationDataSet.userTable);
            /**try {
                this.userTableTableAdapter.Developers(this.bugtrackingapplicationDataSet.userTable);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }**/
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT id, name, role, project, flag from userTable WHERE role=201");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            addButton();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();

        }

        //This event updates the accept flag value and is call when the accept flag column in the DataGridView is clicked.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 3) // checks if the column clicked is 3
            {
                DataConnection dataConnection = new DataConnection();
                int user_id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value); //gets the user_id from 1st column.
                int finalFlag = Convert.ToInt32(dataGridView1[3, e.RowIndex].Value);
                if (finalFlag == 0) {
                    finalFlag = 1;
                } else {
                    finalFlag = 0;
                }

                String query = "update userTable set flag = " + finalFlag + " where id = " + user_id;
                string returnValue = dataConnection.updateConnectionStart(query);

                
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {
            sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
            sqlDataAdapter.Update((DataTable)bindingSource1.DataSource);
            MessageBox.Show("SAVED");
        }

        private void developersToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.userTableTableAdapter.Developers(this.bugtrackingapplicationDataSet.userTable);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void DeveloperInformation_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e) {
            int developerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue);

            //Console.WriteLine("userId: " + userId);
            //string hello = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            //MessageBox.Show(e.ColumnIndex + " is clicked with row " + userId);
            //r.Cells[3].Value

            if (e.ColumnIndex == 5) {
                DeveloperTable developerTable = new DeveloperTable();
                developerTable.getDeveloperId(developerId);
                developerTable.getManagerInformation(managerEmail);
                developerTable.Show();
                this.Hide();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.getManagerInformation(managerEmail);
            managerDashboard.Show();
            this.Hide();
        }
    }
}
