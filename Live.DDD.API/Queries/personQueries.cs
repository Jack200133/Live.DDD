using Live.DDD.Domain.Entities;
using Live.DDD.Domain.Repositories;
using Live.DDD.Domain.ValueObjetcs;

namespace Live.DDD.API.Queries
{
    public class personQueries
    {
        private readonly IPersonRepository personRepository;

        public personQueries(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public async Task<Person> GetPersonIdAsync(Guid id)
        {
            var response = await personRepository.GetPersonByID(
                PersonId.create(id));

            return response;
        }
    }
}
