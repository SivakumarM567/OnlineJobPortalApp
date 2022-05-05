using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineJobPortal.BAL.Services;
using OnlineJobPortal.Entity;

namespace OnlineJobPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobseekersDetailsController : ControllerBase
    {
        private JobseekersDetailsServices _jobseekersDetailsServices;
        public JobseekersDetailsController(JobseekersDetailsServices jobseekersDetailsServices)
        {
            _jobseekersDetailsServices = jobseekersDetailsServices;
        }
        [HttpPost("Save")]
        public IActionResult Save(JobseekersDetails jobseekersDetails)
        {
            return Ok(_jobseekersDetailsServices.Save(jobseekersDetails));
        }
        [HttpGet("Get")]
        public IActionResult Get(int Experience)
        {
            return Ok(_jobseekersDetailsServices.Get(Experience));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int Id)
        {
            return Ok(_jobseekersDetailsServices.Delete(Id));
        }
        [HttpPatch("Update")]
        public IActionResult Update(JobseekersDetails jobseekersDetails)
        {
            return Ok(_jobseekersDetailsServices.Update(jobseekersDetails));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_jobseekersDetailsServices.GetAll());
        }
    }
}
