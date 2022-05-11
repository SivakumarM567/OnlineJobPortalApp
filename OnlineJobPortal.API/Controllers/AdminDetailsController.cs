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
    public class AdminDetailsController : ControllerBase
    {
        private AdminDetailsServices _adminDetailsServices;
        public AdminDetailsController(AdminDetailsServices adminDetailsServices)
        {
            _adminDetailsServices = adminDetailsServices;
        }
        [HttpPost("Save")]
        public IActionResult Save(AdminDetails adminDetails)
        {
            return Ok(_adminDetailsServices.Save(adminDetails));
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int AdminId)
        {
            return Ok(_adminDetailsServices.Delete(AdminId));
        }
        [HttpPatch("Update")]
        public IActionResult Update(AdminDetails adminDetails)
        {
            return Ok(_adminDetailsServices.Update(adminDetails));
        }
    }
}
