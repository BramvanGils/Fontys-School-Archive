using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semester_2_Individuele_Opdracht.mssqlContexts;
using Semester_2_Individuele_Opdracht.Repositories;
using Semester_2_Individuele_Opdracht.DataClasses;
using Semester_2_Individuele_Opdracht.Interfaces;

namespace Semester_2_Individuele_Opdracht.Controllers
{
    class DetailsController
    {
        private int Id;

        private IDetailsContext context;
        private DetailsRepository detailsRepository;
        private QuestDetails questDetails;

        public string Title
        {
            get
            {
                return questDetails.title;
            }
        }
        public string Description
        {
            get
            {
                return questDetails.description;
            }
        }

        public DetailsController(int Id)
        {
            this.Id = Id;
            context = new DetailsmssqlContext();
            detailsRepository = new DetailsRepository(context);
            questDetails = detailsRepository.BuildDataObject(Id);
        }
    }
}
