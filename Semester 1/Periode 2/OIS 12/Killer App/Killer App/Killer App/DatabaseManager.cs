using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Killer_App
{
    class DatabaseManager
    {
        SqlConnection connection;
        string connectionString;
        List<string> list = new List<string>();

        public DatabaseManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Database_Prototype.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void PopulateRecipes()
        {
            string query = "SELECT A.Name FROM RECIPES A" + 
                "INNER JOIN RecipeIngredients";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", 1);

                DataTable RecipeTable = new DataTable();
                adapter.Fill(RecipeTable);

            }
        }

        private void AddData()
        {
            string query = "SELECT * FROM ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", 1);

                DataTable RecipeTable = new DataTable();
                adapter.Fill(RecipeTable);

            }
        }
    }
}
