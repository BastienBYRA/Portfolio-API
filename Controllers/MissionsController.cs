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
    public class MissionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MissionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Missions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mission>>> GetMissions(int? page)
        {
            List<Mission> missions = await _unitOfWork.MissionRepository.GetAll(page, 10);

            if (!missions.Any()) return NotFound();

            return Ok(missions);
        }

        // GET: api/Missions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> GetMission(int id)
        {
            Mission mission = await _unitOfWork.MissionRepository.GetById(id);

            if (mission == null) return NotFound();

            return Ok(mission);
        }

        // PUT: api/Missions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutMission(int id, Mission mission)
        {
            if (id != mission.Id)
            {
                return BadRequest();
            }

            _unitOfWork.MissionRepository.Entry_Modified(mission);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _unitOfWork.MissionRepository.GetById(id) == null)
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

        // POST: api/Missions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<Mission>> PostMission(Mission mission)
        {
            _unitOfWork.MissionRepository.AddAsync(mission);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return StatusCode(304, "Echec de la mise à jour des données.");
            }

            return CreatedAtAction("GetMission", new { id = mission.Id }, mission);
        }

        // DELETE: api/Missions/5
        [Authorize]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteMission(int id)
        {
            Mission mission = await _unitOfWork.MissionRepository.GetById(id);

            if (mission == null) return NotFound();

            _unitOfWork.MissionRepository.Remove(mission);

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
