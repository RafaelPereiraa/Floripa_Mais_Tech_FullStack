using Ex.Models;

namespace Ex.Repositories
{
    public interface IAnswersRepository
    {
        IEnumerable<Answers> GetAll();
        Answers GetById(int id);
        Answers Add(Answers answer);
        Answers Update(Answers answer);
        void Delete(int id);
    }
}
