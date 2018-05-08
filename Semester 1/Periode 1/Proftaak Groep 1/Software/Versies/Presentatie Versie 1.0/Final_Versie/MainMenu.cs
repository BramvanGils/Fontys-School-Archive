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
    public partial class MainMenu : Form
    {
        MainFrame MAINFRAME;
        public MainMenu(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;
        }

        // Close APplication
        private void buttonSluitenMainmenu_Click(object sender, EventArgs e)
        {
            MAINFRAME.ReopenForm = false;
            Close();
        }
        
        // Navihate to Instellingen
        private void button1_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "Instellingen";
            Close();
        }

        // Navigate to MainForm
        private void buttonRobotinstellingenMainmenu_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "MainForm";
            Close();
        }
        
        // Navigate to QuestInterface
        private void buttonSpelenMainmenu_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "QuestInterface";
            Close();
        }
    }
}
