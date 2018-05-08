using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euro_dollar_converter
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

        

        private void koersbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toAbutton_Click(object sender, EventArgs e)
        {
            double koers;
            double ACurrency = Convert.ToDouble(Abox.Text);
            double BCurrency = Convert.ToDouble(Bbox.Text);
            if (comboBoxB.Text == "Dollars")
                {
                koers = Convert.ToDouble(koersboxdollar.Value);
                Abox.Text = Convert.ToString(BCurrency / koers);
                }
            if (comboBoxB.Text == "Yen")
                {
                koers = Convert.ToDouble(koersboxyen.Value);
                Abox.Text = Convert.ToString(BCurrency / koers);
                }

            
        }

        private void toBbutton_Click(object sender, EventArgs e)
        {
            double koers;
            double ACurrency = Convert.ToDouble(Abox.Text);
            double BCurrency = Convert.ToDouble(Bbox.Text);
            if (comboBoxB.Text == "Dollars")
            {
                koers = Convert.ToDouble(koersboxdollar.Value);
                Bbox.Text = Convert.ToString(ACurrency * koers);
            }
            if (comboBoxB.Text == "Yen")
            {
                koers = Convert.ToDouble(koersboxyen.Value);
                Bbox.Text = Convert.ToString(ACurrency * koers);
            }
        }

        private void Abox_TextChanged(object sender, EventArgs e)
        {
            errorlabel.Visible = false;
            if (!string.IsNullOrWhiteSpace(Bbox.Text))
            {
                try
                {
                        Convert.ToDouble(Abox.Text);
                }
                catch (Exception)
                {
                        errorlabel.Visible = true;
                }
            }
        }

        private void Bbox_TextChanged(object sender, EventArgs e)
        {
            errorlabel.Visible = false;
            if (!string.IsNullOrWhiteSpace(Bbox.Text ))
            {
                try
                {
                    Convert.ToDouble(Bbox.Text);
                }
                catch (Exception)
                {
                    errorlabel.Visible = true;
                }
            }
        }

       
        private void comboBoxA_TextUpdate(object sender, EventArgs e)
        {
          
        }


        private void comboBoxB_TextUpdate(object sender, EventArgs e)
        {
            
         
        }


        private void errorlabel_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxB.Text)
            {
                case "Euros":
                    labelB.Text = "€";
                    break;
                case "Dollars":
                    labelB.Text = "$";
                    break;
                case "Yen":
                    labelB.Text = "¥";
                    break;
            }
        }

        private void koersboxyen_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}