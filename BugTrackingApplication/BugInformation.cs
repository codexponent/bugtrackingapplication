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

namespace BugTrackingApplication {
    public partial class BugInformation : Form {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        int developerId;
        public BugInformation() {
            InitializeComponent();
        }

        public void getDeveloperId(int id) {
            developerId = id;
        }

        private void BugInformation_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            int bugFixed = 0;
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from bugTable WHERE developer = '" + developerId + "' AND fix = '" + bugFixed + "'");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
        }

        private void saveTextButton_Click(object sender, EventArgs e) {
            sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
            sqlDataAdapter.Update((DataTable)bindingSource1.DataSource);
            MessageBox.Show("SAVED");
        }
    }
}
