using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingApplication {
    class DataConnection {

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bugtrackingapplication;Integrated Security=True";      //Connection String

        public DataTable connectionStart(string sqlQuery) {
            SqlConnection sqlConnection = new SqlConnection(connectionString);    //New SQL Connection
            sqlConnection.Open();                                       //Opening the New SQL Connection
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Console.WriteLine("DataTable");
            Console.WriteLine(cmd.ExecuteNonQuery().ToString());
            return dataTable;
        }

        public SqlConnection retrieveConnecion() {
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }

        public DataTable selectDataConnectionStart(string sqlQuery) {
            SqlConnection sqlConnection = new SqlConnection(connectionString);    //New SQL Connection
            sqlConnection.Open();                                       //Opening the New SQL Connection
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public SqlDataAdapter selectSelectedDataConnectionStart(string sqlQuery) {
            SqlConnection sqlConnection = new SqlConnection(connectionString);    //New SQL Connection
            sqlConnection.Open();                                       //Opening the New SQL Connection
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            return sqlDataAdapter;
        }

        public string selectConnectionStart(string sqlQuery) {
            SqlConnection sqlConnection = new SqlConnection(connectionString);    //New SQL Connection
            sqlConnection.Open();                                                 //Opening the New SQL Connection
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);
            return cmd.ExecuteScalar().ToString();
        }

        public string insertConnectionStart(string sqlQuery) {
            SqlConnection sqlConnection = new SqlConnection(connectionString);    // New SQL Connection
            sqlConnection.Open();                                                 // Opening the New SQL Connection
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);             // Creating the new SqlCommand Object
            return cmd.ExecuteNonQuery().ToString();
        }

        public string updateConnectionStart(string sqlQuery) {
            SqlConnection sqlConnection = new SqlConnection(connectionString);    // New SQL Connection
            sqlConnection.Open();                                                 // Opening the New SQL Connection
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnection);             // Creating the new SqlCommand Object
            return cmd.ExecuteNonQuery().ToString();
        }

        public void connectionStop() {
            SqlConnection sqlConnection = new SqlConnection(connectionString);    //New SQL Connection
            sqlConnection.Close();                                                //Closing Connection
        }

    }
}
