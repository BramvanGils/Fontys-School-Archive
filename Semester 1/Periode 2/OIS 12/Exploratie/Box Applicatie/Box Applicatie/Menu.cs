using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box_Applicatie
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void WedstrijdButton_Click(object sender, EventArgs e)
        {
            Button ButtonObject = (Button)sender;
            ButtonObject.BackColor = Color.Red;
            //new Wedstrijd(this).ShowDialog();
        }
    }
}
