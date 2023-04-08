using System.Collections.Generic;
using Ex.Models;

namespace Ex.Repositories
{
    public interface IQuizsRepository
    {
        IEnumerable<Quizs> GetAll();
        Quizs GetById(int id);
        Quizs Add(Quizs quiz);
        Quizs Update(Quizs quiz);
        void Delete(int id);
    }
}