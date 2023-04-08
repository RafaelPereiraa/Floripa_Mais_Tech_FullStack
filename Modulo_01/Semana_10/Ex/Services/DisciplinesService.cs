using System.Collections.Generic;
using Ex.Models;
using Ex.Repositories;

namespace Ex.Services
{
    public class DisciplinesService : IDisciplinesService
    {
        private readonly IDisciplinesRepository _disciplinesRepository;

        public DisciplinesService(IDisciplinesRepository disciplinesRepository)
        {
            _disciplinesRepository = disciplinesRepository;
        }

        public IEnumerable<Disciplines> GetAll()
        {
            return _disciplinesRepository.GetAll();
        }

        public Disciplines GetById(int id)
        {
            return _disciplinesRepository.GetById(id);
        }

        public Disciplines Add(Disciplines discipline)
        {
            return _disciplinesRepository.Add(discipline);
        }

        public Disciplines Update(Disciplines discipline)
        {
            return _disciplinesRepository.Update(discipline);
        }

        public void Delete(int id)
        {
            _disciplinesRepository.Delete(id);
        }
    }
}
