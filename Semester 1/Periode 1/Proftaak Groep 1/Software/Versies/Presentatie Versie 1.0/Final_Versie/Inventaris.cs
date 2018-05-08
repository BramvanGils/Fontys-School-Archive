using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Versie
{
    public partial class Inventaris : Form
    {

        MainFrame MAINFRAME;
        public Inventaris(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;

            UpdateAll();
            UpdateLevelBars();
            UpdateLevelLabels();
        }

        // Update all medals
        private void UpdateAll()
        {
            for (byte i = 1; i < 13; i++)
            {
                UpdateMedal(i);
            }
        }

        // Update a Medal
        private void UpdateMedal(byte Index)
        {
            if (MAINFRAME.CompletionList[Index] >= 10)
            {
                IndexToItem(Index).Image = MAINFRAME.GoldMedal;
            }
            else if (MAINFRAME.CompletionList[Index] >= 3)
            {
                IndexToItem(Index).Image = MAINFRAME.SilverMedal;
            }
            else if (MAINFRAME.CompletionList[Index] >= 1)
            {
                IndexToItem(Index).Image = MAINFRAME.BronzeMedal;
            }
        }

        // Update Level ProgresBars
        public void UpdateLevelBars()
        {
            double RekenenXPFull = (MAINFRAME.LevelToXp(MAINFRAME.RekenenLevel + 1) - MAINFRAME.LevelToXp(MAINFRAME.RekenenLevel));
            double RekenenXPNeeded = (MAINFRAME.RekenenXP - MAINFRAME.LevelToXp(MAINFRAME.RekenenLevel));
            progressBarStatestiekenRekenen.Value = Convert.ToInt32(RekenenXPNeeded / RekenenXPFull * 100);

            double NederlandsXPFull = (MAINFRAME.LevelToXp(MAINFRAME.NederlandsLevel + 1) - MAINFRAME.LevelToXp(MAINFRAME.NederlandsLevel));
            double NederlandsXPNeeded = (MAINFRAME.NederlandsXP - MAINFRAME.LevelToXp(MAINFRAME.NederlandsLevel));
            progressBarStatestiekenNederlands.Value = Convert.ToInt32(NederlandsXPNeeded / NederlandsXPFull * 100);

            double EngelsXPFull = (MAINFRAME.LevelToXp(MAINFRAME.EngelsLevel + 1) - MAINFRAME.LevelToXp(MAINFRAME.EngelsLevel));
            double EngelsXPNeeded = (MAINFRAME.EngelsXP - MAINFRAME.LevelToXp(MAINFRAME.EngelsLevel));
            progressBarStatestiekenEngels.Value = Convert.ToInt32(EngelsXPNeeded / EngelsXPFull * 100);
        }

        // Update Level Values
        public void UpdateLevelLabels()
        {
            RekenenLevelLabel.Text = "Level: " + Convert.ToString(MAINFRAME.RekenenLevel);
            NederlandsLevelLabel.Text = "Level: " + Convert.ToString(MAINFRAME.NederlandsLevel);
            EngelsLevelLabel.Text = "Level: " + Convert.ToString(MAINFRAME.EngelsLevel);
        }

        // Navigate to statestieken
        private void buttonInventarisVorigepagina_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "statestieken";
            Close();
        }

        // Navigate to QuestLog
        private void buttonInventarisvolgendepagina_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "QuestLog";
            Close();
        }

        // Navigate to QuestInterface
        private void buttonInventarisTerug_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "MainForm";
            Close();
        }

        

        private PictureBox IndexToItem(byte Index)
        {
            switch (Index)
            {
                case 1:
                    return BoxCommonRekenen;
                case 2:
                    return BoxCommonNederlands;
                case 3:
                    return BoxCommonEngels;
                case 4:
                    return BoxRareRekenen;
                case 5:
                    return BoxRareNederlands;
                case 6:
                    return BoxRareEngels;
                case 7:
                    return BoxEpicRekenen;
                case 8:
                    return BoxEpicNederlands;
                case 9:
                    return BoxEpicEngels;
                case 10:
                    return BoxLegendaryRekenen;
                case 11:
                    return BoxLegendaryNederlands;
                case 12:
                    return BoxLegendaryEngels;
                default:
                    return null;
            }
        }


        
        private void BoxCommonRekenen_Click(object sender, EventArgs e)
        {
  //          Click(1);
        }

        private void BoxCommonNederlands_Click(object sender, EventArgs e)
        {
 //           Click(2);
        }

        private void BoxCommonEngels_Click(object sender, EventArgs e)
        {
   //         Click(3);
        }

        private void BoxRareRekenen_Click(object sender, EventArgs e)
        {
   //         Click(4);
        }

        private void BoxRareNederlands_Click(object sender, EventArgs e)
        {
    //        Click(5);
        }

        private void BoxRareEngels_Click(object sender, EventArgs e)
        {
    //        Click(6);
        }

        private void BoxEpicRekenen_Click(object sender, EventArgs e)
        {
    //        Click(7);
        }

        private void BoxEpicNederlands_Click(object sender, EventArgs e)
        {
    //        Click(8);
        }

        private void BoxEpicEngels_Click(object sender, EventArgs e)
        {
    //        Click(9);
        }

        private void BoxLegendaryRekenen_Click(object sender, EventArgs e)
        {
    //        Click(10);
        }

        private void BoxLegendaryNederlands_Click(object sender, EventArgs e)
        {
     //       Click(11);
        }

        private void BoxLegendaryEngels_Click(object sender, EventArgs e)
        {
    //        Click(12);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void Inventaris_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
        }
    }
}
