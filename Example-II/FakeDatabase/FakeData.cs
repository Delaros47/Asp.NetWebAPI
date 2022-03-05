using Bogus;
using Example_II.Models;

namespace Example_II.FakeDatabase
{
    public static class FakeData
    {

        private static List<User> _users;

        public static List<User> GetUsers(int generateNumber)
        {
            if (_users == null)
            {
                _users = new Faker<User>()
                                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                                .RuleFor(u => u.LastName, f => f.Name.LastName())
                                .RuleFor(u => u.Address, f => f.Address.FullAddress())
                                .Generate(generateNumber);
            }

            return _users;

            //Here we created FakeData in our project from NuGet we have added
            //Bugus and create class in order to generate random fake datas
        }

    }
}
