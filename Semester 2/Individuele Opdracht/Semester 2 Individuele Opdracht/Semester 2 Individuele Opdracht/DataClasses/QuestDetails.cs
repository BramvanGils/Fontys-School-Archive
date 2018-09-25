using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_Individuele_Opdracht.DataClasses
{
    class QuestDetails
    {
        public string title { get; private set; }
        public string description { get; private set; }

        public QuestDetails(string Title, string Description)
        {
            title = Title;
            description = Description;
        }
    }
}
