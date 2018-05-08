using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framework
{
    public partial class MainFrame : Form
    {




        public MainFrame()
        {
            InitializeComponent();
        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            //MainFrame FirstForm = new MainFrame();
            /*A SecondForm = new A();

            SecondForm.Show(this);
            this.Hide();*/

            Label.Text = Convert.ToString(XpToLevel(28000));
        }

        public int XpToLevel(int SendXP)
        {
            int Outcome = 1;
            for (int Level = 0; SendXP > LevelToXp(Level); Level++)
            {
                Outcome = Level;
            }
            return Outcome;
        }

        public int LevelToXp(int SendLevel)
        {
            int XP = 0;
            for (int Level = 1; Level < SendLevel; Level++)
            {
                XP += 1000 + (Level-1) * (Level-1) * 100;
            }
            return XP;
        }
    }
}
