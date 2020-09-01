using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class counterService
    {
        counterProvider ojSectionProvider;
        // constructor
        public counterService()
        {
            ojSectionProvider = new counterProvider();
        }

        public List<section> GetAllCounters()
        {
            return ojSectionProvider.GetAllCounters();
        }

        public bool SaveCounter(section model)
        {
            return ojSectionProvider.SaveCounter(model);
        }

        public bool DeleteCounter(int id)
        {
            return ojSectionProvider.DeleteCounter(id);
        }
        public List<section> IsSectionNameExist(string sectionname, int id)
        {
            return ojSectionProvider.IsSectionNameExist(sectionname, id);
        }

    }
}
