using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using PassengerStation.Data;
using PassengerStation.Service;

namespace PassengerStation.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(userRepository.Get());
        }

        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest(new ArgumentNullException(nameof(user)));
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                userRepository.Add(user);
                await userRepository.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> PutUser([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                userRepository.Attach(user);
                await userRepository.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            Expression<Func<User, bool>> expression = q => q.Id == id;

            var user = userRepository.Find(id);

            if (user == null) return BadRequest($"User with Id={id} is not found. Make sure you send and id and that the id is valid.");

            userRepository.Remove(user);

            await userRepository.SaveChangesAsync();

            return Ok();
        }
    }
}