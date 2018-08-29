using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Applicatie
{
    class Bond
    {
        int TotaalAantalVerenigingen = 5;

        List<Vereniging> verenigingen = new List<Vereniging>();
        public Bond()
        {
            for (int i = 0; i < TotaalAantalVerenigingen; i++)
            {
                verenigingen.Add(new Vereniging());
            }
        }

        private int TelTotaalLeden()
        {
            int Totaal = 0;
            foreach (Vereniging Ver in verenigingen)
            {
                foreach (Boxer Lid in Ver.leden)
                {
                    Totaal++;
                }
            }
            return Totaal;
        }
    }
}
