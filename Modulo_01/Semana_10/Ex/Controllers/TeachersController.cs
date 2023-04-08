using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ex.Models;
using Ex.Services;

namespace Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeachersService _teachersService;

        public TeachersController(ITeachersService teachersService)
        {
            _teachersService = teachersService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Teachers>> GetAll()
        {
            return Ok(_teachersService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Teachers> GetById(int id)
        {
            var teacher = _teachersService.GetById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }

        [HttpPost]
        public ActionResult<Teachers> Add(Teachers teacher)
        {
            var newTeacher = _teachersService.Add(teacher);
            return CreatedAtAction(nameof(GetById), new { id = newTeacher.Id }, newTeacher);
        }

        [HttpPut("{id}")]
        public ActionResult<Teachers> Update(int id, Teachers teacher)
        {
            if (id != teacher.Id)
            {
                return BadRequest();
            }

            var updatedTeacher = _teachersService.Update(teacher);
            if (updatedTeacher == null)
            {
                return NotFound();
            }

            return Ok(updatedTeacher);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var teacher = _teachersService.GetById(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _teachersService.Delete(id);
            return NoContent();
        }
    }
}
