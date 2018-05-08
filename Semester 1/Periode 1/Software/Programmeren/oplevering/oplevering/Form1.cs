using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oplevering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = GetLetter(textBox1.Text, Convert.ToInt32(textBox2.Text));
            AddToBox(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }

        string GetLetter(string Woord, int Index)
        {
            return Woord.Substring(Index - 1, 1);
        }

        void AddToBox(string Woord, int Index)
        {
            for (int x = 1; x <= Index; x++)
            {
                listBox1.Items.Add(Woord);
            }
        }
    }
}
