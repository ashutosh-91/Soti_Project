using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurgeryController : ControllerBase
    {
        private readonly SurgeryRepository surgeryRepository;
        public SurgeryController(SurgeryRepository sr) {
            surgeryRepository = sr;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data= surgeryRepository.GetAllSurgeryTypeForToday();
            if(data!=null)return Ok(data);
            else return NotFound();
        }

        [HttpPut]
        public IActionResult Put(ISurgery surgery)
        {
            var data=surgeryRepository.UpdateSurgery(surgery);
            return Ok(data);

        }

        [HttpPost]
        public bool Post(ISurgery surgery)
        {
            var data=surgeryRepository.AddSurgery(surgery);
            if (data) return true;
            else return false;
        }
    }
}
