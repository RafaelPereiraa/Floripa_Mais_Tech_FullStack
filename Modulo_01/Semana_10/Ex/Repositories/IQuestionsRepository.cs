using System.Collections.Generic;
using Ex.Models;

namespace Ex.Repositories
{
    public interface IQuestionsRepository
    {
        IEnumerable<Questions> GetAll();
        Questions GetById(int id);
        Questions Add(Questions question);
        Questions Update(Questions question);
        void Delete(int id);
    }
}