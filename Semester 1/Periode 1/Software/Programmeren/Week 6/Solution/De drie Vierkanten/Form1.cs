using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_drie_Vierkanten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBereken_Click(object sender, EventArgs e)
        {
            double LengteVierkant1 = Convert.ToDouble(TextboxVierkant1.Text);
            double LengteVierkant2 = Convert.ToDouble(TextboxVierkant2.Text);
            double LengteVierkant3 = Convert.ToDouble(TextboxVierkant3.Text);

            double TotaleOppervlakte = BerekenOppervlakte(LengteVierkant1) + BerekenOppervlakte(LengteVierkant2) + BerekenOppervlakte(LengteVierkant3);

            LabelAntwoord.Text = "De totale oppervlakte is " + Convert.ToString(TotaleOppervlakte);
        }

        double BerekenOppervlakte(double lengte)
        {
            return lengte * lengte;
        }
    }
}
