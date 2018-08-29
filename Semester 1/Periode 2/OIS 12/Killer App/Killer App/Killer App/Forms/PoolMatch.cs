using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Killer_App.PhysicsElements;

namespace Killer_App.Forms
{
    public partial class PoolMatch : Form
    {

        Graphics graphics;

        BiljartBall[] Balls = new BiljartBall[2];
        DLine[] Borders = new DLine[4];

        DLine line1 = new DLine(new DPoint(0, 0), new DPoint(-10, -10));
        DSpeed speed1 = new DSpeed(10, 10);
        

        public PoolMatch()
        {
            DLine LineA = new DLine(new DPoint(20,20), new DPoint(30, 20));
            DLine LineB = new DLine(new DPoint(0, 0), new DPoint(40,40));
            DMath.IntersectionPoint(LineA, LineB);
            double test = DMath.Ycoördinate(LineB, 20);

            Balls[0] = new BiljartBall(new DPoint(100, - 300), new DSpeed(90, 11), 1);
            Balls[1] = new BiljartBall(new DPoint(600, - 300), new DSpeed(270, 11), 2);
            InitializeComponent();
            graphics = CreateGraphics();

            ResetBalls();
            UpdatDebugLabels();
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
            CalculateBallsLocations();
            RenderBalls();
        }

        private void RenderBalls()
        {
            for (int i = 0; i < Balls.Length; i++)
            {
                Balls[i].Render(graphics);
            }
        }

        private void CalculateBallsLocations()
        {
            for (int i = 0; i < Balls.Length; i++)
            {
                DLine TravelPath = Balls[i].TravelPath;
                Balls[i].location = TravelPath.pointB;
                
            }
            DMath.DynamicCollisionPoint(Balls[0], Balls[1]);
            ResetBalls();
        }

        private void ResetBalls()
        {
            for (int ball = 0; ball < Balls.Length; ball++)
            {
                Balls[ball].TravelProgress = 1;
            }
        }

        private void CreateBorders()
        {
            Borders[0] = new DLine(new DPoint(0, 0), new DPoint(0, Height));
            Borders[1] = new DLine(new DPoint(0, 0), new DPoint(Width, 0));
            Borders[2] = new DLine(new DPoint(0, Height), new DPoint(Width, Height));
            Borders[3] = new DLine(new DPoint(Width, 0), new DPoint(Width, Height));
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrameTimer_Tick(new Timer(), new EventArgs());
            UpdatDebugLabels();
        }

        private void UpdatDebugLabels()
        {
            DebugLabel1.Text = "Location: " + Convert.ToString(Balls[0].location.x) + "," + Convert.ToString(Balls[0].location.y);
            DebugLabel2.Text = "Speed: " + Convert.ToString(Balls[0].speed.X) + "," + Convert.ToString(Balls[0].speed.Y);
        }
    }
}
