using System.Collections.Generic;
using System.Linq;
using Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex.Repositories
{
    public class DisciplinesRepository : IDisciplinesRepository
    {
        private readonly Quiz _context;

        public DisciplinesRepository(Quiz context)
        {
            _context = context;
        }

        public IEnumerable<Disciplines> GetAll()
        {
            return _context.Disciplines.ToList();
        }

        public Disciplines GetById(int id)
        {
            return _context.Disciplines.Find(id);
        }

        public Disciplines Add(Disciplines discipline)
        {
            _context.Disciplines.Add(discipline);
            _context.SaveChanges();
            return discipline;
        }

        public Disciplines Update(Disciplines discipline)
        {
            _context.Entry(discipline).State = EntityState.Modified;
            _context.SaveChanges();
            return discipline;
        }

        public void Delete(int id)
        {
            var discipline = _context.Disciplines.Find(id);
            if (discipline != null)
            {
                _context.Disciplines.Remove(discipline);
                _context.SaveChanges();
            }
        }
    }
}
