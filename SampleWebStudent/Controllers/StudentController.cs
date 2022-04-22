using Microsoft.AspNetCore.Mvc;
using SampleWebStudent.Services;
using SampleWebStudent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleWebStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studservice;
        private object stud;

        public StudentController(IStudentServices studservice)
        {
            _studservice = studservice;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Product/GetProducts")]
        public IActionResult GetStudent(Repositories.Student stud)
        {
            return new ObjectResult(_studservice.AddStudent(stud));
        }
        [HttpGet]
        [Route("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
           return new ObjectResult(_studservice.DeleteStudent);
        }
    }
}
