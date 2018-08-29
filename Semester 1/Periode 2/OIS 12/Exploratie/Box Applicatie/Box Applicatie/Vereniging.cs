using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_Applicatie
{
    class Vereniging
    {

        private Ring[] Ringen = new Ring[4];

        public List<Boxer> leden = new List<Boxer>();
        public List<Staff> staffs = new List<Staff>();

        public int AantalLeden
        {
            get
            {
                return leden.Count + staffs.Count;
            }
        }

        public Vereniging(string NaamDiricteur, string NaamInstructeur)
        {
            for (int i = 0; i < 3; i++)
            {
                Ringen[i] = new Ring();
            }
            staffs.Add(new Staff(0));
            VoegInstructeurToe(NaamInstructeur);
        }

        private void VoegInstructeurToe(string naam)
        {
            staffs.Add(new Staff(1));
        }
    }
}
