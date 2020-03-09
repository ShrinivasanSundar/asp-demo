using Microsoft.AspNetCore.Mvc;
using Student.API.Domain.Services;
using Student.API.Services;
using System;

namespace Student.API.Controllers
{
    [Route("/api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;   
        }

        [HttpGet]
        public IActionResult HelloWorld()
        {
            Console.WriteLine(_studentService.hello());
            return Ok(new {message=_studentService.hello()});
        }
    }
}