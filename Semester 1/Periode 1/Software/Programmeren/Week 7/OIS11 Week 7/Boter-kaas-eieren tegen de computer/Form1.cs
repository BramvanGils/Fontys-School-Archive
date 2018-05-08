using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boter_kaas_eieren_tegen_de_computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }





















        private void Square1_Click(object sender, EventArgs e)
        {
            
        }

        private void Square2_Click(object sender, EventArgs e)
        {
            
        }

        private void Square3_Click(object sender, EventArgs e)
        {
            
        }

        private void Square4_Click(object sender, EventArgs e)
        {
            
        }

        private void Square5_Click(object sender, EventArgs e)
        {
            
        }

        private void Square6_Click(object sender, EventArgs e)
        {
            
        }

        private void Square7_Click(object sender, EventArgs e)
        {
            
        }

        private void Square9_Click(object sender, EventArgs e)
        {
            byte State = 0;
            UpdateState((Button)sender, State);
        }

        private void UpdateState(Button btn, Byte stt)
        {
            btn.Text = "X";
        }

        private string CheckVictoryX()
        {
            string Lines = "";
            if (Square1.Text == "X" ) { }



            return Lines;
        }
    }
}
