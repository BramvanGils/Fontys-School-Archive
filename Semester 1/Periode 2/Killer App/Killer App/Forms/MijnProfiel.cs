using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Killer_App.Forms
{
    public partial class MijnProfiel : Form
    {
        public MijnProfiel()
        {
            InitializeComponent();

            NaamLabel.Text = DatabaseManager.RetrieveGebruikerNaam(ScreenManager.CurrentUser);
            GebruikerPicturebox.Image = DatabaseManager.RetrieveGebruikerFoto(ScreenManager.CurrentUser);

        }
    }
}
