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
    public partial class Wedstrijd : Form
    {
        public Wedstrijd(Menu OldMenu)
        {
            InitializeComponent();
            OldMenu.Close();
        }
    }
}
