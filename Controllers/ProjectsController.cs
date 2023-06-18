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
    public class ProjectsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Projects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects(int? page)
        {
            List<Project> projects = await _unitOfWork.ProjectRepository.GetAll(page, 6);

            if (!projects.Any()) return NotFound();

            return Ok(projects);
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProject(int id)
        {
            Project project = await _unitOfWork.ProjectRepository.GetById(id);

            if (project == null) return NotFound();

            return Ok(project);
        }

        // PUT: api/Projects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}/edit")]
        public async Task<IActionResult> PutProject(int id, Project project)
        {
            if (id != project.Id) return BadRequest();

            _unitOfWork.ProjectRepository.Entry_Modified(project);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _unitOfWork.ProjectRepository.GetById(project) == null)
                    return NotFound();

                else
                    return StatusCode(409, "Erreur de mise à jour des données.");
            }

            return NoContent();
        }

        // POST: api/Projects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<Project>> PostProject(Project project)
        {
            _unitOfWork.ProjectRepository.AddAsync(project);

            try
            {
                await _unitOfWork.SaveAsync();
            }
            catch (Exception)
            {
                return StatusCode(304, "Echec de la mise à jour des données.");
            }

            return CreatedAtAction("GetProject", new { id = project.Id }, project);
        }

        // DELETE: api/Projects/5
        [Authorize]
        [HttpDelete("{id}/delete")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            Project project = await _unitOfWork.ProjectRepository.GetById(id);

            if (project == null) return NotFound();

            _unitOfWork.ProjectRepository.Remove(project);

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
