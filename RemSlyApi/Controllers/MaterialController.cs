using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemSlyApi.Repositories;
using RemSlyCore.Models;

namespace RemSlyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IRepository<Material> _materialRepository;

        public MaterialController(IRepository<Material> materialRepository)
        {
            _materialRepository = materialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _materialRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Recuperation(int id)
        {
            var material = await _materialRepository.GetById(id);
            if (material == null)
            {
                return NotFound("matériel non trouvé");
            }
            return Ok(material);
        }

        [HttpPost]
        public async Task<IActionResult> Addmaterial([FromBody] Material material)
        {
            var materialId = await _materialRepository.Add(material);

            if (materialId > 1)
                return CreatedAtAction(nameof(Menu), new { id = material.Id, Message = "matériel ajouté !" });

            return BadRequest("Something went wrong");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMaterial(int id, [FromBody] Material material)
        {
            material = await _materialRepository.GetById(id);
            if (material == null)
                return BadRequest("matériel non trouvé");

            material.Id = id;
            if (await _materialRepository.Update(material))
                return Ok("matériel mis à jour !");

            return BadRequest("Something went wrong...");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveMaterial(int id)
        {
            var material = await _materialRepository.GetById(id);
            if (material == null)
                return BadRequest("matériel non trouvé");

            if (await _materialRepository.Delete(id))
                return Ok("matériel supprimé");

            return BadRequest("Something went wrong...");
        }
    }
}
