using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_API.Services;

namespace Portfolio_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LangageController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public LangageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetLangages(int? page)
        {
            var res = _unitOfWork.LangageRepository.GetAll(page, 8);

            if (res != null && res.Any())
                return StatusCode(200, res.ToArray());
            else
                return NotFound();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetLangageById(int id)
        {
            if(id == 0) return NotFound();

            var res = _unitOfWork.LangageRepository.GetById(id);

            if (res != null)
                return StatusCode(200, res);
            else
                return NotFound();
        }
    }
}
