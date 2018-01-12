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
    public partial class BugInformation : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        int developerId;
        string dataDescription;
        string noteDescription;
        public BugInformation() {
            InitializeComponent();
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
        /// <summary>
        /// Adding a History Buttton on the Data Grid View
        /// </summary>
        private void historyButton() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "History";
            btn.Name = "historyButton";
            btn.Text = "History";
            dataGridView1.Columns.Add(btn);
        }
        /// <summary>
        /// Adding a Image Link Buttton on the Data Grid View
        /// </summary>
        private void imageButton() {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.HeaderText = "Image";
            btn.Name = "imageButton";
            btn.Text = "Image";
            dataGridView1.Columns.Add(btn);
        }
        /// <summary>
        /// Get the Developer Id
        /// </summary>
        /// <param name="id">Developer Id</param>
        public void getDeveloperId(int id) {
            developerId = id;
        }

        private void BugInformation_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            int bugFixed = 0;
            //Check Here
            Console.WriteLine("developerId");
            Console.WriteLine(developerId);
            //Check Here
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from bugTable WHERE developer = '" + developerId + "' AND fix = '" + bugFixed + "'");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;

            //Check here
            int count = 0;
            foreach (DataRow row in dataTable.Rows) {
                dataDescription = (string)row["bugdescription"];
                noteDescription = (string)row["developernote"];
                //Console.WriteLine(developersName);
                count++;
            }
            //Check here
            addButton();
            historyButton();
            imageButton();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();

            //dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue
            SqlDataAdapter newSqlDataAdapter = new SqlDataAdapter();
            DataTable newDataTable = new DataTable();
            newSqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from statusTable");
            newSqlDataAdapter.Fill(newDataTable);
            string status;
            int bugId;


            foreach (DataRow row in newDataTable.Rows) {
                status = row["status"].ToString();
                bugId = (int)row["bug"];

                //Check here
                Console.WriteLine("status");
                Console.WriteLine(status);
                Console.WriteLine(bugId);

                if (status == "critical") {
                    
                    for (int i = 0; i < count; i++) {
                        int piId = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].FormattedValue);
                        Console.WriteLine("Piid");
                        Console.WriteLine(piId);
                        if (piId == bugId) {
                            Console.WriteLine("Matched");
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }

                }else  if(status == "information") {

                    for (int i = 0; i < count; i++) {
                        int piId = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].FormattedValue);
                        if (piId == bugId) {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                        }
                    }

                } else {

                    for (int i = 0; i < count; i++) {
                        int piId = Convert.ToInt32(dataGridView1.Rows[i].Cells["id"].FormattedValue);
                        if (piId == bugId) {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }

                }
            }

            //this.dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.Red;
            //this.dataGridView1.Rows[8].DefaultCellStyle = highlightCellStyle;
            //this.dataGridView1.Columns["UnitPrice"].DefaultCellStyle =
                //currencyCellStyle;
            //this.dataGridView1.Columns["TotalPrice"].DefaultCellStyle =
                //currencyCellStyle;

            //string bug_serverity = Convert.ToString(dataGridView1.Cells[2].Value);
            //dataGridView1.Rows
            //if (bug_serverity.Equals("Urgent")) {
            //r.DefaultCellStyle.BackColor = Color.Red;
            //dataGridView1.DefaultCellStyle.BackColor = Color.Red;

            //}

        }

        private void saveTextButton_Click(object sender, EventArgs e) {
        }

        private void BugInformation_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e) {
            //DeveloperDashboard developerDashboard = new DeveloperDashboard();
            //developerDashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            int bugId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue);

            //Console.WriteLine("userId: " + userId);
            //string hello = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            //MessageBox.Show(e.ColumnIndex + " is clicked with row " + userId);
            //r.Cells[3].Value

            if (e.ColumnIndex == 9) {
                BugStatus bugStatus = new BugStatus();
                bugStatus.getBugId(bugId);
                bugStatus.getDeveloperId(developerId);
                bugStatus.Show();
                this.Hide();
            }else if (e.ColumnIndex == 2) {
                MetroMessageBox.Show(this, dataDescription, "Bug Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (e.ColumnIndex == 3) {
                MetroMessageBox.Show(this, noteDescription, "Developer Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(e.ColumnIndex == 10) {
                HistoryInformation historyInformation = new HistoryInformation();
                historyInformation.getBugId(bugId, developerId, "unsolved");
                historyInformation.Show();
                this.Hide();
            }else if(e.ColumnIndex == 11) {
                DataConnection dataconnection = new DataConnection();       // Getting Database Connection
                SqlDataAdapter sqlnewDataAdapter = new SqlDataAdapter();
                DataTable datanewTable = new DataTable();
                sqlnewDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from photoTable WHERE bug = " + bugId + "");
                sqlnewDataAdapter.Fill(datanewTable);

                //Check here
                string link = "C:\\Users\\LENOVO\\source\\repos\\BugTrackingApplication\\BugTrackingApplication\\bin\\Debug\\Images";
                foreach (DataRow rownew in datanewTable.Rows) {
                    link = rownew["photo"].ToString();
                    //Console.WriteLine(developersName);
                }
                try {
                    System.Diagnostics.Process.Start(@link);
                } catch (Exception ex) {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }
        }
    }
}
