using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserInformation.Models;
using UserInformation.Services;

namespace UserInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentServices _studentServices;
        public StudentController(StudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var user = _studentServices.GetAll();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id) {
            var user=_studentServices.GetById(id);
            if(user == null)
            {
                return NotFound();

            }
            return Ok(user) ;
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _studentServices.Add(student);
            
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentServices.Delete(id);    
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Student student)
        {
            Student result=_studentServices.Update(student);
            return (IActionResult)result;
            
        }


    }
}
