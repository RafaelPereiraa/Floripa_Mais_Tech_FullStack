using System.Collections.Generic;
using Ex.Models;

namespace Ex.Repositories
{
    public interface IStudentsDisciplinesRepository
    {
        IEnumerable<StudentsDisciplines> GetAll();
        StudentsDisciplines GetById(int studentId, int disciplineId);
        StudentsDisciplines Add(StudentsDisciplines studentsDisciplines);
        StudentsDisciplines Update(StudentsDisciplines studentsDisciplines);
        void Delete(int studentId, int disciplineId);
        bool Exists(int studentId, int disciplineId);
    }
}
