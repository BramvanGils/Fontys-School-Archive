using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haxor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            if (!CheckBox.Checked)
            {
                Label.Text = TextBox.Text.Replace("a", "4").Replace("s", "5").Replace("e", "3").Replace("v", "\\/").Replace("m", "|v|").Replace("V", "\\/").Replace("M", "|v|");
            }
            else
            {
                Label.Text = TextBox.Text.Replace("4", "a").Replace("5", "s").Replace("3", "e").Replace("\\/", "v").Replace("|v|", "m");
            }
        }

        private void Reverse_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
