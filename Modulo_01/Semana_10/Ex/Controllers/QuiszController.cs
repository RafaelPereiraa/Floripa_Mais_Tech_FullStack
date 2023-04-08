using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ex.Models;
using Ex.Services;

namespace Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizsController : ControllerBase
    {
        private readonly IQuizsService _service;

        public QuizsController(IQuizsService service)
        {
            _service = service;
        }

        // GET: api/Quizs
        [HttpGet]
        public ActionResult<IEnumerable<Quizs>> GetQuizs()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/Quizs/5
        [HttpGet("{id}")]
        public ActionResult<Quizs> GetQuizs(int id)
        {
            var quiz = _service.GetById(id);

            if (quiz == null)
            {
                return NotFound();
            }

            return Ok(quiz);
        }

        // PUT: api/Quizs/5
        [HttpPut("{id}")]
        public IActionResult UpdateQuiz(int id, Quizs quiz)
        {
            if (id != quiz.Id)
            {
                return BadRequest();
            }

            _service.Update(quiz);

            return NoContent();
        }

        // POST: api/Quizs
        [HttpPost]
        public ActionResult<Quizs> CreateQuiz(Quizs quiz)
        {
            _service.Add(quiz);

            return CreatedAtAction(nameof(GetQuizs), new { id = quiz.Id }, quiz);
        }

        // DELETE: api/Quizs/5
        [HttpDelete("{id}")]
        public IActionResult DeleteQuiz(int id)
        {
            var quiz = _service.GetById(id);
            if (quiz == null)
            {
                return NotFound();
            }

            _service.Delete(id);

            return NoContent();
        }
    }
}
