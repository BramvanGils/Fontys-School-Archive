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
        }

        private void buttonSluitenMainmenu_Click(object sender, EventArgs e)
        {
            MAINFRAME.XpToLevel(3);
            Close();

        }
    }
}
