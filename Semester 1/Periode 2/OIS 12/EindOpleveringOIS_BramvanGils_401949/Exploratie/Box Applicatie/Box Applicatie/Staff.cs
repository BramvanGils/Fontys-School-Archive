using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Applicatie
{
    class Staff
    {
        public enum Occupatie {Diricteur, Instructeur }
        private int occupatie;
        private string Naam;

        public Staff(int occp)
        {
            occupatie = occp;
            Naam = Methods.GenerateName();
        }
    }
}
