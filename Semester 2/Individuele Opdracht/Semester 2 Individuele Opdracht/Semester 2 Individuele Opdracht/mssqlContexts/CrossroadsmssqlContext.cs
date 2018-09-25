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
    class CrossroadsmssqlContext
    {
        SqlConnection connection;
        private string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Git Projects\Fontys-School-Archive\Semester 2\Individuele Opdracht\Semester 2 Individuele Opdracht\Semester 2 Individuele Opdracht\RPG_Database.mdf;Integrated Security=True";
    }
}
