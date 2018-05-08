using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afbeeldingzoeker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // Unchecks the other checkbox if this checkbox is checked
        {
            if (checkBox1.Checked == true)
             {
                checkBox1.Checked = false;
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Unchecks the other checkbox if this checkbox is checked
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }
    }
}
