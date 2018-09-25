using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Fruitautomaat
{
    public class Row
    {
        // Position in the Rows Array
        private int Index;
        private FruitAutomaat CurrentForm;

        // Image size variables
        private Size IconSize;
        private Size IconShape;
        public Size RowShape;
        private Size ImageBorder = new Size(10, 10);
        private Size RowBorder = new Size(10, 10);
        private Point Location;

        // Create brushes
        private SolidBrush RowBackgroundBrush = new SolidBrush(Color.Blue);
        private SolidBrush ImageBackgroundBrush = new SolidBrush(Color.Brown);
        
        // Image objects
        private PictureBox Picturebox = new PictureBox();
        private Image SlotBackground;
        private Bitmap bitmap;

        // Create random
        private Random rnd = new Random();

        //Create Graphics element
        public Graphics graphics;

        // Create Array for random icons
        private Icon[] IconRow = new Icon[100];

        // Location Values
        private int EndNumber;
        private int CurrentLocation;
        private int CurrentNumber;
        private int TempCurrentNumber;

        public static int test = 0;

        // Speed value
        private int IconsPerSecond = 10;

        // Phase 2 miliseconds
        private decimal Phase2Start = 0;
        private decimal Phase2Stop;
        private decimal Phase2Difference = 5000;
        private bool Phase2 = true;

        public Row(int index, Size iconsize, FruitAutomaat currentForm)
        {
            // Save Paramaters
            Index = index;
            CurrentForm = currentForm;

            // Create Sizes and formats
            SlotBackground = Image.FromFile(System.IO.Directory.GetCurrentDirectory().Substring(0, System.IO.Directory.GetCurrentDirectory().IndexOf("bin")) + @"Resources\BackGround.png");
            Location = new Point((iconsize.Width + ImageBorder.Width * 2 + RowBorder.Width * 2) * index, 0);
            IconShape = new Size(iconsize.Width + ImageBorder.Width * 2 , iconsize.Height + ImageBorder.Height * 2);
            RowShape = new Size(IconShape.Width + RowBorder.Width * 2, IconShape.Height * 3 + RowBorder.Height * 2);
            IconSize = iconsize;
            Picturebox.Size = RowShape;
            Picturebox.Location = Location;

            // Save images
            bitmap = new Bitmap(SlotBackground, RowShape);
            Picturebox.Image = bitmap;

            // Construct Picture box
            CurrentForm.CreatePictureBox(Picturebox);

            // Determine end value
            EndNumber = rnd.Next(IconRow.Length /2 ,IconRow.Length -1);

            // Setup Icons
            
            do
            {
                GenerateRandomValues();
                test++;
            }
            while (CompareArrays());

            DrawRows(0);
        }

        // Fill an array with random icons based on their rarity
        private void GenerateRandomValues()
        {
            int count = 0;
            foreach (Icon element in IconRow)
            {
                    IconRow[count] = PickRandomIcon();
                    count++;
            }
        }

        private bool CompareArrays()
        {
            if (Index < 1)
            {
                return false;
            }
            int Count = 0;
            foreach (Icon icon in CurrentForm.Rows[Index - 1].IconRow)
            {
                if (icon.Picture != IconRow[Count].Picture)
                {
                    return false;
                }
                Count++;
            }
            return true;
        }

        // Pick a random Icon based on chance
        private Icon PickRandomIcon()
        {
            int TotalChance = 0;
            foreach (Icon element in CurrentForm.Icons)
            {
                TotalChance += element.Chance;
            }

            int RandomValue = rnd.Next(1, TotalChance + 1);
            int RandomCount = 0;
            foreach (Icon element in CurrentForm.Icons)
            {
                RandomCount += element.Chance;
                if (RandomCount >= RandomValue)
                {
                    return element;
                }
            }
            return new Icon("Error",10,100);
        }

        //Draw images for the picture box
        private void DrawImage(Image image, Point location)
        {
            //graphics.DrawImage(SlotBackground, new Point(0, 0));
            graphics.DrawImage(image, new Rectangle(location,IconSize));
        }

        //calculate the current location of the images
        public void DrawRows(decimal Miliseconds)
        {
            if (Phase2 == false && Phase2Start == 0)
            {
                CurrentLocation = Convert.ToInt32(IconShape.Height * Miliseconds / (1000 / IconsPerSecond));
            }
            else if (Phase2 == true && Phase2Start == 0)
            {
                Phase2Start = Miliseconds;
                Phase2Stop = Miliseconds + Phase2Difference;

                decimal a = (Miliseconds - Phase2Start) / Phase2Difference;
                decimal b = (Phase2Stop - a * a * Phase2Difference) * IconShape.Height;
                decimal c = b / (1000 / IconsPerSecond);

                CurrentLocation = Convert.ToInt32(c);
            }
            else
            {
                decimal a = (Miliseconds - Phase2Start) / Phase2Difference;
                decimal b = (Phase2Stop - a * Phase2Difference) * IconShape.Height;
                decimal c = b / (1000 / IconsPerSecond);

                CurrentLocation = Convert.ToInt32(c);
            }

            CurrentNumber = CurrentLocation/IconShape.Height;

            // Draw all object
            graphics = Graphics.FromImage(Picturebox.Image);

            graphics.FillRectangle(ImageBackgroundBrush, new Rectangle(new Point(RowBorder.Width,RowBorder.Height), RowShape - RowBorder - RowBorder));

            for (int i = 0; i <= 3; i++)
            {
                if (CurrentNumber > 99)
                {
                    TempCurrentNumber = CurrentNumber - 99;
                }
                else
                {
                    TempCurrentNumber = CurrentNumber;
                }

                DrawImage(IconRow[i + TempCurrentNumber].Picture,new Point(RowBorder.Width + ImageBorder.Width , CurrentLocation + RowBorder.Height + ImageBorder.Height + IconShape.Height * (-TempCurrentNumber - i + 2)));
            }

            graphics.FillRectangle(RowBackgroundBrush, new Rectangle(new Point(0, 0), new Size(RowBorder.Width, RowShape.Height))); // Left Bar
            graphics.FillRectangle(RowBackgroundBrush, new Rectangle(new Point(RowShape.Width - RowBorder.Width, 0), new Size(RowBorder.Width, RowShape.Height))); // Right Bar
            graphics.FillRectangle(RowBackgroundBrush, new Rectangle(new Point(0, 0), new Size(RowShape.Width, RowBorder.Height))); // Top Bar
            graphics.FillRectangle(RowBackgroundBrush, new Rectangle(new Point(0, RowShape.Height - RowBorder.Height), new Size(RowShape.Width, RowBorder.Height))); // Bottom Bar
        }
    }
}
