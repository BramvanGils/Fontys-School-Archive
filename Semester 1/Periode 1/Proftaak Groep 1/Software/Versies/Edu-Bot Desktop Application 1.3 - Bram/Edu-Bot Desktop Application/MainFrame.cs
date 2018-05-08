// creating using refernces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stats;
using instellingen;
using Inventory;
using Robot_instellingen;
using Game_Interface;
using EV3RemoteControlWifi;

namespace Edu_Bot_Desktop_Application
{
    public class MainFrame
    {
        public Form GameInterface = new GameInterface();
        public Form Instellingen = new Instellingen();
        public Form Inventaris = new Inventaris();
        public Form MainForm = new Mainform();
        public Form MainMenu = new Mainmenu();
        public Form PauzeMenu = new Pauzemenu();
        public Form RobotInstellingen = new Robotinstellingen();
        public Form Statestieken = new Statestieken();
        public Form StartUp = new Form();

        
        //Constructor
        public MainFrame()    
        {
            
        }

        //Main
        public void Main()
        {
            SwitchForm(StartUp);
        }

        // Calculate Level Based on XP
        public int XpToLevel(int SendXP)
        {
            int Outcome = 1;
            for (int Level = 0; SendXP > LevelToXp(Level); Level++)
            {
                Outcome = Level;
            }
            return Outcome;
        }

        // Calculate minimum XP based on Level
        public int LevelToXp(int SendLevel)
        {
            int XP = 0;
            for (int Level = 1; Level < SendLevel; Level++)
            {
                XP += 1000 + (Level - 1) * (Level - 1) * 100;
            }
            return XP;
        }

        // Switch to Another From
        public void SwitchForm(Form NewForm)
        {
            if (NewForm == StartUp)
            {
                //Application.Run(MainMenu);
                MainMenu.ShowDialog();
            }
            else
            {
                Application.Run(NewForm);
            }
        }
    }
}
