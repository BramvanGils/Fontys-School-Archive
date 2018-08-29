using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2D_Game
{
    class Character
    {
        public System.Drawing.Point Location;
        public Vector Speed = new Vector(0, 0);
        public Vector Acceleration = new Vector(0, 0);

        public System.Drawing.Size BodySize = new System.Drawing.Size(128,128);
        public Rectangle BodyBox;

        public int Levens = 3;
        public int level = 10;
        public int XP = 560;

        Weapon weapon1 = new Weapon();
        Weapon weapon2 = new Weapon();
        Weapon weapon3 = new Weapon();

        Arena Arena;

        public Pen BodyLinePen = new Pen(Color.Black, 3);

        public Character(System.Drawing.Point location,Arena arena)
        {
            Arena = arena;
            Location = location;

            BodyBox = new Rectangle(Location, BodySize);
        }

        public void CheckXP()
        {
            if (XP >= 1000)
            {
                level++;
                XP = -1000;
            }
        }

        public void UpdateAll()
        {
            UpdateSpeed();
            UpdateLocation();
            Arena.DrawCharacter(BodyLinePen, BodyBox);
        }
        public void UpdateSpeed()
        {
            Speed += Acceleration;
            if (Speed.X > 5) { Speed.X = 5; }
            if (Speed.Y > 5) { Speed.Y = 5; }
            if (Speed.X < -5) { Speed.X = -5; }
            if (Speed.Y < -5) { Speed.Y = -5; }
        }

        public void UpdateLocation()
        {
            Location.X += Convert.ToInt32(Speed.X);
            Location.Y += Convert.ToInt32(Speed.Y);

            if (Location.X > 1024 - BodySize.Width) { Location.X = 1024 - BodySize.Width; }
            if (Location.Y > 512 - BodySize.Height) { Location.Y = 512 - BodySize.Height; }
            if (Location.X < 0) { Location.X = 0; }
            if (Location.Y < 0) { Location.Y = 0; }

            BodyBox = new Rectangle(Location, BodySize);
        }
    }
}
