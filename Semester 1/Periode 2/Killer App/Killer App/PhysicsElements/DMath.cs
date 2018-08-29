using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Killer_App.PhysicsElements;

namespace Killer_App.PhysicsElements
{
    /// <summary>
    /// Provides constants and static methods for trigonometric and common mathematical functions for DoublePhysicsElements.
    /// </summary>
    static class DMath
    {
        /// <summary>
        /// Calculate the difference between X coördinates between two DPoints
        /// </summary>
        /// <param name="PointA">The First DPoint to Compare Coordinates with</param>
        /// <param name="PointB">The Second DPoint to Compare Coordinates with</param>
        /// <returns> The difference between X coördinates</returns>
        static double Xoffset(DPoint PointA, DPoint PointB)
        {
            return PointB.x - PointA.x;
        }

        /// <summary>
        /// Calculate the difference between Y coördinates between two DPoints
        /// </summary>
        /// <param name="PointA">The First DPoint to Compare Coordinates with</param>
        /// <param name="PointB">The Second DPoint to Compare Coordinates with</param>
        /// <returns> The difference between Y coördinates</returns>
        static double Yoffset(DPoint PointA, DPoint PointB)
        {
            return PointB.y - PointA.y;
        }

        /// <summary>
        /// Returns the gradient of a DLine
        /// </summary>
        /// <param name="Line">The DLine to calculate the gradient from</param>
        /// <returns> The gradient of a DLine</returns>
        static double Gradient(DLine Line)
        {
            return Yoffset(Line.pointA, Line.pointB) / Xoffset(Line.pointA, Line.pointB);
        }

        /// <summary>
        /// Returns the relative gradient of two DLines from the perspective of LineA
        /// </summary>
        /// <param name="LineA"> The line with the base gradient </param>
        /// <param name="LineB"> The line whose gradient needs to be compared with</param>
        /// <returns> The relative gradient of two DLines from the perspective of LineA</returns>
        static double RelativeGradient(DLine LineA, DLine LineB)
        {
            return Gradient(LineA) - Gradient(LineB);
        }

        /// <summary>
        /// Picks an X coördinate on a straight line based on the Y coördinate
        /// </summary>
        /// <param name="Line"> A straight line to calculate the Ycoördiante from</param>
        /// <param name="XCoördinate"> the Xcoördinate to pick a point on the line with </param>
        /// <returns> The Ycoördinate </returns>
        public static double Ycoördinate(DLine Line, double XCoördinate)
        {
            return (XCoördinate - Line.pointA.x) * Gradient(Line) + Line.pointA.y;
        }

        /// <summary>
        /// Calculates the intersection point wether or not the point is actually on the line or not
        /// </summary>
        /// <param name="LineA"> the first line</param>
        /// <param name="LineB"> the second line</param>
        /// <returns> the intersection point</returns>
        public static DPoint IntersectionPoint(DLine LineA, DLine LineB)
        {
            if(LineA.MinAngle == LineB.MinAngle)
            {
                return null;
            }

            double XCoördinate;
            if (LineA.MinAngle == 0)
            {
                XCoördinate = LineA.pointA.x;
            }
            else if (LineB.MinAngle == 0)
            {
                XCoördinate = LineB.pointA.x;
            }
            else
            {
                double YoffsetPointA = Yoffset(LineA.pointA, new DPoint(LineA.pointA.x, Ycoördinate(LineB, LineA.pointA.x)));

                XCoördinate = LineA.pointA.x + YoffsetPointA / RelativeGradient(LineA, LineB);
            }

            double YCoördinate;

            if (LineA.MinAngle == 0)
            {
                YCoördinate = Ycoördinate(LineB, XCoördinate);
            }
            else
            {
                YCoördinate = Ycoördinate(LineB, XCoördinate);
            }
            
            return new DPoint(XCoördinate, YCoördinate);
        }


        public static DPoint DynamicCollisionPoint(BiljartBall BallA, BiljartBall BallB)
        {
            DLine PathA = BallA.TravelPath;
            DLine PathB = BallB.TravelPath;
            DLine StartSeperation = new DLine(PathA.pointA,PathB.pointA);
            DLine EndSeperation = new DLine(PathA.pointB, PathB.pointB);
            return null;
        }
    }
}
