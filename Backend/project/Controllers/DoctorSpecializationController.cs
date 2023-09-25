﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorSpecializationController : ControllerBase
    {
        private readonly DoctorSpecializationRepository doctorSpecializationRepository;
        public DoctorSpecializationController(DoctorSpecializationRepository dr)
        {
            doctorSpecializationRepository = dr;
        }
        [HttpGet("{SpecializationCode}")]
        public ActionResult Get(string SpecializationCode)
        {
           var data= doctorSpecializationRepository.GetDoctorsBySpecializations(SpecializationCode);
            if (data !=null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
