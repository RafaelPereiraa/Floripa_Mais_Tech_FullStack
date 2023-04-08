using System.Collections.Generic;
using Ex.Models;
using Ex.Repositories;

namespace Ex.Services
{
    public class StudentsDisciplinesService : IStudentsDisciplinesService
    {
        private readonly IStudentsDisciplinesRepository _studentsDisciplinesRepository;

        public StudentsDisciplinesService(IStudentsDisciplinesRepository studentsDisciplinesRepository)
        {
            _studentsDisciplinesRepository = studentsDisciplinesRepository;
        }

        public IEnumerable<StudentsDisciplines> GetAll()
        {
            return _studentsDisciplinesRepository.GetAll();
        }

        public StudentsDisciplines GetById(int studentId, int disciplineId)
        {
            return _studentsDisciplinesRepository.GetById(studentId, disciplineId);
        }

        public StudentsDisciplines Add(StudentsDisciplines studentsDisciplines)
        {
            return _studentsDisciplinesRepository.Add(studentsDisciplines);
        }

        public StudentsDisciplines Update(StudentsDisciplines studentsDisciplines)
        {
            return _studentsDisciplinesRepository.Update(studentsDisciplines);
        }

        public void Delete(int studentId, int disciplineId)
        {
            _studentsDisciplinesRepository.Delete(studentId, disciplineId);
        }

        public bool Exists(int studentId, int disciplineId)
        {
            return _studentsDisciplinesRepository.Exists(studentId, disciplineId);
        }
    }
}
