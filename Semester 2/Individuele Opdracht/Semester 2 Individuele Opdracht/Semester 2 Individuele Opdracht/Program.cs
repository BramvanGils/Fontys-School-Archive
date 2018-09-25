using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semester_2_Individuele_Opdracht.Forms;

namespace Semester_2_Individuele_Opdracht
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bramv\Documents\GitHub\Fontys-School-Archive\Semester 2\Individuele Opdracht\Semester 2 Individuele Opdracht\Semester 2 Individuele Opdracht\RPG_Database.mdf;Integrated Security=True";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DetailsForm());/*
            DetailsForm detailsForm = new DetailsForm();
            detailsForm.Show();*/
        }
    }
}
