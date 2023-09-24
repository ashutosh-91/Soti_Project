using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorRepository doctorRepository;
        public DoctorController(DoctorRepository dr)
        {
            doctorRepository = dr;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var data = doctorRepository.GetAllDoctors();
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
        public ActionResult Post(IDoctor d)
        {
            var data = doctorRepository.AddDoctor(d);
            if (data ==true)
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }
        [HttpPut]
        public ActionResult Put(IDoctor d)
        {
            var data = doctorRepository.UpdateDoctorDetails(d);
            if (data ==true)
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var data = doctorRepository.DeleteDoctor(id);
            if (data == true)
            {
                return Ok(true);
            }
            else
            {
                return NotFound(false);
            }
        }
    }
}
