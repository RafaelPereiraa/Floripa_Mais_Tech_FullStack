using System.Collections.Generic;
using System.Linq;
using Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex.Repositories
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly Quiz _context;

        public StudentsRepository(Quiz context)
        {
            _context = context;
        }

        public IEnumerable<Students> GetAll()
        {
            return _context.Students.Include(s => s.User);
        }

        public Students GetById(int id)
        {
            return _context.Students.Include(s => s.User).SingleOrDefault(s => s.Id == id);
        }

        public Students Add(Students student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Students Update(Students student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
            return student;
        }

        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
