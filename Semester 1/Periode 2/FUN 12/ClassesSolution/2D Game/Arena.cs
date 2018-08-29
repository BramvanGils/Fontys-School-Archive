using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace _2D_Game
{
    public partial class Arena: Form
    {
        public Graphics ArenaGraphics;

        public Image Island = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Images\png_floating_terrain_by_moonglowlilly-d5qb58m.png");
        public Image Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"\Images\untitled.png");

        Character player1;
        Character player2;

        Pen BorderPen = new Pen(Color.Black, 1);
        Pen ThickBorderPen = new Pen(Color.Black, 5);

        public Arena()
        {
            InitializeComponent();
            ArenaGraphics = CreateGraphics();
            player1 = new Character(new System.Drawing.Point(256, 256),this);
            player2 = new Character(new System.Drawing.Point(768, 256),this);
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            DrawGrid(ArenaGraphics);
            player1.UpdateAll();
            player2.UpdateAll();
        }

        public void Arena_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(ArenaGraphics);
            player1.UpdateAll();
            player2.UpdateAll();
        }

        public void DrawFrame()
        {

        }
        
        private void DrawGrid(Graphics graphics)
        {
            
            for (int Xaxis = 63; Xaxis <= this.Size.Width ; Xaxis += 64)
            {
                graphics.DrawLine(BorderPen, Xaxis, 0, Xaxis, this.Size.Height);
            }

            for (int Yaxis = 63; Yaxis <= this.Size.Height; Yaxis += 64)
            {
                graphics.DrawLine(BorderPen, 0, Yaxis, this.Size.Width, Yaxis);
            }

            graphics.DrawRectangle(ThickBorderPen, new Rectangle(2, 2, this.Size.Width - 3, this.Size.Height -3));

            //graphics.DrawImage(Island, 0, 100);
            //graphics.DrawImage(RotateImage(Island,10), new System.Drawing.Point(0, 0));
        }


        private void Arena_KeyDown(object sender, KeyEventArgs e)
        {
            player1.Acceleration.X = 0;
            player1.Acceleration.Y = 0;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    player1.Acceleration.Y--;
                    break;
                case Keys.Down:
                    player1.Acceleration.Y++;
                    break;
                case Keys.Left:
                    player1.Acceleration.X--;
                    break;
                case Keys.Right:
                    player1.Acceleration.X++;
                    break;
            }

            player2.Acceleration.X = 0;
            player2.Acceleration.Y = 0;
            switch (e.KeyCode)
            {
                case Keys.W:
                    player2.Acceleration.Y--;
                    break;
                case Keys.S:
                    player2.Acceleration.Y++;
                    break;
                case Keys.A:
                    player2.Acceleration.X--;
                    break;
                case Keys.D:
                    player2.Acceleration.X++;
                    break;
            }
        }

        public void DrawCharacter(Pen BodyLinePen,Rectangle BodySize)
        {
            ArenaGraphics.DrawEllipse(BodyLinePen, BodySize);
        }

        public Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            
            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            
            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new System.Drawing.Point(0, 0));
            
            //dispose of our Graphics object
            gfx.Dispose();
            
            //return the image
            return bmp;
        }
    }
}
