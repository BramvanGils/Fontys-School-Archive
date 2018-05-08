using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tafel_van_Drie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Listbox.Items.Add(Convert.ToString(MaalDrie(i)));
            }
        }

        int MaalDrie(int x)
        {
            int uitkomst = x * 3;
            return uitkomst;
        }

    }
}
