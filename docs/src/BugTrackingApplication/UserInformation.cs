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
    public partial class UserInformation : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        public UserInformation() {
            InitializeComponent();
            //setupColumns();
            //addData();
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

        private void UserInformation_Load(object sender, EventArgs e) {
            DataConnection dataconnection = new DataConnection();       // Getting Database Connection
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT * from userTable");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;

            addButton();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataconnection.connectionStop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            //if (e.ColumnIndex == dataGridView1.Columns["uninstall_column"].Index) {
                //Do something with your button.
              //  Console.WriteLine("I m clicked");
            //}
        }

        private void saveButton_Click(object sender, EventArgs e) {
            sqlDataAdapter.UpdateCommand = new SqlCommandBuilder(sqlDataAdapter).GetUpdateCommand();
            sqlDataAdapter.Update((DataTable)bindingSource1.DataSource);
            MessageBox.Show("SAVED");
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e) {
            //Column Index gives the value of the button clicked
            //e.ColumnIndex

            int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue);

            //Console.WriteLine("userId: " + userId);
            //string hello = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            //MessageBox.Show(e.ColumnIndex + " is clicked with row " + userId);
            //r.Cells[3].Value

            if (e.ColumnIndex == 10) {
                UserTable userTable = new UserTable();
                userTable.getUserId(userId);
                userTable.Show();
                this.Hide();
            }

        }

        private void metroButton1_Click(object sender, EventArgs e) {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void UserInformation_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
