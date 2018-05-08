using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Versie
{
    public partial class statestieken : Form
    {
        MainFrame MAINFRAME;
        public statestieken(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;

            
            UpdateStatBars();
        }

        // Navigate to QuestLog
        private void buttonStatestiekenVorigepagina_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "QuestLog";
            Close();
        }

        // Navigate to Inventaris
        private void buttonStatestiekensvolgendepagina_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "Inventaris";
            Close();
        }

        // Navigate to QuestInterface
        private void buttonStatestiekenTerug_Click(object sender, EventArgs e)
        {
            MAINFRAME.NextForm = "QuestInterface";
            Close();
        }

        // Update Stat Values
        public void UpdateStatBars()
        {
            double Health = MAINFRAME.Health;
            double MaxHealth = MAINFRAME.MaxHealth;
            double HealthWidth = (Health / MaxHealth);
            HealthBarPlayer.Width = Convert.ToInt32(HealthWidth * 500);
            double Stamina = MAINFRAME.Stamina;
            double MaxStamina= MAINFRAME.MaxStamina;
            double StaminaWidth = (Stamina / MaxStamina);
            StaminaBarPlayer.Width = Convert.ToInt32(StaminaWidth * 500);
            double Mana = MAINFRAME.Mana;
            double MaxMana = MAINFRAME.MaxMana;
            double ManaWidth = (Mana / MaxMana);
            ManaBarPlayer.Width = Convert.ToInt32(ManaWidth * 500);
        }


        private void statestieken_Load(object sender, EventArgs e)
        {

        }
    }
}

