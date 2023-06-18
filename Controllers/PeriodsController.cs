using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    public class PeriodsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeriodsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Periods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Period>>> GetPeriods(int? page)
        {
            List<Period> periods = await _unitOfWork.PeriodRepository.GetAll(page, 10);

            if (!periods.Any()) return NotFound();

            return Ok(periods);
        }

        // GET: api/Periods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Period>> GetPeriod(int id)
        {
            Period period = await _unitOfWork.PeriodRepository.GetById(id);

            if (period == null) return NotFound();

            return Ok(period);
        }

        // PUT: api/Periods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutPeriod(int id, Period period)
        {
            if (id != period.Id) return BadRequest();

            _unitOfWork.PeriodRepository.Entry_Modified(period);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _unitOfWork.MissionRepository.GetById(id) == null)
                    return NotFound();

                else
                    return StatusCode(409, "Erreur de mise à jour des données.");
            }

            return NoContent();
        }

        // POST: api/Periods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<Period>> PostPeriod(Period period)
        {
            _unitOfWork.PeriodRepository.AddAsync(period);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return StatusCode(304, "Echec de la mise à jour des données.");
            }

            return CreatedAtAction("GetPeriod", new { id = period.Id }, period);
        }

        // DELETE: api/Periods/5
        [Authorize]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeletePeriod(int id)
        {
            Period period = await _unitOfWork.PeriodRepository.GetById(id);

            if (period == null) return NotFound();

            _unitOfWork.PeriodRepository.Remove(period);

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
