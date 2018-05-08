using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pincode_Reminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (TextBoxGebruikersnaam.Text == "Bram" && TextBoxWachtwoord.Text == "12345")
            {
                LabelGoed.Visible = true;
                LabelFout.Visible = false;
                TextBoxWachtwoord.Text = "";
            }
            else
            {
                LabelGoed.Visible = false;
                LabelFout.Visible = true;
                TextBoxWachtwoord.Text = "";
            }
        }
    }
}
