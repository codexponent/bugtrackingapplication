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
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace BugTrackingApplication {
    public partial class AdminPanel : MetroForm {
        private SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public AdminPanel() {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e) {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void AdminPanel_Load(object sender, EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MetroMessageBox.Show(this, "Welcome To Admin Panel", "Admin Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
            Intro intro = new Intro();
            intro.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e) {
            //Excel Saved File Here
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("User Sheet");

            //Adding the Titles
            worksheet.Cell("A1").Value = "Name";
            worksheet.Cell("B1").Value = "UserName";
            worksheet.Cell("C1").Value = "Email";
            worksheet.Cell("D1").Value = "Gender";
            worksheet.Cell("E1").Value = "Address";

            int count = 2;
            DataConnection dataconnection = new DataConnection();
            string sqlSelectQuery = "SELECT  * from userTable";
            sqlDataAdapter = dataconnection.selectSelectedDataConnectionStart(sqlSelectQuery);
            sqlDataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows) {
                worksheet.Cell("A" + count).Value = row["name"].ToString();
                worksheet.Cell("B" + count).Value = row["username"].ToString();
                worksheet.Cell("C" + count).Value = row["email"].ToString();
                worksheet.Cell("D" + count).Value = row["gender"].ToString(); ;
                worksheet.Cell("E" + count).Value = row["address"].ToString(); ;
                count++;
            }
            workbook.SaveAs("UserSheet.xlsx");
            MetroMessageBox.Show(this, "Excel File Successfully Created", "Action Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try {
                System.Diagnostics.Process.Start("C:\\Users\\LENOVO\\source\\repos\\BugTrackingApplication\\BugTrackingApplication\\bin\\Debug");
            } catch (Exception ex) {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void usersToolStripMenuItem2_Click(object sender, EventArgs e) {
            AdminChart adminChart = new AdminChart();
            adminChart.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem3_Click(object sender, EventArgs e) {
            UserChart userChart = new UserChart();
            userChart.Show();
            this.Hide();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e) {
            AdminProjectTable adminProjectTable = new AdminProjectTable();
            adminProjectTable.Show();
            this.Hide();
        }
    }
}
