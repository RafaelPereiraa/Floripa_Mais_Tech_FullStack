using System.Collections.Generic;
using System.Linq;
using Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex.Repositories
{
    public class TeachersRepository : ITeachersRepository
    {
        private readonly Quiz _context;

        public TeachersRepository(Quiz context)
        {
            _context = context;
        }

        public IEnumerable<Teachers> GetAll()
        {
            return _context.Teachers.Include(t => t.User).ToList();
        }

        public Teachers GetById(int id)
        {
            return _context.Teachers.Include(t => t.User).FirstOrDefault(t => t.Id == id);
        }

        public Teachers Add(Teachers teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        public Teachers Update(Teachers teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
            _context.SaveChanges();
            return teacher;
        }

        public void Delete(int id)
        {
            var teacher = GetById(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
            }
        }
    }
}
