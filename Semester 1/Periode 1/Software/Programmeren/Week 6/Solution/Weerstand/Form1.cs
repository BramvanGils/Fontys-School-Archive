using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weerstand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBerekenWeerstand_Click(object sender, EventArgs e)
        {
            decimal Getal1 = Convert.ToDecimal(TextboxAmpère.Text);
            decimal Getal2 = Convert.ToDecimal(TextboxVolt.Text);
            decimal Antwoord = BerekenWeerstand(Getal1,Getal2);

            LabelWeerstand.Text = "De weerstand is " + Convert.ToString(Antwoord) + " ohm";

        }

        decimal BerekenWeerstand(decimal Volt, decimal Ampère)
        {
            decimal Weerstand = Volt / Ampère;
            return Weerstand;
        }
    }
}
