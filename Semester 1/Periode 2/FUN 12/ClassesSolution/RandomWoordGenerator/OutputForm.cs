using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWoordGenerator
{
    public partial class OutputForm : Form
    {
        private string Output = "";
        private string Letters = "aeiouybcdfghjklmnpqrstvwxz";

        private Random rnd = new Random();

        private bool Klinker;

        public OutputForm(int AantalLetters)
        {
            InitializeComponent();

            Output = EersteLetter();

            for (int i = 2; i <= AantalLetters; i++)
            {
                if (Klinker)
                {
                    Output += RandomMedeklinker();
                }
                else
                {
                    Output += RandomKlinker();
                }
            }

            LabelOutput.Text = Output;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string RandomKlinker()
        {
            Klinker = true;
            return Letters.Substring(rnd.Next(6),1);
            
        }

        private string RandomMedeklinker()
        {
            Klinker = false;
            return Letters.Substring(rnd.Next(6,26), 1);
        }

        private string EersteLetter()
        {
            if (rnd.Next(2) == 1)
            {
                Klinker = true;
                return Letters.Substring(rnd.Next(6),1).ToUpper();
            }
            else
            {
                Klinker = false;
                return Letters.Substring(rnd.Next(6,26),1).ToUpper();
            }
        }
    }
}
