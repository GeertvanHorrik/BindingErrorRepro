using System.Collections.Generic;
using Catel;
using Catel.Fody;
using Catel.MVVM;
using ExampleApp.Models;

namespace ExampleApp.ViewModels
{
    public class FamilyViewModel : ViewModelBase
    {
        public FamilyViewModel(Family family)
        {
            Argument.IsNotNull(() => family);

            Family = family;
            Members = family.Persons;
        }

        public Family Family { get; }

        public List<Person> Members { get; private set; }
    }
}