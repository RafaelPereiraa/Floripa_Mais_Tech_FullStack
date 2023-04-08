using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ex.Models;
using Ex.Services;

namespace Ex.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisciplinesController : ControllerBase
    {
        private readonly IDisciplinesService _disciplinesService;

        public DisciplinesController(IDisciplinesService disciplinesService)
        {
            _disciplinesService = disciplinesService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Disciplines>> GetAll()
        {
            return Ok(_disciplinesService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Disciplines> GetById(int id)
        {
            var discipline = _disciplinesService.GetById(id);
            if (discipline == null)
            {
                return NotFound();
            }

            return Ok(discipline);
        }

        [HttpPost]
        public ActionResult<Disciplines> Add(Disciplines discipline)
        {
            var createdDiscipline = _disciplinesService.Add(discipline);
            return CreatedAtAction(nameof(GetById), new { id = createdDiscipline.Id }, createdDiscipline);
        }

        [HttpPut("{id}")]
        public ActionResult<Disciplines> Update(int id, Disciplines discipline)
        {
            if (id != discipline.Id)
            {
                return BadRequest();
            }

            var updatedDiscipline = _disciplinesService.Update(discipline);
            if (updatedDiscipline == null)
            {
                return NotFound();
            }

            return Ok(updatedDiscipline);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var discipline = _disciplinesService.GetById(id);
            if (discipline == null)
            {
                return NotFound();
            }

            _disciplinesService.Delete(id);
            return NoContent();
        }
    }
}
