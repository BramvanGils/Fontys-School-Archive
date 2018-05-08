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
    public partial class Instellingen : Form
    {
        MainFrame MAINFRAME;
        public Instellingen(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;
        }

        // Navigate to Previous Page
        private void buttonInstellingenTerug_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = MAINFRAME.LastForm;
            Close();
        }
    }
}
