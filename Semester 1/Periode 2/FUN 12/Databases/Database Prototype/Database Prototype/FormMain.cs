using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Database_Prototype
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public FormMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Database_Prototype.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            UpdateLabel(GetCurrentIndex());
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RECIPES", connection))
            {
                DataTable RecipeTable = new DataTable();
                adapter.Fill(RecipeTable);

                listRecipes.DisplayMember = "Name";
                listRecipes.ValueMember = "Id";
                listRecipes.DataSource = RecipeTable;
            }
        }

        private DataTable GetCurrentIndex()
        {
            string query = "SELECT a.Name FROM RECIPES a WHERE Id = @Index";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Index", listRecipes.SelectedValue);

                DataTable RecipeTable = new DataTable();
                adapter.Fill(RecipeTable);

                return RecipeTable;
            }
        }

        private void AddData()
        {
            string query = "INSERT INTO Recipes VALUES (@RecipeName, 80, 'whatever') ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeName", "Big ol salad");

                command.ExecuteNonQuery();
            }
        }

        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabel(GetCurrentIndex());
        }

        private void UpdateLabel(DataTable DT)
        {
            label2.Text = DT.Rows[0][0].ToString();
        }
    }
}
