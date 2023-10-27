using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemSlyApi.Repositories;
using RemSlyCore.Models;

namespace RemSlyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;

        public UserController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _userRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Recuperation(int id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound("User non trouvé");
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var userId = await _userRepository.Add(user);

            if (userId > 1)
                return CreatedAtAction(nameof(Menu), new { id = user.Id, Message = "User ajouté !" });

            return BadRequest("Something went wrong");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            var pizz = await _userRepository.GetById(id);
            if (pizz == null)
                return BadRequest("user non trouvé");

            user.Id = id;
            if (await _userRepository.Update(user))
                return Ok("User mis à jour !");

            return BadRequest("Something went wrong...");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveUser(int id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null)
                return BadRequest("User non trouvé");

            if (await _userRepository.Delete(id))
                return Ok("User supprimé");

            return BadRequest("Something went wrong...");
        }

    }
}
