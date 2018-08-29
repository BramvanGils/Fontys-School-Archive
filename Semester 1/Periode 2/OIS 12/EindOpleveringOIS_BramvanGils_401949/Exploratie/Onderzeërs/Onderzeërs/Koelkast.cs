using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onderzeërs
{
    class Koelkast
    {
        private List<string> items = new List<string>();

        public Koelkast(List<string> Itmes)
        {
            foreach (string Item in items)
            {
                Itmes.Add(Item);
            }
        }
    }
}
