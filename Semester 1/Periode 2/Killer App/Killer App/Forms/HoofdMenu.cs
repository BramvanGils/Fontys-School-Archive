using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killer_App
{
    public partial class HoofdMenu : Form
    {
        public HoofdMenu()
        {
            InitializeComponent();
        }

        private void AfsluitenButton_Click(object sender, EventArgs e)
        {
            ScreenManager.NextScreen = ScreenManager.Screen.InlogScherm;
            ScreenManager.CurrentUser = 0;
            Close();
        }

        private void ProfielButton_Click(object sender, EventArgs e)
        {
            ScreenManager.NextScreen = ScreenManager.Screen.MijnProfiel;
            Close();
        }
    }
}
