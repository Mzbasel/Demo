using System.Collections.Generic;

namespace Demo
{
    public class Client
    {
        public List<Person> Persons { get; } = new List<Person>();

        public void Add(Person person)
        {
            Persons.Add(person);
        }
    }
}
