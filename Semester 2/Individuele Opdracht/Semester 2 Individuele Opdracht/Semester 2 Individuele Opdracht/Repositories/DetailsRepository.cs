using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semester_2_Individuele_Opdracht.Interfaces;
using Semester_2_Individuele_Opdracht.DataClasses;

namespace Semester_2_Individuele_Opdracht.Repositories
{
    class DetailsRepository
    {
        private IDetailsContext detailsContext;

        public DetailsRepository(IDetailsContext detailsContext)
        {
            this.detailsContext = detailsContext;
        }

        private string GetTitle(int Id)
        {
            return detailsContext.GetTitle(Id);
        }

        private string GetDescription(int Id)
        {
            return detailsContext.GetDescription(Id);
        }

        public QuestDetails BuildDataObject(int Id)
        {
            return new QuestDetails(GetTitle(Id), GetDescription(Id));
        }
    }
}
