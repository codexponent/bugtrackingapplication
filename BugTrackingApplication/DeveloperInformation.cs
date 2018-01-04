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
    public partial class DeveloperInformation : Form {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        DataTable dataTable = new DataTable();
        public DeveloperInformation() {
            InitializeComponent();
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
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart("SELECT id, name, project, flag from userTable WHERE role=201");
            sqlDataAdapter.Fill(dataTable);
            bindingSource1.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource1;

            //new code written
            dataGridView1.ReadOnly = true;
            //Make link in accept flag columns for each row.
            foreach (DataGridViewRow r in dataGridView1.Rows) {
                DataGridViewLinkCell dataGridViewLinkCell = new DataGridViewLinkCell();
                dataGridViewLinkCell.Value = r.Cells[3].Value;
                //Change the checkbox here

                //dataGridView1[3, r.Index] = dataGridViewLinkCell;


                //dataGridView1.Columns[3].Name = "Flag";
                
                //DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                //{
                    //column.HeaderText = dataGridView1.Columns[3].Name;
                    //column.Name = dataGridView1.Columns[3].Name;
                    //column.AutoSizeMode =
                        //DataGridViewAutoSizeColumnMode.DisplayedCells;
                    //column.FlatStyle = FlatStyle.Standard;
                    //column.ThreeState = true;
                    //column.CellTemplate = new DataGridViewCheckBoxCell();
                    //column.CellTemplate.Style.BackColor = Color.Beige;
                //}

                //dataGridView1.Columns.Insert(4, column);

            }
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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

                if (returnValue == "1") {
                    LoadDataGrid();
                }
            }
        }

        private void LoadDataGrid() //This methods is identical to AcceptUser_Load but is called when the update to the accept_flag is called.
        {
            DataConnection dataConnection = new DataConnection();
            string selectQuery = "SELECT id, name, project, flag from userTable WHERE role=201";
            SqlDataAdapter dataAdapter;
            dataAdapter = dataConnection.selectSelectedDataConnectionStart(selectQuery);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.ReadOnly = true;

            foreach (DataGridViewRow r in dataGridView1.Rows) {
                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                lc.Value = r.Cells[3].Value;
                dataGridView1[3, r.Index] = lc;
            }

            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);

            dataConnection.connectionStop();
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

        }
    }
}
