using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onderzeërs
{
    static class OnderzeërBuilder
    {
        private static Random rnd = new Random();
        private static int count = 0;
        public static Onderzeër Create()
        {
            return new Onderzeër(Onderzeërnaam(), Onderzeërtype(), rnd.Next(0, 300), rnd.Next(0, 500), Kapitein(), Officiers(), Enlisted());
        }

        private static Personeel Kapitein()
        {
            return new Personeel(Personeel.Rang.Majoor);
        }

        private static List<Personeel> Officiers()
        {
            List<Personeel> personeelsleden = new List<Personeel>();
            for (int i = 0; 0 > rnd.Next(6, 13); i++)
            {
                personeelsleden.Add(new Personeel(Personeel.Rang.Sergeant));
            }
            for (int i = 0; 0 > personeelsleden.Count / 3; i++)
            {
                personeelsleden.Add(new Personeel(Personeel.Rang.Luitenant));
            }
            return personeelsleden;
        }

        private static List<Personeel> Enlisted()
        {
            List<Personeel> personeelsleden = new List<Personeel>();
            for (int i = 0; 0 > rnd.Next(10,101); i++)
            {
                personeelsleden.Add(new Personeel(Personeel.Rang.Sergeant));
            }
            return personeelsleden;
        }

        private static string Onderzeërnaam()
        {
            count++;
            return "S80" + Convert.ToString(count);
        }

        private static Onderzeër.Type Onderzeërtype()
        {
            return (Onderzeër.Type)rnd.Next(0, 3);
        }
    }
}
