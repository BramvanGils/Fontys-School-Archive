using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BerekenButton_Click(object sender, EventArgs e)
        {
            int caloriengeslacht = 2000;
            double calorienlevensstijl = 1;
            int calorienleeftijd = 0;
            ErrorLabel.Visible = false;

            if (ManRadioButton.Checked || ZwangerCheckBox.Checked && !string.IsNullOrWhiteSpace(LeeftijdTextBox.Text) && Convert.ToInt32(LeeftijdTextBox.Text) > 30)
            {
                caloriengeslacht = 2500;
            }
            else if(Convert.ToInt32(LeeftijdTextBox.Text) <= 30 && ZwangerCheckBox.Checked && !string.IsNullOrWhiteSpace(LeeftijdTextBox.Text))
            {
                caloriengeslacht = 2600;
            }

            if (NietActiefRadioButton.Checked)
            {
                calorienlevensstijl = 0.9;
            }


            if (string.IsNullOrWhiteSpace(LeeftijdTextBox.Text))
            {
                ErrorLabel.Visible = true;
            }
            else if (Convert.ToInt32(LeeftijdTextBox.Text) > 50)
            {
                calorienleeftijd = 200;
            }
            else if (Convert.ToInt32(LeeftijdTextBox.Text) < 12)
            {
                calorienleeftijd = 180;
            }


            CalorienLabel.Text = caloriengeslacht * calorienlevensstijl - calorienleeftijd + " Calorien";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LeeftijdTextBox_TextChanged(object sender, EventArgs e)
        {
  
        }
        
        private void VrouwRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (VrouwRadioButton.Checked)
            {
                ZwangerCheckBox.Enabled = true;
            }
            else
            {
                ZwangerCheckBox.Enabled = false;
                ZwangerCheckBox.Checked = false;
            }
        }
    }
}
