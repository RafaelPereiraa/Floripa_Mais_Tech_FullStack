using System.Collections.Generic;
using Ex.Models;
using Ex.Repositories;

namespace Ex.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsService(IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        public IEnumerable<Students> GetAll()
        {
            return _studentsRepository.GetAll();
        }

        public Students GetById(int id)
        {
            return _studentsRepository.GetById(id);
        }

        public Students Add(Students student)
        {
            return _studentsRepository.Add(student);
        }

        public Students Update(Students student)
        {
            return _studentsRepository.Update(student);
        }

        public void Delete(int id)
        {
            _studentsRepository.Delete(id);
        }
    }
}
