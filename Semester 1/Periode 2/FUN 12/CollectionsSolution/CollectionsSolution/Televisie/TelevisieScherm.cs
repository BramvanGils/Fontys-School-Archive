using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Televisie
{
    public partial class TelevisieScherm : Form
    {
        bool TelevisieAan = false;
        string[] Zender = new string[100];
        int HuidigeZender = 1;

        

        public TelevisieScherm()
        {
            InitializeComponent();
            Refresh();
            UpdateScreen();

            Program.MenuSchermen.Add(Zender[1]);
            Program.MenuSchermen[0] = "NPO1";
        }

        public string HaalHuidigeZenderOp()
        {
            return Zender[HuidigeZender]; 
        }

        public void VoegZenderToe(string ZenderNaam)
        {
            Zender[HuidigeZender] = ZenderNaam;
        }

        private void ButtonVoegZenderToe_Click(object sender, EventArgs e)
        {
            try
            {
                VoegZenderToe(Convert.ToString(Textbox.Text));
            }
            catch
            { }
            UpdateScreen();
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            TelevisieAan = !TelevisieAan;
            ZenderBox.Text = Convert.ToString(HuidigeZender);
            if (TelevisieAan)
            {
                PowerButton.Text = "Aan";
                ZenderBox.Enabled = true;
                Textbox.Enabled = true;
                ButtonVoegZenderToe.Enabled = true;
            }
            else
            {
                PowerButton.Text = "Uit";
                ZenderBox.Enabled = false;
                Textbox.Enabled = false;
                ButtonVoegZenderToe.Enabled = false;
            }
            UpdateScreen();
        }

        private void ZenderBox_ValueChanged(object sender, EventArgs e)
        {
            HuidigeZender = Convert.ToInt32(ZenderBox.Value);
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            try
            {
                Picturebox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"Images\" + HaalHuidigeZenderOp() + ".png");
            }
            catch
            {
                if (TelevisieAan)
                {
                    Picturebox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"Images\default.jpg");
                }
                else
                {
                    Picturebox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"Images\off.jpg");
                }
            }
        }
    }
}
