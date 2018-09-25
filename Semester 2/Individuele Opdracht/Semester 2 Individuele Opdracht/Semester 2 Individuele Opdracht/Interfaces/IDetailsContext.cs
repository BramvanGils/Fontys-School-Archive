using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Individuele_Opdracht.Interfaces
{
    interface IDetailsContext
    {
        string GetTitle(int Id);
        string GetDescription(int Id);
    }
}
