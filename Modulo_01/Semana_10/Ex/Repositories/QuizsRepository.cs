using System.Collections.Generic;
using System.Linq;
using Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex.Repositories
{
    public class QuizsRepository : IQuizsRepository
    {
        private readonly Quiz _context;

        public QuizsRepository(Quiz context)
        {
            _context = context;
        }

        public IEnumerable<Quizs> GetAll()
        {
            return _context.Quizs.ToList();
        }

        public Quizs GetById(int id)
        {
            return _context.Quizs.Find(id);
        }

        public Quizs Add(Quizs quiz)
        {
            _context.Quizs.Add(quiz);
            _context.SaveChanges();
            return quiz;
        }

        public Quizs Update(Quizs quiz)
        {
            _context.Entry(quiz).State = EntityState.Modified;
            _context.SaveChanges();
            return quiz;
        }

        public void Delete(int id)
        {
            var quiz = _context.Quizs.Find(id);
            if (quiz != null)
            {
                _context.Quizs.Remove(quiz);
                _context.SaveChanges();
            }
        }
    }
}