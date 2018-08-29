using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onderzeërs
{
    class Marine
    {
        List<Onderzeër> Onderzeërs = new List<Onderzeër>();

        
        public Marine()
        {
            for (int i = 0; i < 4;i++)
            Onderzeërs.Add(OnderzeërBuilder.Create());
        }

        public int aantal()
        {
            return Onderzeërs.Count;
        }
    }

    
}
