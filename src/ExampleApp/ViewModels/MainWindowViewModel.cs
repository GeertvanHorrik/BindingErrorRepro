using System.Collections.Generic;
using System.Threading.Tasks;
using Catel.MVVM;
using ExampleApp.Models;

namespace ExampleApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Families = GenerateFamilies();
        }

        public override string Title => "ExampleApp";

        public List<Family> Families { get; }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }

        private List<Family> GenerateFamilies()
        {
            var families = new List<Family>();

            var doeFamily = new Family
            {
                Name = "Doe"
            };

            doeFamily.Persons.Add(new Person(doeFamily)
            {
                FirstName = "John"
            });

            doeFamily.Persons.Add(new Person(doeFamily)
            {
                FirstName = "Jane"
            });

            families.Add(doeFamily);

            return families;
        }
    }
}