using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Versie
{
    public class MainFrame
    {
        public Form GameInterface;
        public Form Instellingen;
        public Form Inventaris;
        public Form MainForm;
        public Form MainMenu;
        public Form PauzeMenu;
        public Form RobotInstellingen;
        public Form Statestieken;
        public Form StartUp;

        //Constructor
        public MainFrame()
        {

        }

        //Main
        public void Main()
        {
            SwitchForm("GameInterface");
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
        public void SwitchForm(String NewForm)
        {
            switch (NewForm)
            {
                case "GameInterface":
                    MainFrame main1 = this;
                    GameInterface = new MainMenu(main1);
                    GameInterface.ShowDialog();
                    break;
                case "Instellingen":
                    MainFrame main2 = this;
                    Instellingen = new MainMenu(main2);
                    Instellingen.ShowDialog();
                    break;
                case "Inventaris":
                    MainFrame main3 = this;
                    Inventaris = new MainMenu(main3);
                    Inventaris.ShowDialog();
                    break;
                case "MainForm":
                    MainFrame main4 = this;
                    MainForm = new MainMenu(main4);
                    MainForm.ShowDialog();
                    break;
                case "MainMenu":
                    MainFrame main5 = this;
                    MainMenu = new MainMenu(main5);
                    MainMenu.ShowDialog();
                    break;
                case "PauzeMenu":
                    MainFrame main6 = this;
                    PauzeMenu = new MainMenu(main6);
                    PauzeMenu.ShowDialog();
                    break;
                case "RobotInstellingen":
                    MainFrame main7 = this;
                    RobotInstellingen = new MainMenu(main7);
                    RobotInstellingen.ShowDialog();
                    break;
                case "statestieken":
                    MainFrame main8 = this;
                    Statestieken = new MainMenu(main8);
                    Statestieken.ShowDialog();
                    break;
            }
        }
    }
}
