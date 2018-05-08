using Stats;
using instellingen;
using Inventory;
using Robot_instellingen;
using Game_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EV3RemoteControlWifi;

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
            //Application.Run(new MainFrame());

            MainFrame MainFrame = new MainFrame();
            MainFrame.Main();
            MainFrame main2 = MainFrame;

            
        }
    }
}