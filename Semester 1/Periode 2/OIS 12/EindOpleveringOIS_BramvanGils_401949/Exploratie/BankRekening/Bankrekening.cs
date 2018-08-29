using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening
{
    class Bankrekening
    {
        // Fields
        private int rekeningnummer;
        private string naam;
        private int saldo; // het saldo in hele centen
        private static int volgendeVrijeRekeningnummer = 2001;

        public enum TransactieStatus { Gelukt, OnvoldoendeSaldo, Negatiefbedrag }

        /*
        readonly int Rekeningnummer;
        readonly string Naam;
        readonly int Saldo;
        */


        // Constructors
        public Bankrekening(string naam)
        {
            this.naam = naam;
            saldo = 0;
            rekeningnummer = volgendeVrijeRekeningnummer;
            // we hogen het volgende vrije rekeningnummer met 1 op zodat de
            // volgende bankrekening een nummer krijgt dat 1 hoger is dan
            // deze bankrekening.
            volgendeVrijeRekeningnummer++;
        }
        public Bankrekening(string naam, int saldo)
        {
            this.naam = naam;
            this.saldo = saldo;
            rekeningnummer = volgendeVrijeRekeningnummer;
            // we hogen het volgende vrije rekeningnummer met 1 op zodat de
            // volgende bankrekening een nummer krijgt dat 1 hoger is dan
            // deze bankrekening.
            volgendeVrijeRekeningnummer++;
        }

        // Methods
        public TransactieStatus NeemOp(int bedrag)
        {
            saldo -= bedrag;
            if (bedrag > saldo)
            {
                return TransactieStatus.OnvoldoendeSaldo;
            }
            else if (bedrag < 0)
            {
                return TransactieStatus.Negatiefbedrag;
            }
            else
            {
                return TransactieStatus.Gelukt;
            }
        }

        public TransactieStatus Stort(int bedrag)
        {
            saldo += bedrag;
            if (bedrag > saldo)
            {
                return TransactieStatus.OnvoldoendeSaldo;
            }
            else if (bedrag < 0)
            {
                return TransactieStatus.Negatiefbedrag;
            }
            else
            {
                return TransactieStatus.Gelukt;
            }
        }

        public TransactieStatus MaakOver(Bankrekening andereRekening, int bedrag)
        {

            if (bedrag > saldo)
            {
                return TransactieStatus.OnvoldoendeSaldo;
            }
            else if (bedrag < 0)
            {
                return TransactieStatus.Negatiefbedrag;
            }
            else
            {
                andereRekening.saldo -= bedrag;
                saldo += bedrag;
                return TransactieStatus.Gelukt;
            }
        }

        //properties
        public int Rekeningnummer
        {
            get { return rekeningnummer; }
        }

        public int Saldo
        {
            get { return saldo; }
        }

        public string Naam
        {
            get { return naam; }
        }
    }
}
