using System.Collections.Generic;
using Ex.Models;
using Ex.Repositories;

namespace Ex.Services
{
    public class QuizsService : IQuizsService
    {
        private readonly IQuizsRepository _quizsRepository;

        public QuizsService(IQuizsRepository quizsRepository)
        {
            _quizsRepository = quizsRepository;
        }

        public IEnumerable<Quizs> GetAll()
        {
            return _quizsRepository.GetAll();
        }

        public Quizs GetById(int id)
        {
            return _quizsRepository.GetById(id);
        }

        public Quizs Add(Quizs quiz)
        {
            return _quizsRepository.Add(quiz);
        }

        public Quizs Update(Quizs quiz)
        {
            return _quizsRepository.Update(quiz);
        }

        public void Delete(int id)
        {
            _quizsRepository.Delete(id);
        }
    }
}