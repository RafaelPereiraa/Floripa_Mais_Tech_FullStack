using System.Collections.Generic;
using Ex.Models;
using Ex.Repositories;

namespace Ex.Services
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsRepository _questionsRepository;

        public QuestionsService(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public IEnumerable<Questions> GetAll()
        {
            return _questionsRepository.GetAll();
        }

        public Questions GetById(int id)
        {
            return _questionsRepository.GetById(id);
        }

        public Questions Add(Questions question)
        {
            return _questionsRepository.Add(question);
        }

        public Questions Update(Questions question)
        {
            return _questionsRepository.Update(question);
        }

        public void Delete(int id)
        {
            _questionsRepository.Delete(id);
        }
    }
}