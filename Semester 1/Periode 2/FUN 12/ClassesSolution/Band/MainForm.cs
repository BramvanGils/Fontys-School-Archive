using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Band
{
    public partial class MainForm : Form
    {
        Band[] Festival = new Band[4];

        public MainForm()
        {
            InitializeComponent();

            Festival[0] = new Band("Nothing but Thieves", "Rock-Pop", 6000, 4);
            Festival[1] = new Band("ImagineDragons", "Indie-Rock", 9000, 4);
            Festival[2] = new Band("Gorrilaz", "Rap", 8000, 2);
            Festival[3] = new Band("Panic at the Disco", "Emo-Pop", 7500, 1);

            FestivalOptreden(Festival, 2, new int[] { 3, 2, 1, 2 });
            SchrijfSesie();
            FestivalOptreden(Festival, 2, new int[] { 3, 2, 1, 2 });
        }

        private void FestivalOptreden(Band[] Bands, int duur, int[] Schema)
        {
            double HoogsteKosten = 0;
            Band DuursteBand = Bands[0];
            for (int band = 0; band < Bands.Length; band++)
            {
                if (Bands[band].Optreden(Schema[band]) > HoogsteKosten)
                {
                    HoogsteKosten = Bands[band].Optreden(Schema[band]);
                    DuursteBand = Bands[band];
                }
            }
            MessageBox.Show("Het duurste optreden koste €" + Convert.ToString(HoogsteKosten) + " en werd gespeeld door " + DuursteBand.naam);
        }

        private void SchrijfSesie()
        {
            Festival[0].MuziekSchrijven("Sorry");
            Festival[1].MuziekSchrijven("Thunder");
            Festival[2].MuziekSchrijven("Saturn Bazz");
            Festival[3].MuziekSchrijven("Death of a Bachelor");
        }
    }
}
