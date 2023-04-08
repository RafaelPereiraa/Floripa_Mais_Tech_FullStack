using System.Collections.Generic;
using System.Linq;
using Ex.Models;
using Microsoft.EntityFrameworkCore;

namespace Ex.Repositories
{
    public class StudentsDisciplinesRepository : IStudentsDisciplinesRepository
    {
        private readonly Quiz _context;

        public StudentsDisciplinesRepository(Quiz context)
        {
            _context = context;
        }

        public IEnumerable<StudentsDisciplines> GetAll()
        {
            return _context.StudentsDisciplines.Include(sd => sd.Student).Include(sd => sd.Discipline).ToList();
        }

        public StudentsDisciplines GetById(int studentId, int disciplineId)
        {
            return _context.StudentsDisciplines.Include(sd => sd.Student).Include(sd => sd.Discipline)
                .FirstOrDefault(sd => sd.StudentId == studentId && sd.DisciplineId == disciplineId);
        }

        public StudentsDisciplines Add(StudentsDisciplines studentsDisciplines)
        {
            _context.StudentsDisciplines.Add(studentsDisciplines);
            _context.SaveChanges();
            return studentsDisciplines;
        }

        public StudentsDisciplines Update(StudentsDisciplines studentsDisciplines)
        {
            _context.Entry(studentsDisciplines).State = EntityState.Modified;
            _context.SaveChanges();
            return studentsDisciplines;
        }

        public void Delete(int studentId, int disciplineId)
        {
            var studentsDisciplines = _context.StudentsDisciplines.Find(studentId, disciplineId);
            if (studentsDisciplines != null)
            {
                _context.StudentsDisciplines.Remove(studentsDisciplines);
                _context.SaveChanges();
            }
        }

        public bool Exists(int studentId, int disciplineId)
        {
            return _context.StudentsDisciplines.Any(sd => sd.StudentId == studentId && sd.DisciplineId == disciplineId);
        }
    }
}
