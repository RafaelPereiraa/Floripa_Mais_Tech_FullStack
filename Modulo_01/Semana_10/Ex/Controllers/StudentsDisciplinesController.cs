using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ex.Models;
using Ex.Services;

namespace Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsDisciplinesController : ControllerBase
    {
        private readonly IStudentsDisciplinesService _service;

        public StudentsDisciplinesController(IStudentsDisciplinesService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StudentsDisciplines>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{studentId}/{disciplineId}")]
        public ActionResult<StudentsDisciplines> GetById(int studentId, int disciplineId)
        {
            var result = _service.GetById(studentId, disciplineId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public ActionResult<StudentsDisciplines> Add([FromBody] StudentsDisciplines studentsDisciplines)
        {
            var created = _service.Add(studentsDisciplines);
            return CreatedAtAction(nameof(GetById), new { studentId = created.StudentId, disciplineId = created.DisciplineId }, created);
        }

        [HttpPut("{studentId}/{disciplineId}")]
        public ActionResult<StudentsDisciplines> Update(int studentId, int disciplineId, [FromBody] StudentsDisciplines studentsDisciplines)
        {
            if (studentId != studentsDisciplines.StudentId || disciplineId != studentsDisciplines.DisciplineId)
            {
                return BadRequest();
            }

            var updated = _service.Update(studentsDisciplines);
            if (updated == null)
            {
                return NotFound();
            }

            return Ok(updated);
        }

        [HttpDelete("{studentId}/{disciplineId}")]
        public IActionResult Delete(int studentId, int disciplineId)
        {
            if (!_service.Exists(studentId, disciplineId))
            {
                return NotFound();
            }

            _service.Delete(studentId, disciplineId);
            return NoContent();
        }
    }
}
