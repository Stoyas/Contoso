using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class PersonService
    {
        public List<People> GetAllPersons()
        {
            PeopleRepository repository = new PeopleRepository();
            var People = repository.GetAll();
            return People;
        }
        public void SavePerson(People pel)
        {
            PeopleRepository repository = new PeopleRepository();
            repository.CreateNew(pel);
        }
    }
}
