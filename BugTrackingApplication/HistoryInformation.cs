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
    public partial class HistoryInformation : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        private BindingSource bindingSource1 = new BindingSource();
        private int bugId, developerId;
        private string route;
        public HistoryInformation() {
            InitializeComponent();
        }
        /// <summary>
        /// Gets the Bug Information
        /// </summary>
        /// <param name="bId">Bug Id</param>
        /// <param name="dId">Developer Id</param>
        /// <param name="inf">Route Information</param>
        public void getBugId(int bId, int dId, string inf) {
            bugId = bId;
            developerId = dId;
            route = inf;
        }

        private void HistoryInformation_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            int bugFixed = 0;
            //Check Here
            Console.WriteLine("developerId");
            Console.WriteLine(developerId);
            //Check Here
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from noteTable WHERE bug = '" + bugId + "'");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataconnection.connectionStop();
        }

        private void metroButton1_Click(object sender, EventArgs e) {

            if (route == "solved") {
                BugSolvedInformation bugSolvedInformation = new BugSolvedInformation();
                bugSolvedInformation.getDeveloperId(developerId);
                bugSolvedInformation.Show();
                this.Hide();
            } else {
                BugInformation bugInformation = new BugInformation();
                bugInformation.getDeveloperId(developerId);
                bugInformation.Show();
                this.Hide();
            }

        }
    }
}
