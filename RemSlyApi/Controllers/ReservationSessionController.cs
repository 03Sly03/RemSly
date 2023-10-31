using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemSlyApi.Repositories;
using RemSlyCore.Models;

namespace RemSlyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationSessionController : ControllerBase
    {
        private readonly ReservationSessionRepository _reservationSession;

        public ReservationSessionController(ReservationSessionRepository reservationSession)
        {
            _reservationSession = reservationSession;
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _reservationSession.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Recuperation(int sessionid, int reservationid)
        {
            var session = await _reservationSession.GetById(sessionid, reservationid);
            if (session == null)
            {
                return NotFound("session non trouvé");
            }
            return Ok(session);
        }

        [HttpPost]
        public async Task<IActionResult> Addsession([FromBody] ReservationSession reservationSession)
        {
            var sessionId = await _reservationSession.Add(reservationSession);

            if (sessionId > 1)
                return CreatedAtAction(nameof(Menu), new { id = reservationSession.SessionId, Message = "session ajouté !" });

            return BadRequest("Something went wrong");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveReservationSession(int sessionid, int reservationid)
        {
            var reservationSession = await _reservationSession.GetById(sessionid, reservationid);
            if (reservationSession == null)
                return BadRequest("session non trouvé");

            if (await _reservationSession.Delete(sessionid, reservationid))
                return Ok("session supprimé");

            return BadRequest("Something went wrong...");
        }
    }
}
