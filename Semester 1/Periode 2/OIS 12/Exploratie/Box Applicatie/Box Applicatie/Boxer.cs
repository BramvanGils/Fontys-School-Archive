using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Applicatie
{
    class Boxer
    {
        Random rnd = new Random();

        private string Naam;
        private int gin;
        private int Hitpoints;
        private int Accuracy;
        private int Power;
        private int Classe;
        private enum Class { Vader, Mittel, Zwaak };

        public Boxer()
        {
            Naam = Methods.GenerateName();
            Hitpoints = rnd.Next(50, 101);
            Accuracy = rnd.Next(50, 101);
            Power = rnd.Next(50, 101);
        }

        private int Jab(Boxer Target)
        {
            if (rnd.Next(1, 101) < Accuracy)
            {
                return Power * rnd.Next(60, 121) / 100;
            }
                return 0;
        }

        private int Uppercut(Boxer Target)
        {
            if (rnd.Next(50, 101) < Accuracy)
            {
                return Power * rnd.Next(100, 181) / 100;
            }
                return 0;
        }

        private int Hoek(Boxer Target)
        {
            if (rnd.Next(30, 101) < Accuracy)
            {
                return Power * rnd.Next(50, 181) / 100;
            }
                return 0;
        }

        private bool Isko(Boxer Target)
        {
            if (Hitpoints < 0)
            {
                return true;
            }
            return false;
        }
    }
}
