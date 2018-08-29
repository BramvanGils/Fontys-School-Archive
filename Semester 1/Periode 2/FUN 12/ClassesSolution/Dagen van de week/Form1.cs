using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dagen_van_de_week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string input = TextBox.Text;

            try
            {
                MessageBox.Show(BerekenDag(Convert.ToInt32(TextBox.Text)));
            }
            catch(Exception error)
            {
                MessageBox.Show("Error:" + error);
            }
        }

        private string BerekenDag(int index)
        {
            switch (index) {
                case 1:
                    return "Maandag";
                case 2:
                    return "Dinsdag";
                case 3:
                    return "Woensdag";
                case 4:
                    return "Donderdag";
                case 5:
                    return "Vrijdag";
                case 6:
                    return "Zaterdag";
                case 7:
                    return "Zondag";
                default:
                    return "Voer een getal in tussen 1 en 7";
            }

        }
    }
}
