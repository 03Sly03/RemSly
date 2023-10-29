using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RemSlyApi.Helpers;
using RemSlyApi.Repositories;
using RemSlyCore.Models;
using System.Text;

namespace RemSlyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;
        private readonly AppSettings _settings;
        public AuthenticationController(IRepository<User> userRepository, IOptions<AppSettings> settings)
        {
            _userRepository = userRepository;
            _settings = settings.Value;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (await _userRepository.Get(u => u.Email == user.Email) != null)
                return BadRequest("L'adresse mail est déjà utilisée.");

            user.PassWord = PasswordCrypter.Encypt(user.PassWord!, _settings.SecretKey!);

            if (await _userRepository.Add(user) > 0)
                return Ok(new {id = user.Id, Message = "L'utilisateur à bien été enregistré."});
            return BadRequest("Quelque chose n'a pas bien fonctionné");
        }
    }

}
