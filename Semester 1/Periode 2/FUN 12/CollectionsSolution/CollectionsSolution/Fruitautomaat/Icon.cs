using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Fruitautomaat
{
    public class Icon
    {
        private string Name;
        public Image Picture;
        public int Points;
        public int Chance;

        public Icon(string name, int points, int chance)
        {
            Name = name;
            Points = points;
            Chance = chance;
            Picture = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"Resources\" + Name + ".png");
        }
    }
}
