using Catel;

namespace ExampleApp.Models
{
    public class Person
    {
        public Person(Family family)
        {
            Argument.IsNotNull(() => family);

            Family = family;
        }

        public Family Family { get; }

        public string FirstName { get; set; }
    }
}