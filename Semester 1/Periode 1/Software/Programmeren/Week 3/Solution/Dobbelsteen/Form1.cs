using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelsteen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Picture2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Picture1.Visible = false;
            Picture2.Visible = false;
            Picture3.Visible = false;
            Picture4.Visible = false;
            Picture5.Visible = false;
            Picture6.Visible = false;

            Random random = new Random();
            switch (random.Next(1, 7))
            {
                case 1:
                    Picture1.Visible = true;
                    break;
                case 2:
                    Picture2.Visible = true;
                    break;
                case 3:
                    Picture3.Visible = true;
                    break;
                case 4:
                    Picture4.Visible = true;
                    break;
                case 5:
                    Picture5.Visible = true;
                    break;
                case 6:
                    Picture6.Visible = true;
                    break;
            }
        }
    }
}
