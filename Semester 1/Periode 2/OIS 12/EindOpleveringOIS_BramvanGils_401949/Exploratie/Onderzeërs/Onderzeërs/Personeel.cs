using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onderzeërs
{
    class Personeel
    {
        public enum Rang {Majoor,Luitenant,Sergeant,Private}
        private Rang rang;

        public Personeel(Rang rang)
        {
            this.rang = rang;
        }
    }
}
