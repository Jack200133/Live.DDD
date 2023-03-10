using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live.DDD.Domain.ValueObjetcs
{
    public record PersonName
    {
        public string Value { get; init; }

        internal PersonName(string value) 
        {
            this.Value = value;
        }

        public static PersonName Create(string value)
        {
            validate(value);
            return new PersonName(value);
        }

        private static void validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value cannt be null");
            }
        }

    }
}
