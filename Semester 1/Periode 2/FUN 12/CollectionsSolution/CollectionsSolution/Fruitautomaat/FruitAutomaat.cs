using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruitautomaat
{
    public partial class FruitAutomaat : Form
    {
        // Create object arrays
        public Icon[] Icons = new Icon[10];
        public Row[] Rows = new Row[3];

        // Create a Button object
        private Button dynamicButton = new Button();

        private Size Iconsize = new Size(180,180);

        private int Miliseconds = 0;

        private Size FormSize;

        public FruitAutomaat()
        {
            // Set all icons
            Icons[0] = new Icon("Cherry", 10 ,50);
            Icons[1] = new Icon("Banana", 10 ,50);
            Icons[2] = new Icon("Orange", 10, 50);
            Icons[3] = new Icon("Grape", 10, 50);
            Icons[4] = new Icon("Lemon", 20, 25);
            Icons[5] = new Icon("Melon", 20, 25);
            Icons[6] = new Icon("Bar", 50, 15);
            Icons[7] = new Icon("Seven", 100, 10);
            Icons[8] = new Icon("Big win", 200, 5);
            Icons[9] = new Icon("Guido", 1000, 100);

            // Set all Rows
            for (int i = 0; i < Rows.Length; i++)
            {
                Rows[i] = new Row(i, Iconsize, this);
            }

            FormSize = new Size(Rows[0].RowShape.Width * Rows.Length, Rows[0].RowShape.Height);
            this.Size = FormSize;
            this.MinimumSize = FormSize;
            this.MaximumSize = FormSize;

            InitializeComponent(); 
        }
        
        public void CreatePictureBox(PictureBox picturebox)
        {
            Controls.Add(picturebox);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            foreach (Row element in Rows)
            {
                element.DrawRows(Miliseconds);
            }
            Miliseconds += timer.Interval;
            this.Invalidate();
            this.Refresh();
        }
    }
}
