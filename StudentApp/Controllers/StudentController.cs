using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManagerService _studentService;
        public StudentController(IStudentManagerService studentManager)
        {
            _studentService = studentManager;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentService.GetAllStudents();
        }



        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            _studentService.AddStudent(value);
        }




    }
}
