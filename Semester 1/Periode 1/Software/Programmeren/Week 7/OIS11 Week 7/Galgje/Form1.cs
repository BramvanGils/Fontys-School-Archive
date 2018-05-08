using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            UpdateImage(1);
        }

        void UpdateImage(int Mistakes)
        {
            switch (Mistakes)
            {
                case 1:
                    PictureBox.Image = new Bitmap(@""\\My Images\\2.gif"");
                    break;
                case 2:
                    PictureBox.Image = new Bitmap(@"C:\Users\Bramv\Google Drive\Semester 1 Periode 1\Software\Programmeren\Week 7\OIS11 Week 7\Galgje\galgje afbeeldingen\2");
                    break;
                case 3:
                    PictureBox.Image = new Bitmap(@"C:\Users\Bramv\Google Drive\Semester 1 Periode 1\Software\Programmeren\Week 7\OIS11 Week 7\Galgje\galgje afbeeldingen\3");
                    break;
                case 4:
                    PictureBox.Image = new Bitmap(@"C:\Users\Bramv\Google Drive\Semester 1 Periode 1\Software\Programmeren\Week 7\OIS11 Week 7\Galgje\galgje afbeeldingen\4");
                    break;
                case 5:
                    PictureBox.Image = new Bitmap(@"C:\Users\Bramv\Google Drive\Semester 1 Periode 1\Software\Programmeren\Week 7\OIS11 Week 7\Galgje\galgje afbeeldingen\5");
                    break;
                case 6:
                    PictureBox.Image = new Bitmap(@"C:\Users\Bramv\Google Drive\Semester 1 Periode 1\Software\Programmeren\Week 7\OIS11 Week 7\Galgje\galgje afbeeldingen\6");
                    break;
                case 7:
                    PictureBox.Image = new Bitmap(@"C:\Users\Bramv\Google Drive\Semester 1 Periode 1\Software\Programmeren\Week 7\OIS11 Week 7\Galgje\galgje afbeeldingen\7");
                    break;
                case 8:
                    PictureBox.Image = new Bitmap(@"C:\Users\Bramv\Google Drive\Semester 1 Periode 1\Software\Programmeren\Week 7\OIS11 Week 7\Galgje\galgje afbeeldingen\8");
                    break;
            }

        }
    }
}
