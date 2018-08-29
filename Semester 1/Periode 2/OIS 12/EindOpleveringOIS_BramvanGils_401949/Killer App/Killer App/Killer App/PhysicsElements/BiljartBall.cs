using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Killer_App.PhysicsElements
{
    class BiljartBall
    {
        // a percetage of how far the ball must still travel during a frame 1-0
        public double TravelProgress { get; set; }

        private int Radius { get; set; }
        private readonly int nummer;
        public DPoint location { get; set; }
        public DSpeed speed { get; }
        private readonly Image image;

        public Size Size
        {
            get { return new Size(Radius * 2, Radius * 2); }
        }

        public Point RenderLocation
        {
            get { return new Point(location.IntPoint.X - Size.Width / 2 , location.IntPoint.Y - Size.Height / 2); }
        }

        public DLine TravelPath
        {
            get { return new DLine(location, speed, TravelProgress); }
        }

        public BiljartBall(DPoint Location, DSpeed Speed, int Nummer)
        {
            Radius = 10;
            location = Location;
            speed = Speed;
            nummer = Nummer;
            image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"Resources\BiljartBallen\BiljartBall"+ nummer +".png");
        }

        public void Render(Graphics gfx)
        {
            gfx.DrawImage(image, RenderLocation.X, RenderLocation.Y * -1, Size.Width, Size.Height);
        }
    }
}
