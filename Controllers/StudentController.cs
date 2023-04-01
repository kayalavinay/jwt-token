//Implementation JWT Authentication in Web API Using .Net 6.0, Asp.Net Core
using JWTToken.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTToken.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly Istudent _istudent;

        public StudentController(Istudent istudent)
        {
            _istudent = istudent;
        }

        [HttpGet]
        public IActionResult getstudents()
        {
            return Ok(_istudent.GetStudents());
        } 
    }
}   
