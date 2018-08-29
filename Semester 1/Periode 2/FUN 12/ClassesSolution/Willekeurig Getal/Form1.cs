using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Willekeurig_Getal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            try
            {
                int uitkomst = RandomGetal(Convert.ToInt32(TextboxMin.Text), Convert.ToInt32(TextboxMax.Text));
                if (CheckEven(uitkomst))
                {
                    MessageBox TextWindow = new MessageBox(Convert.ToString(TextboxGebruiker.Text));
                    TextWindow.Show();
                }
                else
                {
                    MessageBox TextWindow = new MessageBox(Convert.ToString(uitkomst) + "\n" + CheckEven(uitkomst));
                    TextWindow.Show();
                }
            }
            catch (Exception error)
            {
                MessageBox TextWindow = new MessageBox("Error:" + error);
                TextWindow.Show();
            }
        }

        private int RandomGetal(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        private bool CheckEven(int uitkomst)
        {
            if (uitkomst % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
