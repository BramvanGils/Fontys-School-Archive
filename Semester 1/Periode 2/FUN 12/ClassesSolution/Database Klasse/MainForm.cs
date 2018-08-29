using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Klasse
{
    public partial class MainForm : Form
    {
        Database DB = new Database();
        string Data;

        public MainForm()
        {
            InitializeComponent();

            DB.open();
            Data = DB.Execute("test");
        }


    }
}
