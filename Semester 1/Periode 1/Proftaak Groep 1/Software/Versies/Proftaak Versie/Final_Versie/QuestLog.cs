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
    public partial class QuestLog : Form
    {
        MainFrame MAINFRAME;
        public QuestLog(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;
        }

        // Navigate to Inventaris
        private void buttonInventarisVorigepagina_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "Inventaris";
            Close();
        }

        // Navigate to statestieken
        private void buttonInventarisvolgendepagina_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "statestieken";
            Close();
        }

        // Navigate to QuestInterface
        private void buttonStatestiekenTerug_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "QuestInterface";
            Close();
        }
    }
}
