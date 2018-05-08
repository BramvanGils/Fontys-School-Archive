using Stats;
using instellingen;
using Inventory;
using Robot_instellingen;
using Edubot;
using pauzemenu;
using Game_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Bot_Desktop_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameInterface());
            //Application.Run(new Instellingen());
            //Application.Run(new Inventaris());
            //Application.Run(new Pauzemenu());
            //Application.Run(new Mainmenu());
            //Application.Run(new Pauzemenu());
            //Application.Run(new Robotinstellingen());
            //Application.Run(new Statestieken());
        }
    }
}