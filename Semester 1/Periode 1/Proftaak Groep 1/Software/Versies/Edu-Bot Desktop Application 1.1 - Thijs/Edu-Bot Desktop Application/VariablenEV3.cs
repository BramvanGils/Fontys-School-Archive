using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu_Bot_Desktop_Application
{
   
    class LevelsEV3
    {
        //hier maaken we de variablen aan voor LevelsEV3
        public string levels;

        //hier zeggen we wat er onder de class LevelsEV3 valt
        public LevelsEV3(string levels)
        {
            this.levels = levels;
        }

        //hiermee kan je de levels opvragen
        public string getlevels()
        {
            return levels;
        }

        //hiermee kan je een nieuwe level waarde aan levels geven
        public void setlevels(string nieuwlevel)
        {
            levels = nieuwlevel;
        }
    }
    class HPManaEV3
    {
        //hier maaken we de variablen aan voor HPManaEV3
        public string Health;
        public string Mana;

        //hier zeggen we wat er onder de class HPManaEV3 valt
        public HPManaEV3(string Health, string Mana)
        {
            this.Health = Health;
            this.Mana = Mana;
        }

        //hiermee kan je de health opvragen
        public string getHealth()
        {
            return Health;
        }

        //hiermee kan je de Mana opvragen
        public string getMana()
        {
            return Mana;
        }

        //hiermee kan je een nieuwe Health waarde aan Health geven
        public void setHealth(string nieuwhealth)
        {
            Health = nieuwhealth;
        }

        //hiermee kan je een nieuwe Mana waarde aan Mana geven
        public void setMana(string nieuwMana)
        {
            Mana = nieuwMana;
        }
    }
}
