using Ex.Models;

namespace Ex.Services
{
    public interface IAnswersService
    {
        IEnumerable<Answers> GetAllAnswers();
        Answers GetAnswerById(int id);
        Answers CreateAnswer(Answers answer);
        Answers UpdateAnswer(Answers answer);
        void DeleteAnswer(int id);
    }
}
