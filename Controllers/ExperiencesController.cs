using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio_API.Data;
using Portfolio_API.Models;
using Portfolio_API.Services;

namespace Portfolio_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperiencesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Experiences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experience>>> GetExperiences(int? page)
        {
            List<Experience> experiences = await _unitOfWork.ExperienceRepository.GetAll(page, 10);

            if (!experiences.Any()) return NotFound();

            return Ok(experiences);
        }

        // GET: api/Experiences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Experience>> GetExperience(int id)
        {
            Experience experience = await _unitOfWork.ExperienceRepository.GetById(id);

            if (experience == null) return NotFound();

            return Ok(experience);
        }

        // PUT: api/Experiences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutExperience(int id, Experience experience)
        {
            if (id != experience.Id)
            {
                return BadRequest();
            }

            _unitOfWork.ExperienceRepository.Entry_Modified(experience);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _unitOfWork.ExperienceRepository.GetById(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    return StatusCode(409, "Erreur de mise à jour des données.");
                }
            }

            return NoContent();
        }

        // POST: api/Experiences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<Experience>> PostExperience(Experience experience)
        {
            _unitOfWork.ExperienceRepository.AddAsync(experience);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return StatusCode(304, "Echec de la mise à jour des données.");
            }

            return CreatedAtAction("GetCategory_Language", new { id = experience.Id }, experience);
        }

        // DELETE: api/Experiences/5
        [Authorize]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteExperience(int id)
        {
            Experience experience = await _unitOfWork.ExperienceRepository.GetById(id);

            if (experience == null) return NotFound();

            _unitOfWork.ExperienceRepository.Remove(experience);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return StatusCode(304, "Echec de la suppression des données.");
            }
            return NoContent();
        }
    }
}
