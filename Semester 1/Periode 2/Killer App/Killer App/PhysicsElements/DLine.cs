using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Killer_App.PhysicsElements
{
    class DLine
    {
        public DPoint pointA { set; get; }
        public DPoint pointB { set; get; }

        /// <summary>
        /// Gives the Length of all the lines 
        /// </summary>
        public double LineLength
        {
            get
            {
                double XLength = Math.Max(pointA.x, pointB.x) - Math.Min(pointA.x, pointB.x);
                double YLength = Math.Max(pointA.y, pointB.y) - Math.Min(pointA.y, pointB.y);
                return Math.Sqrt(Math.Pow(XLength, 2) + Math.Pow(YLength, 2));
            }
        }

        /// <summary>
        /// Gives the smalest of the two angles that can be found 
        /// </summary>
        public double MinAngle
        {
            get
            {
                double XLength = pointA.x - pointB.x;
                double YLength = pointA.y - pointB.y;
                double Degrees = Math.Atan(XLength / YLength) * 180 / Math.PI;
                if (Degrees < 0)
                {
                    return Degrees + 180;
                }
                else
                {
                    return Degrees;
                }
            }
        }

        /// <summary>
        /// Gives the largest of the two angles that can be found 
        /// </summary>
        public double MaxAngle
        {
            get
            {
                return MinAngle + 180;
            }
        }

        /// <summary>
        /// Gives the change in the X coordinate between point A and B
        /// </summary>
        private double Xoffset
        {
            get { return pointB.x - pointA.x; }
        }

        /// <summary>
        /// Gives the change in the Y coordinate between point A and B
        /// </summary>
        private double Yoffset
        {
            get { return pointB.y - pointA.y; }
        }

        

        /// <summary>
        /// Calculates a line from two Dpoints
        /// </summary>
        /// <param name="PointA">The begin point of the line </param>
        /// <param name="PointB">The end point of the line </param>
        public DLine(DPoint PointA, DPoint PointB)
        {
            pointA = PointA;
            pointB = PointB;
        }

        /// <summary>
        /// Calculates a line from a Dpoint and a Dspeed, can also be used to calculate a possible path.
        /// </summary>
        /// <param name="PointA">The begin point of the line </param>
        /// <param name="DSpeed">The distance traveled from point A </param>
        /// <param name="TravelProgress"> how far the object still needs to travel</param>
        public DLine(DPoint PointA, DSpeed DSpeed, double TravelProgress)
        {
            pointA = PointA;
            pointB = new DPoint(PointA.x + DSpeed.X * TravelProgress, PointA.y + DSpeed.Y * TravelProgress);
        }

        /// <summary>
        /// Checks how far the point is on this line
        /// </summary>
        /// <param name="Point"> The point on the line, WARNING must be on the Line</param>
        /// <returns> Returns a double between 0 and 1 indicating how far this point is on the line from point a to point b</returns>
        public double PointToProgress(DPoint Point)
        {
            return Point.x - pointA.x / Xoffset;
        }

        public DPoint ProgressToPoint(double Progress)
        {
            return new DPoint(pointA.x + (Xoffset) * Progress, pointA.y + (Yoffset) * Progress);
        }
    }
}
