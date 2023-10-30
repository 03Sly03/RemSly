using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RemSlyApi.DTOs;
using RemSlyApi.Helpers;
using RemSlyApi.Repositories;
using RemSlyCore.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO login)
        {
            login.Password = PasswordCrypter.Encypt(login.Password!, _settings.SecretKey!);

            var user = await _userRepository.Get(user => user.Email == login.Email && user.PassWord == login.Password);
            if (user == null) return NotFound("Utilisateur inconnu !");

            #region JWT
            //JWT
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };

            SigningCredentials signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_settings.SecretKey!)),
                SecurityAlgorithms.HmacSha256);

            JwtSecurityToken jwt = new JwtSecurityToken(
                issuer: _settings.ValidIssuer,
                audience: _settings.ValidAudience,
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.Now.AddDays(7)
                );

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);
            #endregion

            return Ok(new
            {
                Token = token,
                Message = "Utilisateur Authentifié avec succé !",
                User = user
            });
        }
    }


}
