using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Killer_App.PhysicsElements
{
    class DSpeed
    {
        public double angle { get; }
        public double speed { get; }

        public double X
        {
            get
            {
                return Math.Sin(angle * Math.PI / 180) * speed;
            }
        }

        public double Y
        {
            get
            {
                return Math.Cos(angle * Math.PI / 180) * speed;
            }
        }

        /// <summary>
        /// Creates a speed based on angle and pixels per second
        /// </summary>
        /// <param name="Angle"> Angle lies between 0 and 360, starts at one o' clock and progresses clockwise</param>
        /// <param name="Speed"> Speed is measured in pixels per Frame </param>
        public DSpeed(double Angle, double Speed)
        {
            speed = Speed;
            angle = Angle;
        }
    }
}
