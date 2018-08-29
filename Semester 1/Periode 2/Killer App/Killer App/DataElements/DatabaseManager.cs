using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Killer_App
{
    static class DatabaseManager
    {

        static SqlConnection connection;
        static string connectionString;
        static List<string> list = new List<string>();

        static DatabaseManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Killer_App.Properties.Settings.BiljartDatabaseConnectionString"].ConnectionString;
        }
        
        public static int GetGebruikersId(string Naam)
        {
            string query = "SELECT Id FROM Gebruikers WHERE Naam = @Naam";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Naam", Naam);

                DataTable IdTable = new DataTable();
                adapter.Fill(IdTable);
                return Convert.ToInt32(IdTable.Rows[0][0]);
            }
        }

        private static string GetWachtwoord (int Id)
        {
            string query = "SELECT Wachtwoord FROM Gebruikers WHERE Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", Id);

                DataTable WachtwoordTable = new DataTable();
                adapter.Fill(WachtwoordTable);
                return Convert.ToString(WachtwoordTable.Rows[0][0]);
            }
        }

        public static bool CompareLoginData(int Id, string Wachtwoord)
        {
            return GetWachtwoord(Id) == Wachtwoord;
        }

        /// <summary>
        /// Will return an out of range exception if the password doesn't exist.
        /// </summary>
        /// <param name="Wachtwoord"></param>
        public static void ExistingPassword(string Wachtwoord)
        {
            string query = "SELECT Wachtwoord FROM Gebruikers WHERE Wachtwoord = @Wachtwoord";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Wachtwoord", Wachtwoord);

                DataTable WachtwoordTable = new DataTable();
                adapter.Fill(WachtwoordTable);
                Convert.ToString(WachtwoordTable.Rows[0][0]);
            }
        }

        public static void AddGebruiker(string Naam, string Wachtwoord)
        {
            string query = "INSERT INTO Gebruikers VALUES (NULL, NULL, @Naam, @Wachtwoord, NULL)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                
                command.Parameters.AddWithValue("@Naam", Naam);
                command.Parameters.AddWithValue("@Wachtwoord", Wachtwoord);

                command.ExecuteScalar();
                connection.Close();
            }
        }

        public static string RetrieveGebruikerNaam(int Id)
        {
            string query = "SELECT Naam FROM Gebruikers WHERE Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", Id);

                DataTable NameTable = new DataTable();
                adapter.Fill(NameTable);
                return Convert.ToString(NameTable.Rows[0][0]);
            }
        }

        public static Image RetrieveGebruikerFoto(int Id)
        {
            string query = "SELECT ProfielFoto FROM Gebruikers WHERE Id = @Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id", Id);

                DataTable NameTable = new DataTable();
                adapter.Fill(NameTable);
                try
                {
                    return (Image)NameTable.Rows[0][0];
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}