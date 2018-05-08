using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Bot_Desktop_Application
{
    public partial class Mainmenu : Form
    {
        
        public Mainmenu(MainFrame maintje)
        {
            InitializeComponent();
            MainFrame naam = maintje;
        }

        private void buttonSluitenMainmenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRobotinstellingenMainmenu_Click(object sender, EventArgs e)
        {
            //SwitchForm(RobotInstellingen);
        }

        private void buttonSpelenMainmenu_Click(object sender, EventArgs e)
        {

        }
    }
}
