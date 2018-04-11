using System.Collections.Generic;

namespace ExampleApp.Models
{
    public class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }

        public string Name { get; set; }

        public List<Person> Persons { get; private set; }
    }
}