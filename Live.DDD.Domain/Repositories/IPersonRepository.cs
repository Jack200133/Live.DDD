using Live.DDD.Domain.Entities;
using Live.DDD.Domain.ValueObjetcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.DDD.Domain.Repositories
{
    public interface PersonRepository
    {

        Task<Person> GetPersonByID(PersonId Id);
        Task AddPerson(Person person);
    }
}
