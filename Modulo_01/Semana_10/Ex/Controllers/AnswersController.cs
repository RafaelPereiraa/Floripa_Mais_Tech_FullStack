
using Microsoft.AspNetCore.Mvc;
using Ex.Models;
using Ex.Services;

namespace Ex.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnswersController : ControllerBase
    {
        private readonly IAnswersService _answersService;

        public AnswersController(IAnswersService answersService)
        {
            _answersService = answersService;
        }

        // GET: api/Answers
        [HttpGet]
        public IEnumerable<Answers> GetAnswers()
        {
            return _answersService.GetAllAnswers(); ;
        }

        // GET: api/Answers/5
        [HttpGet("{id}")]
        public ActionResult<Answers> GetAnswer(int id)
        {
            var answer = _answersService.GetAnswerById(id);

            if (answer == null)
            {
                return NotFound();
            }

            return answer;
        }

        // PUT: api/Answers/5
        [HttpPut("{id}")]
        public IActionResult PutAnswer(int id, Answers answer)
        {
            if (id != answer.Id)
            {
                return BadRequest();
            }

            _answersService.UpdateAnswer(answer);

            return NoContent();
        }

        // POST: api/Answers
        [HttpPost]
        public ActionResult<Answers> PostAnswer(Answers answer)
        {
            _answersService.CreateAnswer(answer);

            return CreatedAtAction(nameof(GetAnswer), new { id = answer.Id }, answer);
        }

        // DELETE: api/Answers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAnswer(int id)
        {
            var answer = _answersService.GetAnswerById(id);
            if (answer == null)
            {
                return NotFound();
            }

            _answersService.DeleteAnswer(id);

            return NoContent();
        }
    }
}