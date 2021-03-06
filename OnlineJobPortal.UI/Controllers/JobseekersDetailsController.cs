using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using OnlineJobPortal.Entity;
using System.Text;
using Newtonsoft.Json;

namespace OnlineJobPortal.UI.Controllers
{
    public class JobseekersDetailsController : Controller
    {
        private IConfiguration _configuration;
        public JobseekersDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(JobseekersDetails jobseekersDetails)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(jobseekersDetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "JobseekersDetails/Save";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Jobseeker details saved successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public IActionResult Get()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Get(JobseekersDetails jobseekersDetails)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(jobseekersDetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "JobseekersDetails/Get";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Jobseeker details Fetched successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(JobseekersDetails jobseekersDetails)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(jobseekersDetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "JobseekersDetails/Delete";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Jobseeker details Deleted successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPatch]
        public async Task<IActionResult> Update(JobseekersDetails jobseekersDetails)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(jobseekersDetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "JobseekersDetails/Update";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Jobseeker details Updated successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
