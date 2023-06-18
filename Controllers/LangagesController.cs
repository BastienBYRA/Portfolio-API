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
    [ResponseCache(Duration = 30)]
    public class LangagesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public LangagesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Langages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Langage>>> GetLangages(int? page)
        {
            List<Langage> langages = await _unitOfWork.LangageRepository.GetAll(page, 10);

            if (!langages.Any()) return NotFound();

            return Ok(langages);
        }

        // GET: api/Langages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Langage>> GetLangage(int id)
        {
            Langage langage = await _unitOfWork.LangageRepository.GetById(id);

            if (langage == null) return NotFound();

            return Ok(langage);
        }

        // PUT: api/Langages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutLangage(int id, Langage langage)
        {
            if (id != langage.Id)
            {
                return BadRequest();
            }

            _unitOfWork.LangageRepository.Entry_Modified(langage);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _unitOfWork.LangageRepository.GetById(id) == null)
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

        // POST: api/Langages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<Langage>> PostLangage(Langage langage)
        {
            _unitOfWork.LangageRepository.AddAsync(langage);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return StatusCode(304, "Echec de la mise à jour des données.");
            }

            return CreatedAtAction("GetLangage", new { id = langage.Id }, langage);
        }

        // DELETE: api/Langages/5
        [Authorize]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteLangage(int id)
        {
            Langage langage = await _unitOfWork.LangageRepository.GetById(id);

            if (langage == null) return NotFound();

            _unitOfWork.LangageRepository.Remove(langage);

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
