using System.Collections.Generic;
using System.Linq;
using Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex.Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly Quiz _context;

        public QuestionsRepository(Quiz context)
        {
            _context = context;
        }

        public IEnumerable<Questions> GetAll()
        {
            return _context.Questions;
        }

        public Questions GetById(int id)
        {
            return _context.Questions.Find(id);
        }

        public Questions Add(Questions question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question;
        }

        public Questions Update(Questions question)
        {
            _context.Entry(question).State = EntityState.Modified;
            _context.SaveChanges();
            return question;
        }

        public void Delete(int id)
        {
            var question = _context.Questions.Find(id);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }
    }
}