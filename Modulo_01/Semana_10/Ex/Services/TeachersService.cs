using System.Collections.Generic;
using Ex.Models;
using Ex.Repositories;

namespace Ex.Services
{
    public class TeachersService : ITeachersService
    {
        private readonly ITeachersRepository _teachersRepository;

        public TeachersService(ITeachersRepository teachersRepository)
        {
            _teachersRepository = teachersRepository;
        }

        public IEnumerable<Teachers> GetAll()
        {
            return _teachersRepository.GetAll();
        }

        public Teachers GetById(int id)
        {
            return _teachersRepository.GetById(id);
        }

        public Teachers Add(Teachers teacher)
        {
            return _teachersRepository.Add(teacher);
        }

        public Teachers Update(Teachers teacher)
        {
            return _teachersRepository.Update(teacher);
        }

        public void Delete(int id)
        {
            _teachersRepository.Delete(id);
        }
    }
}
