using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializationController : ControllerBase
    {
        private readonly SpecializationRepository specializationRepository;
        public SpecializationController(SpecializationRepository sp)
        {
            specializationRepository = sp;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var data = specializationRepository.GetAllSpecializations();
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public ActionResult Post(Specialization specialization)
        {
            var data = specializationRepository.AddSpecialization(specialization);
            if (data == true)
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }
        [HttpPut]
        public ActionResult Put(Specialization specialization)
        {
            var data = specializationRepository.UpdateSpecialization(specialization);
            if (data == true)
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }
        [HttpDelete]
        public ActionResult Delete(string code)
        {
            var data = specializationRepository.DeleteSpecialization(code);
            if (data == true)
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }
        [HttpGet("{code}")]
        public IActionResult Get(string code)
        {
            var data = specializationRepository.GetSpecializationByCode(code);
            if (data == null)
            {
                return NotFound("No doctor with SpecializationCode: " + code);
            }
            return Ok(data);
        }
    }
}
