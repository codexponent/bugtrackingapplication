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
    public partial class BugSolvedInformation : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        int developerId;
        public BugSolvedInformation() {
            InitializeComponent();
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
        /// Get the Developer ID
        /// </summary>
        /// <param name="id"></param>
        public void getDeveloperId(int id) {
            developerId = id;
        }

        private void BugSolvedInformation_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            int bugFixed = 1;
            //Check here
            Console.WriteLine("developerId");
            Console.WriteLine(developerId);
            //Check Here
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from bugTable WHERE developer = '" + developerId + "' AND fix = '" + bugFixed + "'");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            historyButton();
            imageButton();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();
        }

        private void BugSolvedInformation_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            //DeveloperDashboard developerDashboard = new DeveloperDashboard();
            //developerDashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            int bugId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue);
            if (e.ColumnIndex == 9) {
                HistoryInformation historyInformation = new HistoryInformation();
                historyInformation.getBugId(bugId, developerId, "solved");
                historyInformation.Show();
                this.Hide();
            }else if (e.ColumnIndex == 10) {
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
