using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Killer_App.PhysicsElements
{
    class DPoint
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point IntPoint
        {
            get { return new Point(Convert.ToInt32(x), Convert.ToInt32(y)); }
        }

        public DPoint(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public DPoint FuturePostition(DSpeed s)
        {
            return new DPoint(x + s.X, y + s.Y);
        }
    }
}
