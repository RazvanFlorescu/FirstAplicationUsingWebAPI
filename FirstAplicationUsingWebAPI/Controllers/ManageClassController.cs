

using System.Collections.Generic;

using FirstAplicationUsingWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAplicationUsingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageClassController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            Class instance = Class.Instance;
            return instance.GetStudents();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            Class instance = Class.Instance;
            return instance.GetStudentById(id); ;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Student student)
        {
            Class instance = Class.Instance;
            instance.AddStudent(student);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Class instance = Class.Instance;
            instance.ExcludeAStudentById(id);

            return Ok();
        }
    }
}