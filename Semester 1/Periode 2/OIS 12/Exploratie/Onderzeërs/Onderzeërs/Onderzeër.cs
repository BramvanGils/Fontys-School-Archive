using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onderzeërs
{
    class Onderzeër
    {
        private int maxdiepte;
        private int diepte;
        public enum Type {AIP, Atoom, Benzine}
        private string naam;

        Benzinemotor[] Benzinemotors = new Benzinemotor[2];
        Elektromotor[] Elektromotors = new Elektromotor[2];
        Koelkast koelkast;

        Personeel Kapitein;
        List<Personeel> Officiërs;
        List<Personeel> Enlisted;

        private Type type;

        public Onderzeër(string Naam, Type type, int Diepte, int Maxdiepte, Personeel Kapitein, List<Personeel> officiërs, List<Personeel> enlisted)
        {
            naam = Naam;
            this.type = type;
            diepte = Diepte;
            maxdiepte = Maxdiepte;

            for (int i = 0; i < Benzinemotors.Length; i++)
            {
                Benzinemotors[1] = new Benzinemotor(1000);
            }

            for (int i = 0; i < Elektromotors.Length; i++)
            {
                Elektromotors[1] = new Elektromotor(1000);
            }

            koelkast = new Koelkast(new List<string> {"Kaas","Ham","Pindakaas","Bouwtekeningen van de Walrus onderzeër"});
            Officiërs = officiërs;
            Enlisted = enlisted;
          

        }

        public void Stijgen(int Meters)
        {
            diepte -= Meters;
            if (diepte > 0)
            {
                diepte = 0;
            }
        }

        public void Duik(int Meters)
        {
            diepte += Meters;
            if (diepte > 300)
            {
                diepte = 300;
            }
        }
    }
}
