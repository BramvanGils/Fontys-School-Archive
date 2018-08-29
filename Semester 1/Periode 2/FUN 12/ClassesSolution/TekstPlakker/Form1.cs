using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekstPlakker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        StringBuilder list = new StringBuilder();

        private void Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Numericupdown.Value; i++)
            {
                list.AppendLine(TextboxInput.Text);
            }
            TextboxInput.Clear();
            TextboxOutput.Text = list.ToString();
        }
    }
}
