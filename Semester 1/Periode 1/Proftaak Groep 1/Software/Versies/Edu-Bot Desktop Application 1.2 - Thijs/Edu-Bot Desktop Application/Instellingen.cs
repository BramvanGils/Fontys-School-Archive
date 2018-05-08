using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace instellingen
{
    public partial class Instellingen : Form
    {
        public Instellingen()
        {
            InitializeComponent();
        }

        private void buttonInstellingenStandaardinstellingen_Click(object sender, EventArgs e)
        {
            trackBarInstellingenDeeltjeseffecten.Value = 2;
            trackbarInstellingenGamegeluid.Value = 10;
            trackbarInstellingenMuziek.Value = 10;
            trackBarInstellingenSchermopties.Value = 2;
            trackBarInstellingenHUD.Value = 2;
            trackbarInstellingenRobotgeluid.Value = 10;
        }

        private void buttonInstellingenTerug_Click(object sender, EventArgs e)
        {
            Thread th;

            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Instellingen f2 = new Instellingen();
            Application.Run(f2);
        }
    }
}