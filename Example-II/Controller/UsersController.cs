using Example_II.FakeDatabase;
using Example_II.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example_II.Controller
{
    [Route("api/[controller]")] //we use api for api project and instead of writing users we simply write [controller]
    public class UsersController:ControllerBase
    {

        private List<User> _users = FakeData.GetUsers(100);

        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return _users.SingleOrDefault(u=>u.Id==id);
        }

    }
}
