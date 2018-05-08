using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hallo_jij_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            String Text = TextBox.Text;
            String LastName = Text.Substring(Text.IndexOf(" "), Text.Length - Text.IndexOf(" "));
            if (RadioButtonMan.Checked)
            {
                MessageBox.Show("Hallo Mijnheer" + LastName);
            }
            else
            {
                MessageBox.Show("Hallo mejuffrouw" + LastName);
            }
            
            ;
        }
    }
}
