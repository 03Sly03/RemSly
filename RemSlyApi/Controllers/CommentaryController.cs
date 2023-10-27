using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemSlyApi.Repositories;
using RemSlyCore.Models;

namespace RemSlyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentaryController : ControllerBase
    {
        private readonly IRepository<Commentary> _commentaryRepository;

        public CommentaryController(IRepository<Commentary> commentaryRepository)
        {
            _commentaryRepository = commentaryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _commentaryRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Recuperation(int id)
        {
            var commentary = await _commentaryRepository.GetById(id);
            if (commentary == null)
            {
                return NotFound("commentary non trouvé");
            }
            return Ok(commentary);
        }

        [HttpPost]
        public async Task<IActionResult> Addcommentary([FromBody] Commentary commentary)
        {
            var commentaryId = await _commentaryRepository.Add(commentary);

            if (commentaryId > 1)
                return CreatedAtAction(nameof(Menu), new { id = commentary.Id, Message = "commentary ajouté !" });

            return BadRequest("Something went wrong");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCommentary(int id, [FromBody] Commentary commentary)
        {
            commentary = await _commentaryRepository.GetById(id);
            if (commentary == null)
                return BadRequest("commentary non trouvé");

            commentary.Id = id;
            if (await _commentaryRepository.Update(commentary))
                return Ok("commentary mis à jour !");

            return BadRequest("Something went wrong...");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCommentary(int id)
        {
            var commentary = await _commentaryRepository.GetById(id);
            if (commentary == null)
                return BadRequest("commentary non trouvé");

            if (await _commentaryRepository.Delete(id))
                return Ok("commentary supprimé");

            return BadRequest("Something went wrong...");
        }
    }
}
