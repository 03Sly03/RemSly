using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RemSlyApi.Repositories;
using RemSlyCore.Models;

namespace RemSlyApi.Controllers
{
    [Route("api/club")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IRepository<Club> _clubRepository;

        public ClubController(IRepository<Club> clubRepository)
        {
            _clubRepository = clubRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _clubRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Recuperation(int id)
        {
            var club = await _clubRepository.GetById(id);
            if (club == null)
            {
                return NotFound("Club non trouvé");
            }
            return Ok(club);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddClub([FromBody] Club club)
        {
            var clubId = await _clubRepository.Add(club);

            if (clubId > 1)
                return CreatedAtAction(nameof(Menu), new { id = club.Id, Message = "Club ajouté !" });

            return BadRequest("Something went wrong");
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateClub(int id, [FromBody] Club club)
        {
            var pizz = await _clubRepository.GetById(id);
            if (pizz == null)
                return BadRequest("Club non trouvé");

            club.Id = id;
            if (await _clubRepository.Update(club))
                return Ok("Club mis à jour !");

            return BadRequest("Something went wrong...");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> RemoveClub(int id)
        {
            var club = await _clubRepository.GetById(id);
            if (club == null)
                return BadRequest("Club non trouvé");

            if (await _clubRepository.Delete(id))
                return Ok("Club supprimé");

            return BadRequest("Something went wrong...");
        }
    }
}
