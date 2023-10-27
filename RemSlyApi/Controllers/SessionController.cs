using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemSlyApi.Repositories;
using RemSlyCore.Models;

namespace RemSlyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly IRepository<Session> _sessionRepository;

        public SessionController(IRepository<Session> sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _sessionRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Recuperation(int id)
        {
            var session = await _sessionRepository.GetById(id);
            if (session == null)
            {
                return NotFound("session non trouvé");
            }
            return Ok(session);
        }

        [HttpPost]
        public async Task<IActionResult> Addsession([FromBody] Session session)
        {
            var sessionId = await _sessionRepository.Add(session);

            if (sessionId > 1)
                return CreatedAtAction(nameof(Menu), new { id = session.Id, Message = "session ajouté !" });

            return BadRequest("Something went wrong");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSession(int id, [FromBody] Session session)
        {
            session = await _sessionRepository.GetById(id);
            if (session == null)
                return BadRequest("session non trouvé");

            session.Id = id;
            if (await _sessionRepository.Update(session))
                return Ok("session mis à jour !");

            return BadRequest("Something went wrong...");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveSession(int id)
        {
            var session = await _sessionRepository.GetById(id);
            if (session == null)
                return BadRequest("session non trouvé");

            if (await _sessionRepository.Delete(id))
                return Ok("session supprimé");

            return BadRequest("Something went wrong...");
        }
    }
}
