using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankRekening
{
    public partial class BankrekeningForm : Form
    {
        // Fields
        private Bankrekening bankrekeningLinks;
        private Bankrekening bankrekeningRechts;



        public enum Richting { Transactie, Links, Rechts };


        // Constructor
        public BankrekeningForm()
        {
            InitializeComponent();
            bankrekeningLinks = new Bankrekening("Duck, Dagobert");
            bankrekeningRechts = new Bankrekening("Gans, Gijs");
            LabelNaamLinks.Text = bankrekeningLinks.Naam;
            LabelNaamRechts.Text = bankrekeningRechts.Naam;
            LabelRekeningnrLinks.Text = Convert.ToString(bankrekeningLinks.Rekeningnummer);
            LabelRekeningnrRechts.Text = Convert.ToString(bankrekeningRechts.Rekeningnummer);
            AddToLogboek(bankrekeningLinks, bankrekeningRechts, 12);
        }

        private void ButtonOpnemenLinks_Click(object sender, EventArgs e)
        {
            bankrekeningLinks.NeemOp(TextboxNaarSaldo(Richting.Links));
            LabelSaldoLinks.Text = SaldoNaarString(bankrekeningLinks.Saldo, LabelSaldoLinks);
        }

        private void ButtonOpnemenRechts_Click(object sender, EventArgs e)
        {
            bankrekeningRechts.NeemOp(TextboxNaarSaldo(Richting.Rechts));
            LabelSaldoRechts.Text = SaldoNaarString(bankrekeningRechts.Saldo, LabelSaldoRechts);
        }

        private void ButtonStortenLinks_Click(object sender, EventArgs e)
        {
            bankrekeningLinks.Stort(TextboxNaarSaldo(Richting.Links));
            UdateUI();
        }

        private void ButtonStortenRechts_Click(object sender, EventArgs e)
        {
            bankrekeningRechts.Stort(TextboxNaarSaldo(Richting.Rechts));
            UdateUI();
        }

        private void ButtonMaakoverNaarRechts_Click(object sender, EventArgs e)
        {
            switch (bankrekeningRechts.MaakOver(bankrekeningLinks, TextboxNaarSaldo(Richting.Transactie)))
            {
                case Bankrekening.TransactieStatus.Gelukt:
                    UdateUI();
                    break;
                case Bankrekening.TransactieStatus.OnvoldoendeSaldo:
                    MessageBox.Show("Onvolddoende Saldo");
                    break;
                case Bankrekening.TransactieStatus.Negatiefbedrag:
                    MessageBox.Show("Voer Positief Getal In");
                    break;
            }
        }

        private void UdateUI()
        {
            LabelSaldoLinks.Text = SaldoNaarString(bankrekeningLinks.Saldo, LabelSaldoLinks);
            LabelSaldoRechts.Text = SaldoNaarString(bankrekeningRechts.Saldo, LabelSaldoRechts);
        }

        private void ButtonMaakoverNaarLinks_Click(object sender, EventArgs e)
        {
            bankrekeningLinks.MaakOver(bankrekeningRechts, TextboxNaarSaldo(Richting.Transactie));
            LabelSaldoLinks.Text = SaldoNaarString(bankrekeningLinks.Saldo, LabelSaldoLinks);
            LabelSaldoRechts.Text = SaldoNaarString(bankrekeningRechts.Saldo, LabelSaldoRechts);
        }

        private int TextboxNaarSaldo(Richting richting)
        {
            try
            {
                int Euros;
                int Centen;

                if (richting == Richting.Links)
                {
                    Euros = Convert.ToInt32(TextboxEurosLinks.Text);
                    Centen = Convert.ToInt32(TextboxCentenLinks.Text);

                    if (Centen >= 100)
                    {
                        MessageBox.Show("Voer niet meer dan 99 Cent in A.U.B.");
                        return 0;
                    }
                    else
                    {
                        return Euros * 100 + Centen;
                    }
                }
                else if (richting == Richting.Rechts)
                {
                    Euros = Convert.ToInt32(TextboxEurosRechts.Text);
                    Centen = Convert.ToInt32(TextboxCentenRechts.Text);

                    if (Centen >= 100)
                    {
                        MessageBox.Show("Voer niet meer dan 99 Cent in A.U.B.");
                        return 0;
                    }
                    else
                    {
                        return Euros * 100 + Centen;
                    }
                }
                else
                {
                    Euros = Convert.ToInt32(TextboxEurosTransactie.Text);
                    Centen = Convert.ToInt32(TextboxCentenTransactie.Text);

                    if (Centen >= 100)
                    {
                        MessageBox.Show("Voer niet meer dan 99 Cent in A.U.B.");
                        return 0;
                    }
                    else
                    {
                        return Euros * 100 + Centen;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Voer een geldig bedrag in A.U.B.");
                return 0;
            }

        }

        public string SaldoNaarString(int saldo, Label label)
        {
            if (label == null)
            {
                return "€" + "-" + Math.Abs(saldo / 100) + "," + Math.Abs((saldo % 100 - saldo % 10) / 10) + Math.Abs(saldo % 10);
            }
            else if (saldo < 0)
            {
                label.ForeColor = Color.Red;
                return "€" + "-" + Math.Abs(saldo / 100) + "," + Math.Abs((saldo % 100 - saldo % 10) / 10) + Math.Abs(saldo % 10);
            }
            else
            {
                label.ForeColor = Color.Black;
                return "€" + saldo / 100 + "," + (saldo % 100 - saldo % 10) / 10 + saldo % 10;
            }
        }

        private void AddToLogboek(Bankrekening VanRekening, Bankrekening NaarRekening, int saldo)
        {
            ListboxLogboek.Items.Add(SaldoNaarString(saldo, null) + DateTime.Now.ToString("h:mm:ss tt") + "  " + DateTime.Today.ToString("dd-MM-yyyy"));
        }
    }
}
