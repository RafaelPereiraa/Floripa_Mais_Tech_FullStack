using Ex.Models;
using Ex.Repositories;

namespace Ex.Services
{
    public class AnswersService : IAnswersService
    {
        private readonly IAnswersRepository _answersRepository;

        public AnswersService(IAnswersRepository answersRepository)
        {
            _answersRepository = answersRepository;
        }

        public IEnumerable<Answers> GetAllAnswers()
        {
            return _answersRepository.GetAll();
        }

        public Answers GetAnswerById(int id)
        {
            return _answersRepository.GetById(id);
        }

        public Answers CreateAnswer(Answers answer)
        {
            return _answersRepository.Add(answer);
        }

        public Answers UpdateAnswer(Answers answer)
        {
            return _answersRepository.Update(answer);
        }

        public void DeleteAnswer(int id)
        {
            _answersRepository.Delete(id);
        }
    }
}
