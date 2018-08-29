using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Strandbal
{
    class Strandbal
    {
        public double diameter = 0.5;
        Color kleur = new Color();

        public Strandbal()
        {

        }

        public bool VerderOpblazen(double extra)
        {
            diameter += extra;
            if (diameter > 1.50)
            {
                diameter = 1.50;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
