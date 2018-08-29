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
    public partial class InlogScherm : Form
    {
        public InlogScherm()
        {
            InitializeComponent();
            Graphics graphics = CreateGraphics();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int GebruikersId = 0;

            try
            {
                GebruikersId = DatabaseManager.GetGebruikersId(GebruikersnaamTextbox.Text);
                ErrorLabel.Visible = false;
            }
            catch(IndexOutOfRangeException)
            {
                ErrorLabel.Text = "gebruikersnaam niet gevonden";
                ErrorLabel.Visible = true;
            }
            catch
            {
                ErrorLabel.Text = "Systeem fout, neem contact op met een admin";
                ErrorLabel.Visible = true;
            }

            if (ErrorLabel.Visible != true)
            {
                try
                {
                    if (DatabaseManager.CompareLoginData(GebruikersId, WachtwoordTextbox.Text))
                    {
                        ScreenManager.NextScreen = ScreenManager.Screen.HoofdMenu;
                        ScreenManager.CurrentUser = DatabaseManager.GetGebruikersId(GebruikersnaamTextbox.Text);
                        Close();
                    }
                    else
                    {
                        ErrorLabel.Text = "Wachtwoord komt niet overeen met gebruikersnaam";
                        ErrorLabel.Visible = true;
                    }
                }
                catch
                {
                    ErrorLabel.Text = "Systeem fout, neem contact op met een admin";
                    ErrorLabel.Visible = true;
                }
            }
        }

        private void RegistreerButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (GebruikersnaamTextbox.Text.Length > 50 || GebruikersnaamTextbox.Text.Length < 3)
            {
                ErrorLabel.Text = "een gebruikersnaam moet binnen de 3 en 50 karakters zijn";
                ErrorLabel.Visible = true;
                valid = false;
            }
            else if (WachtwoordTextbox.Text.Length > 21 || WachtwoordTextbox.Text.Length < 6)
            {
                ErrorLabel.Text = "een wachtwoord moet binnen de 6 en 21 karakters zijn";
                ErrorLabel.Visible = true;
                valid = false;
            }
            else
            {
                try
                {
                    DatabaseManager.GetGebruikersId(GebruikersnaamTextbox.Text);
                    ErrorLabel.Text = "Gebruikersnaam al in gebruik";
                    ErrorLabel.Visible = true;
                    valid = false;
                }
                catch (IndexOutOfRangeException)
                {
                    
                }
                catch
                {
                    ErrorLabel.Text = "Systeem fout, neem contact op met een admin";
                    ErrorLabel.Visible = true;
                    valid = false;
                }

                try
                {
                    DatabaseManager.ExistingPassword(WachtwoordTextbox.Text);
                    ErrorLabel.Text = "Wachtwoord al in gebruik";
                    ErrorLabel.Visible = true;
                    valid = false;
                }
                catch (IndexOutOfRangeException)
                {
                    
                }
                catch
                {
                    ErrorLabel.Text = "Systeem fout, neem contact op met een admin";
                    ErrorLabel.Visible = true;
                    valid = false;
                }
            }

            if (valid)
            {
                DatabaseManager.AddGebruiker(GebruikersnaamTextbox.Text, WachtwoordTextbox.Text);
                ErrorLabel.Visible = false;
                ScreenManager.NextScreen = ScreenManager.Screen.HoofdMenu;
                ScreenManager.CurrentUser = DatabaseManager.GetGebruikersId(GebruikersnaamTextbox.Text);
                Close();
            }
        }
    }
}