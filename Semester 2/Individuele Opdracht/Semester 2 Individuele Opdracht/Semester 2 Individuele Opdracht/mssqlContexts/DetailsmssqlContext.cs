using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semester_2_Individuele_Opdracht.Interfaces;

namespace Semester_2_Individuele_Opdracht.mssqlContexts
{
    class DetailsmssqlContext: IDetailsContext
    {
        SqlConnection connection;
        private string connectionstring = Program.ConnectionString;

        public string GetTitle(int Id)
        {
            string query = "SELECT Name FROM Quest WHERE Id = @Id";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand comand = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comand))
            {
                DataTable dataTable = new DataTable();
                comand.Parameters.AddWithValue("@Id", Id);
                adapter.Fill(dataTable);
                return (string)dataTable.Rows[0][0];
            }
        }

        public string GetDescription(int Id)
        {
            string query = "SELECT Description FROM Quest WHERE Id = @Id";
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand comand = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comand))
            {
                DataTable dataTable = new DataTable();
                comand.Parameters.AddWithValue("@Id", Id);
                adapter.Fill(dataTable);
                return (string)dataTable.Rows[0][0];
            }
        }
    }
}
