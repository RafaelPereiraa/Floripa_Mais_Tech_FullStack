using System.Collections.Generic;
using Ex.Models;

namespace Ex.Services
{
    public interface IQuizsService
    {
        IEnumerable<Quizs> GetAll();
        Quizs GetById(int id);
        Quizs Add(Quizs quiz);
        Quizs Update(Quizs quiz);
        void Delete(int id);
    }
}