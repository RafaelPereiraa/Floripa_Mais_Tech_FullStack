
using Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex.Repositories
{
    public class AnswersRepository : IAnswersRepository
    {
        private readonly Quiz _context;

        public AnswersRepository(Quiz context)
        {
            _context = context;
        }

        public IEnumerable<Answers> GetAll()
        {
            return _context.Answers.Include(a => a.Question).Include(a => a.Student).ToList();
        }

        public Answers GetById(int id)
        {
            return _context.Answers.Include(a => a.Question).Include(a => a.Student).FirstOrDefault(a => a.Id == id);
        }

        public Answers Add(Answers answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }

        public Answers Update(Answers answer)
        {
            _context.Entry(answer).State = EntityState.Modified;
            _context.SaveChanges();
            return answer;
        }

        public void Delete(int id)
        {
            var answer = _context.Answers.Find(id);
            if (answer != null)
            {
                _context.Answers.Remove(answer);
                _context.SaveChanges();
            }
        }
    }
}
