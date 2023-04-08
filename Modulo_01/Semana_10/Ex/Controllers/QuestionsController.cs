using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ex.Models;
using Ex.Services;

namespace Ex.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsService _questionsService;

        public QuestionsController(IQuestionsService questionsService)
        {
            _questionsService = questionsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Questions>> GetAll()
        {
            return Ok(_questionsService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Questions> GetById(int id)
        {
            var question = _questionsService.GetById(id);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }

        [HttpPost]
        public ActionResult<Questions> Add(Questions question)
        {
            _questionsService.Add(question);
            return CreatedAtAction(nameof(GetById), new { id = question.Id }, question);
        }

        [HttpPut("{id}")]
        public ActionResult<Questions> Update(int id, Questions question)
        {
            if (id != question.Id)
            {
                return BadRequest();
            }

            var updatedQuestion = _questionsService.Update(question);
            if (updatedQuestion == null)
            {
                return NotFound();
            }
            return Ok(updatedQuestion);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var question = _questionsService.GetById(id);
            if (question == null)
            {
                return NotFound();
            }
            _questionsService.Delete(id);
            return NoContent();
        }
    }
}
