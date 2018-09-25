using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semester_2_Individuele_Opdracht.Controllers;

namespace Semester_2_Individuele_Opdracht.Forms
{
    public partial class DetailsForm : Form
    {
        private DetailsController detailsController;

        public DetailsForm()
        {
            detailsController = new DetailsController(3);
            InitializeComponent();
            TitelLabel.Text = detailsController.Title;
            DescriptionBox.Text = detailsController.Description;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

        }
    }
}
