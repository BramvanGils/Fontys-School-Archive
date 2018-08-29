using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Band
{
    class Band
    {
        public string naam;
        public string genre;
        public double uurtarief;
        public int aantalBandleden;

        public Band(string Naam, string Genre, double Uurtarief, int AantalBandleden)
        {
            naam = Naam;
            genre = Genre;
            uurtarief = Uurtarief;
            aantalBandleden = AantalBandleden;
        }

        public double Optreden(int duur)
        {
            return uurtarief * duur;
        }

        public void MuziekSchrijven(string titel)
        {
            if (titel.Length > 6)
            {
                uurtarief += 9.90;
            }
        }
    }
}
