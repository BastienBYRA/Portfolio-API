using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_API.Services;
using System.Collections;

namespace Portfolio_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperienceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

/*        [HttpGet]
        public IActionResult GetExperiences()
        {
            var res = _unitOfWork.ExperienceRepository.GetAll(1, 6);

            if (res != null && res.Any())
                return StatusCode(200, res.ToArray());
            else
                return NotFound();
        }*/
    }
}
