using Live.DDD.Domain.ValueObjetcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.DDD.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; init; }
        public PersonName Name { get; private set; }

        public Person(Guid id)
        {
            this.Id = id;
        }
        public void SetName(PersonName name)
        {
            Name = name;
        }
    }
}
