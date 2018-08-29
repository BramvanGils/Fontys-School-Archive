using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Klasse
{
    class Database
    {
        public string ConnectionString = "(Microsoft.SqlServer)\v11.0";


        public void open()
        {
            Console.Out.WriteLine("Verbonden met " + ConnectionString);
        }

        public string Execute(string input)
        {
            return "Moet nog gemaakt worden";
        }
    }
}
