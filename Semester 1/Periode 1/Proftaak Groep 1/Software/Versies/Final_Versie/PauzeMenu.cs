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
    public partial class PauzeMenu : Form
    {
        MainFrame MAINFRAME;
        public PauzeMenu(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;
        }

        // Navigate to QuestInterface
        private void buttonPauzemenuSpelen_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "QuestInterface";
            Close();
        }

        // Navigate to Instellingen
        private void buttonPauzemenuInstellingen_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "Instellingen";
            Close();
        }

        // Navigate to MainMenu
        private void buttonPauzemenuHoofdmenu_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "MainMenu";
            Close();
        }
    }
}
