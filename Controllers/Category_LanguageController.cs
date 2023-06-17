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
    public class Category_LanguageController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public Category_LanguageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Category_Language
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category_Language>>> GetCategory_Languages(int? page)
        {
            var results = await _unitOfWork.Category_LanguageRepository.GetAll(page, 10);

            if (!results.Any()) return NotFound();

            return Ok(results);
        }

        // GET: api/Category_Language/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category_Language>> GetCategory_Language(int id)
        {
            var result = await _unitOfWork.Category_LanguageRepository.GetById(id);

            if (result == null) return NotFound();

            return Ok(result);
        }

        // PUT: api/Category_Language/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutCategory_Language(int id, Category_Language category_Language)
        {
            if (id != category_Language.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Category_LanguageRepository.Entry_Modified(category_Language);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _unitOfWork.Category_LanguageRepository.GetById(id) == null)
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

        // POST: api/Category_Language
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<Category_Language>> PostCategory_Language(Category_Language category_Language)
        {
            _unitOfWork.Category_LanguageRepository.AddAsync(category_Language);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch(Exception ex)
            {
                return StatusCode(304, "Echec de la mise à jour des données.");
            }
            
            return CreatedAtAction("GetCategory_Language", new { id = category_Language.Id }, category_Language);
        }

        // DELETE: api/Category_Language/5
        [Authorize]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteCategory_Language(int id)
        {
            var result = _unitOfWork.Category_LanguageRepository.GetById(id);

            if (result == default) return NotFound();

            _unitOfWork.Category_LanguageRepository.Remove(result.Result);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch(Exception ex)
            {
                return StatusCode(304, "Echec de la suppression des données.");
            }
            return NoContent();
        }
    }
}
