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

        // Indicates the selected item in the Inventory interface
        byte SelectedItem = 3;

        MainFrame MAINFRAME;
        public Inventaris(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;

            UpdateAll();
        }

        //Method for all Click Events
        private void ManageClick(PictureBox box, byte Index)
        {
            
            UpdateCheckState(box, Index);
            

        }

        //Changes button to the selescted state
        private void UpdateCheckState(PictureBox box, byte Index)
        {
            if (Index == SelectedItem)
            {
                //unselect Item
                SelectedItem = 0;
                UpdateItemBox(IndexToItem(Index), Index);
            }
            else if(SelectedItem == 0)
            {
                //Select New
                byte OldSelect = SelectedItem;
                SelectedItem = Index;
                UpdateItemBox(IndexToItem(Index), Index);
                UpdateItemBox(IndexToItem(OldSelect), OldSelect);
            }
            else
            {
                //Switch Data
                MAINFRAME.InventoryLoadout[35] = MAINFRAME.InventoryLoadout[Index];
                MAINFRAME.InventoryLoadout[Index] = MAINFRAME.InventoryLoadout[SelectedItem];
                MAINFRAME.InventoryLoadout[SelectedItem] = MAINFRAME.InventoryLoadout[35];
            }
        }

        //Update the Background of all Item Boxes
        private void UpdateItemBox(PictureBox box , byte Index)
        {
            if(Index > 0)
            {
                switch (MAINFRAME.ItemDatabase[MAINFRAME.InventoryLoadout[Index - 1], 1])
                {
                    case "":
                        if (SelectedItem == Index)
                        {
                            box.BackgroundImage = MAINFRAME.DefaultItemslotActive;
                        }
                        else
                        {
                            box.BackgroundImage = MAINFRAME.DefaultItemslot;
                        }
                        break;
                    case "Common":
                        if (SelectedItem == Index)
                        {
                            box.BackgroundImage = MAINFRAME.DefaultItemslotActive;
                        }
                        else
                        {
                            box.BackgroundImage = MAINFRAME.DefaultItemslot;
                        }
                        break;
                    case "Rare":
                        if (SelectedItem == Index)
                        {
                            box.BackgroundImage = MAINFRAME.RareItemslotActive;
                        }
                        else
                        {
                            box.BackgroundImage = MAINFRAME.RareItemslot;
                        }
                        break;
                    case "Epic":
                        if (SelectedItem == Index)
                        {
                            box.BackgroundImage = MAINFRAME.EpicItemslotActive;
                        }
                        else
                        {
                            box.BackgroundImage = MAINFRAME.EpicItemslot;
                        }
                        break;
                    case "Legendary":
                        if (SelectedItem == Index)
                        {
                            box.BackgroundImage = MAINFRAME.LegendaryItemslotActive;
                        }
                        else
                        {
                            box.BackgroundImage = MAINFRAME.LegendaryItemslot;
                        }
                        break;
                }
            }
        }




        //All click events
        private void InventarisItem1_Click(object sender, EventArgs e)
        {
            byte Index = 1;
            ManageClick((PictureBox)sender,Index);
        }

        private void InventarisItem2_Click(object sender, EventArgs e)
        {
            byte Index = 2;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem3_Click(object sender, EventArgs e)
        {
            byte Index = 3;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem4_Click(object sender, EventArgs e)
        {
            byte Index = 4;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem5_Click(object sender, EventArgs e)
        {
            byte Index = 5;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem6_Click(object sender, EventArgs e)
        {
            byte Index = 6;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem7_Click(object sender, EventArgs e)
        {
            byte Index = 7;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem8_Click(object sender, EventArgs e)
        {
            byte Index = 8;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem9_Click(object sender, EventArgs e)
        {
            byte Index = 9;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem10_Click(object sender, EventArgs e)
        {
            byte Index = 10;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem11_Click(object sender, EventArgs e)
        {
            byte Index = 11;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem12_Click(object sender, EventArgs e)
        {
            byte Index = 12;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem13_Click(object sender, EventArgs e)
        {
            byte Index = 13;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem14_Click(object sender, EventArgs e)
        {
            byte Index = 14;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem15_Click(object sender, EventArgs e)
        {
            byte Index = 15;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem16_Click(object sender, EventArgs e)
        {
            byte Index = 16;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem17_Click(object sender, EventArgs e)
        {
            byte Index = 17;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem18_Click(object sender, EventArgs e)
        {
            byte Index = 18;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem19_Click(object sender, EventArgs e)
        {
            byte Index = 19;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem20_Click(object sender, EventArgs e)
        {
            byte Index = 20;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem21_Click(object sender, EventArgs e)
        {
            byte Index = 21;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem22_Click(object sender, EventArgs e)
        {
            byte Index = 22;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem23_Click(object sender, EventArgs e)
        {
            byte Index = 23;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem24_Click(object sender, EventArgs e)
        {
            byte Index = 24;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem25_Click(object sender, EventArgs e)
        {
            byte Index = 25;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem26_Click(object sender, EventArgs e)
        {
            byte Index = 26;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem27_Click(object sender, EventArgs e)
        {
            byte Index = 27;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem28_Click(object sender, EventArgs e)
        {
            byte Index = 28;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem29_Click(object sender, EventArgs e)
        {
            byte Index = 29;
            ManageClick((PictureBox)sender, Index);
        }

        private void InventarisItem30_Click(object sender, EventArgs e)
        {
            byte Index = 30;
            ManageClick((PictureBox)sender, Index);
        }

        private void ItemBoxHoofd_Click(object sender, EventArgs e)
        {
            byte Index = 31;
            ManageClick((PictureBox)sender, Index);
        }

        private void ItemBoxTorso_Click(object sender, EventArgs e)
        {
            byte Index = 32;
            ManageClick((PictureBox)sender, Index);
        }

        private void ItemBoxBenen_Click(object sender, EventArgs e)
        {
            byte Index = 33;
            ManageClick((PictureBox)sender, Index);
        }

        private void ItemBoxMainHand_Click(object sender, EventArgs e)
        {
            byte Index = 34;
            ManageClick((PictureBox)sender, Index);
        }

        private void ItemBoxOffHand_Click(object sender, EventArgs e)
        {
            byte Index = 35;
            ManageClick((PictureBox)sender, Index);
        }

        private void UpdateAll()
        {
            for (byte item = 1; item <= 35; item++)
            {
                UpdateItemBox(IndexToItem(item), item);
            }
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
            MAINFRAME.NextForm = "QuestInterface";
            Close();
        }

        private PictureBox IndexToItem(byte Index)
        {
            switch (Index)
            {
                case 1:
                    return InventarisItem1;
                case 2:
                    return InventarisItem2;
                case 3:
                    return InventarisItem3;
                case 4:
                    return InventarisItem4;
                case 5:
                    return InventarisItem5;
                case 6:
                    return InventarisItem6;
                case 7:
                    return InventarisItem7;
                case 8:
                    return InventarisItem8;
                case 9:
                    return InventarisItem9;
                case 10:
                    return InventarisItem10;
                case 11:
                    return InventarisItem11;
                case 12:
                    return InventarisItem12;
                case 13:
                    return InventarisItem13;
                case 14:
                    return InventarisItem14;
                case 15:
                    return InventarisItem15;
                case 16:
                    return InventarisItem16;
                case 17:
                    return InventarisItem17;
                case 18:
                    return InventarisItem18;
                case 19:
                    return InventarisItem19;
                case 20:
                    return InventarisItem20;
                case 21:
                    return InventarisItem21;
                case 22:
                    return InventarisItem22;
                case 23:
                    return InventarisItem23;
                case 24:
                    return InventarisItem24;
                case 25:
                    return InventarisItem25;
                case 26:
                    return InventarisItem26;
                case 27:
                    return InventarisItem27;
                case 28:
                    return InventarisItem28;
                case 29:
                    return InventarisItem29;
                case 30:
                    return InventarisItem30;
                case 31:
                    return ItemBoxHoofd;
                case 32:
                    return ItemBoxTorso;
                case 33:
                    return ItemBoxBenen;
                case 34:
                    return ItemBoxMainHand;
                case 35:
                    return ItemBoxOffHand;
                default:
                    return null;
            }
        }
    }
}
