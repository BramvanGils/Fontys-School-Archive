using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Versie
{
    public class MainFrame
    {
        //Creating all Form Classes
        public Form GameInterface;
        public Form Instellingen;
        public Form Inventaris;
        public Form MainForm;
        public Form MainMenu;
        public Form PauzeMenu;
        public Form Statestieken;
        public Form StartUp;
        public Form QuestInterface;
        public Form QuestLog;

        //Creating Form Variables
        public string NextForm = "StartUp";
        public string LastForm;
        public bool ReopenForm = true;

        // debug value
        public int test = 3;

        //--------------------------------------------------------------------------------------------------

        // level Stats
        public int RekenenXP = 750;
        public int NederlandsXP = 250;
        public int EngelsXP = 500;
        public int RekenenLevel = 0;
        public int NederlandsLevel = 0;
        public int EngelsLevel = 0;

        // Lootbox Cache
        public int CommonLootbox = 0;
        public int RareLootbox = 0;
        public int EpicLootbox = 0;
        public int LegendaryLootbox = 0;

        // Health, Stamina en Mana
        public int Health = 70;
        public int Stamina = 55;
        public int Mana = 10;
        public int MaxHealth = 110;
        public int MaxStamina = 110;
        public int MaxMana = 110;

        //load Images
            //Itemslots
            public Image DefaultItemslot = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\DefaultItemslot.png");
            public Image RareItemslot = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\RareItemslot.png");
            public Image EpicItemslot = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\EpicItemslot.png");
            public Image LegendaryItemslot = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\LegendaryItemslot.png");
            //Selected itemslot
            public Image DefaultItemslotActive = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\DefaultItemslotActive.png");
            public Image RareItemslotActive = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\RareItemslotActive.png");
            public Image EpicItemslotActive = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\EpicItemslotActive.png");
            public Image LegendaryItemslotActive = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Resources\LegendaryItemslotActive.png");

        /// <summary>
        /// The Data for all the items will be stored in this 2 dimensional Array
        /// Data is Stored in the following Structure:
        /// Row number: 1 = Type (MainHand , OffHand , HeadGear , ChestGear , LegGear , Consumable)
        ///             2 = Rarity (Common , Rare , Epic , Legendary)
        ///             3 = Requirement Type
        ///             4 = Requiremnt Level
        /// </summary>

        // Items Managment
        public string[,] ItemDatabase = new string[,]
        { 
/*0  */     {""             ,""         ,"",""},
/*1  */     {"MainHand"     ,"Rare"     ,"",""},
/*2  */     {"MainHand"     ,"Epic"     ,"",""},
/*3  */     {"MainHand"     ,"Legendary","",""},
/*4  */     {"Offhand"      ,"Common"   ,"",""},
/*5  */     {"Offhand"      ,"Rare"     ,"",""},
/*6  */     {"Offhand"      ,"Epic"     ,"",""},
/*7  */     {"Offhand"      ,"Legendary","",""},
/*8  */     {"HeadGear"     ,"Common"   ,"",""},
/*9  */     {"HeadGear"     ,"Rare"     ,"",""},
/*10  */    {"HeadGear"     ,"Epic"     ,"",""},
/*11  */    {"HeadGear"     ,"Legendary","",""},
/*12  */    {"ChestGear"    ,"Common"   ,"",""},
/*13  */    {"ChestGear"    ,"Rare"     ,"",""},
/*14  */    {"ChestGear"    ,"Epic"     ,"",""},
/*15  */    {"ChestGear"    ,"Legendary","",""},
/*16  */    {"LegGear"      ,"Common"   ,"",""},
/*17  */    {"LegGear"      ,"Rare"     ,"",""},
/*18  */    {"LegGear"      ,"Epic"     ,"",""},
/*19  */    {"LegGear"      ,"Legendary","",""},
/*20  */    {"Consumable"   ,"Common"   ,"",""},
/*21  */    {"Consumable"   ,"Rare"     ,"",""},
/*22  */    {"Consumable"   ,"Epic"     ,"",""},
/*23  */    {"Consumable"   ,"Legendary","",""}
        };

        // Items in inventory
        public int[] InventoryLoadout = new int[]
        {
/*0  */ 1,
/*1  */ 0,
/*2  */ 1,
/*3  */ 0,
/*4  */ 1,
/*5  */ 0,
/*6  */ 0,
/*7  */ 0,
/*8  */ 0,
/*9  */ 0,
/*10  */ 0,
/*11  */ 0,
/*12  */ 0,
/*13  */ 0,
/*14  */ 0,
/*15  */ 0,
/*16  */ 0,
/*17  */ 0,
/*18  */ 0,
/*19  */ 0,
/*20  */ 0,
/*21  */ 0,
/*22  */ 0,
/*23  */ 0,
/*24  */ 0,
/*25  */ 0,
/*26  */ 0,
/*27  */ 0,
/*28  */ 0,
/*29  */ 0,
/*30  */ 0,
/*31  */ 0,
/*32  */ 0,
/*33  */ 0,
/*34  */ 0,
/*TEMP*/ 0
        };

        //Constructor
        public MainFrame()
        {

        }

        //Main
        public void Main()
        {
            while (ReopenForm)
            {
                SwitchForm(NextForm);
            }
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

        //Calculate MaxStats
        public int CalculateMax(int Level)
        {
            return 100 + 10 * Level;
        }

        // Switch to Another From and update Level Stats
        public void SwitchForm(String NewForm)
        {
            switch (NewForm)
            {
                case "StartUp":
                    MainFrame main = this;
                    MainMenu = new MainMenu(main);
                    MainMenu.ShowDialog();
                    break;
                case "GameInterface":
                    MainFrame main1 = this;
                    GameInterface = new GameInterface(main1);
                    GameInterface.ShowDialog();
                    break;
                case "Instellingen":
                    MainFrame main2 = this;
                    Instellingen = new Instellingen(main2);
                    Instellingen.ShowDialog();
                    break;
                case "Inventaris":
                    Inventaris = new Inventaris(this);
                    Inventaris.ShowDialog();
                    break;
                case "MainForm":
                    MainFrame main4 = this;
                    MainForm = new Mainform(main4);
                    MainForm.ShowDialog();
                    break;
                case "MainMenu":
                    MainFrame main5 = this;
                    MainMenu = new MainMenu(main5);
                    MainMenu.ShowDialog();
                    break;
                case "PauzeMenu":
                    MainFrame main6 = this;
                    PauzeMenu = new PauzeMenu(main6);
                    PauzeMenu.ShowDialog();
                    break;
                case "statestieken":
                    MainFrame main7 = this;
                    Statestieken = new statestieken(main7);
                    Statestieken.ShowDialog();
                    break;
                case "QuestInterface":
                    MainFrame main8 = this;
                    QuestInterface = new QuestInterface(main8);
                    QuestInterface.ShowDialog();
                    break;
                case "QuestLog":
                    MainFrame main9 = this;
                    QuestLog = new QuestLog(main9);
                    QuestLog.ShowDialog();
                    break;
            }

            //Store the name of the closed form into a Variable
            LastForm = NewForm;

            //Update Level stats
            RekenenLevel = XpToLevel(RekenenXP);
            NederlandsLevel = XpToLevel(NederlandsXP);
            EngelsLevel = XpToLevel(EngelsXP);

            //Update Max Stats
            MaxHealth = CalculateMax(RekenenLevel);
            MaxStamina = CalculateMax(NederlandsLevel);
            MaxMana = CalculateMax(EngelsLevel);
        }
    }
}
