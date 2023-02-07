
using Live.DDD.API.Commands;
using Live.DDD.API.Queries;
using Live.DDD.Domain.Entities;
using Live.DDD.Domain.Repositories;
using Live.DDD.Domain.ValueObjetcs;

namespace Live.DDD.API.ApplicationServices
{
    public class LiveServices
    {
        private readonly IPersonRepository repository;
        private readonly personQueries personQueries;

        public LiveServices(IPersonRepository repository,
                personQueries personQueries
            )
        {
            this.repository = repository;
            this.personQueries = personQueries;
        }
        public async Task HandleCommand(CreatePersonCommand createPerson)
        {
            var person = new Person(
                PersonId.create(createPerson.personId));

            person.SetName(PersonName.Create(createPerson.Name));

            await repository.AddPerson(person);
        }
        public async Task<Person> GetPerson(Guid id)
        {
            return await personQueries.GetPersonIdAsync(id);    
        }

    }
}
