using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strandbal
{
    public partial class MainForm : Form
    {
        Strandbal Bal1 = new Strandbal();

        public MainForm()
        {
            InitializeComponent();
            UpdateDiameter();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Bal1.VerderOpblazen(0.10);
            UpdateDiameter();
        }

        private void UpdateDiameter()
        {
            Label.Text = "Diameter = " + Convert.ToString(Bal1.diameter);
        }
    }
}
