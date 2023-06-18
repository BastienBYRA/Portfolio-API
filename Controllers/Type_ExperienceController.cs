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
    [ResponseCache(Duration = 60)]
    public class Type_ExperienceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public Type_ExperienceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Type_Experience
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Type_Experience>>> GetTypes_Experiences(int? page)
        {
            List<Type_Experience> type_Experiences = await _unitOfWork.Type_ExperienceRepository.GetAll(page, 6);

            if (!type_Experiences.Any()) return NotFound();

            return Ok(type_Experiences);
        }

        // GET: api/Type_Experience/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Type_Experience>> GetType_Experience(int id)
        {
            Type_Experience type_Experience = await _unitOfWork.Type_ExperienceRepository.GetById(id);

            if (type_Experience == null) return NotFound();

            return Ok(type_Experience);
        }

        // PUT: api/Type_Experience/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutType_Experience(int id, Type_Experience type_Experience)
        {
            if (id != type_Experience.Id) return BadRequest();

            _unitOfWork.Type_ExperienceRepository.Entry_Modified(type_Experience);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _unitOfWork.Type_ExperienceRepository.GetById(type_Experience) == null)
                    return NotFound();

                else
                    return StatusCode(409, "Erreur de mise à jour des données.");
            }

            return NoContent();
        }

        // POST: api/Type_Experience
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<Type_Experience>> PostType_Experience(Type_Experience type_Experience)
        {
            _unitOfWork.Type_ExperienceRepository.AddAsync(type_Experience);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return StatusCode(304, "Echec de la mise à jour des données.");
            }

            return CreatedAtAction("GetType_Experience", new { id = type_Experience.Id }, type_Experience);
        }

        // DELETE: api/Type_Experience/5
        [Authorize]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteType_Experience(int id)
        {
            Type_Experience type_Experience = await _unitOfWork.Type_ExperienceRepository.GetById(id);

            if (type_Experience == null) return NotFound();

            _unitOfWork.Type_ExperienceRepository.Remove(type_Experience);

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
