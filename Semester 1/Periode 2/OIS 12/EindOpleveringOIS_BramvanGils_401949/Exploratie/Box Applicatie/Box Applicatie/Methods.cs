using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Applicatie
{
    class Methods
    {
        static Random rnd = new Random();
        static string Klinkers = "aeiouy";
        static string Medeklinkers = "bcdfghjklmnpqrstvwxz";

        public static string GenerateName()
        {
            string FirstName = Medeklinkers.Substring(rnd.Next(0, 20), 1).ToUpper();
            for (int i = 0; i < rnd.Next(5, 15); i++)
            {
                if (i % 2 == 1)
                {
                    FirstName += Klinkers.Substring(rnd.Next(0, 6), 1);
                }
                else
                {
                    FirstName += Medeklinkers.Substring(rnd.Next(0, 20), 1);
                }
            }

            string LastName = Medeklinkers.Substring(rnd.Next(0, 20), 1).ToUpper();
            for (int i = 0; i < rnd.Next(5, 15); i++)
            {
                if (i % 2 == 1)
                {
                    LastName += Klinkers.Substring(rnd.Next(0, 6), 1);
                }
                else
                {
                    FirstName += Medeklinkers.Substring(rnd.Next(0, 20), 1);
                }
            }

            string MiddleName = Medeklinkers.Substring(rnd.Next(0, 20), 1);
            MiddleName += Klinkers.Substring(rnd.Next(0, 6), 1);
            MiddleName += Medeklinkers.Substring(rnd.Next(0, 20), 1);

            return FirstName + " " + MiddleName + " " + LastName;
        }

        public static string GenerateVerenigingName()
        {
            string VerenigingName = Medeklinkers.Substring(rnd.Next(0, 20), 1).ToUpper();
            for (int i = 0; i < rnd.Next(5, 15); i++)
            {
                if (i % 2 == 1)
                {
                    VerenigingName += Klinkers.Substring(rnd.Next(0, 6), 1);
                }
                else
                {
                    VerenigingName += Medeklinkers.Substring(rnd.Next(0, 20), 1);
                }
            }

            switch (rnd.Next(0, 5))
            {
                case 0:
                    return VerenigingName + " Boys";
                case 1:
                    return VerenigingName + " Champs";
                case 2:
                    return "The Golden " + VerenigingName;
                case 3:
                    return VerenigingName + " of Hell";
                case 4:
                    return VerenigingName + " Vereniging";
                default:
                    return VerenigingName + " en Sam";
            }
        }
    }
}
