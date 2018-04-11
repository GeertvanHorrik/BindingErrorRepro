using Catel;
using ExampleApp.Models;

namespace ExampleApp.ViewModels
{
    using Catel.MVVM;

    public class PersonViewModel : ViewModelBase
    {
        public PersonViewModel(Person person)
        {
            Argument.IsNotNull(() => person);

            Person = person;

            FamilyName = person.Family.Name;
            FirstName = person.FirstName;
        }

        public Person Person { get; }

        public string FamilyName { get; set; }

        public string FirstName { get; set; }
    }
}