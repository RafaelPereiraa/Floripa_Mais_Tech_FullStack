using System.Collections.Generic;
using Ex.Models;
using Ex.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        // GET: api/Students
        [HttpGet]
        public IEnumerable<Students> GetStudents()
        {
            return _studentsService.GetAll();
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public ActionResult<Students> GetStudent(int id)
        {
            var student = _studentsService.GetById(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        // PUT: api/Students/5
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Students student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            _studentsService.Update(student);

            return NoContent();
        }

        // POST: api/Students
        [HttpPost]
        public ActionResult<Students> CreateStudent(Students student)
        {
            _studentsService.Add(student);

            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _studentsService.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            _studentsService.Delete(id);

            return NoContent();
        }
    }
}
