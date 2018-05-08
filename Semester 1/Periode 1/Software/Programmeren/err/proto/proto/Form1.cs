using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            LabelAntwoord.Text = PakLetter(TextboxString.Text,Convert.ToInt32(TextboxInt.Text));

        }

        string PakLetter(string Woord, int Index)
        {
            string letter = Woord.Substring(--Index, 1);

            return letter;
        }
    }
}
