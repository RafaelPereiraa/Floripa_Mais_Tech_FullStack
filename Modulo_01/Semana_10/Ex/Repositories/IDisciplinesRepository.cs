using System.Collections.Generic;
using Ex.Models;

namespace Ex.Repositories
{
    public interface IDisciplinesRepository
    {
        IEnumerable<Disciplines> GetAll();
        Disciplines GetById(int id);
        Disciplines Add(Disciplines discipline);
        Disciplines Update(Disciplines discipline);
        void Delete(int id);
    }
}
