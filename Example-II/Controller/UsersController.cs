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
        public User Get(int id)
        {
            return _users.SingleOrDefault(u=>u.Id==id);
        }

        [HttpPost]
        public User Add([FromBody]User user)
        {
            _users.Add(user);
            return user;
        }

        [HttpPut]
        public User Update([FromBody]User user)
        {
            var updatedUser = _users.SingleOrDefault(u=>u.Id==user.Id);
            updatedUser.FirstName = user.FirstName;
            updatedUser.LastName = user.LastName;
            updatedUser.Address = user.Address;
            return user;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var deletedUser = _users.SingleOrDefault(u=>u.Id==id);
            _users.Remove(deletedUser);
        }

    }
}
