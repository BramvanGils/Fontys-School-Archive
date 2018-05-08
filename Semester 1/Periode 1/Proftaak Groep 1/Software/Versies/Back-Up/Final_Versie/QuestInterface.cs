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
    public partial class QuestInterface : Form
    {
        MainFrame MAINFRAME;
        public QuestInterface(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;
        }

        // Navigate to PauzeMenu
        private void ButtonPause_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "PauzeMenu";
            Close();
        }

        // Navigate to statestieken
        private void ButtonStatistieken_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "statestieken";
            Close();
        }

        // Navigate to QuestLog
        private void ButtonQuestLog_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "QuestLog";
            Close();
        }

        // Mavigate to Inventaris
        private void ButtonInventaris_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "Inventaris";
            Close();
        }
    }
}
