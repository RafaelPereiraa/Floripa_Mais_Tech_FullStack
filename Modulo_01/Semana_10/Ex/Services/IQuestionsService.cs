using System.Collections.Generic;
using Ex.Models;

namespace Ex.Services
{
    public interface IQuestionsService
    {
        IEnumerable<Questions> GetAll();
        Questions GetById(int id);
        Questions Add(Questions question);
        Questions Update(Questions question);
        void Delete(int id);
    }
}