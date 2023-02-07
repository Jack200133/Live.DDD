using Live.DDD.Domain.Entities;
using Live.DDD.Domain.Repositories;
using Live.DDD.Domain.ValueObjetcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.DDD.infraestructure
{
    public class PersonRepository : IPersonRepository
    {
        DatabaseContext db;

        public PersonRepository(DatabaseContext db_)
        {
            db = db_;
        }

        public async Task AddPerson(Person person)
        {
            await db.AddAsync(person);
            await db.SaveChangesAsync();
        }

        public async Task<Person> GetPersonByID(PersonId Id)
        {
            return await db.Persons.FindAsync((Guid)Id);
        }
    }
}
