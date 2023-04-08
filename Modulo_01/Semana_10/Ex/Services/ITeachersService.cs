using System.Collections.Generic;
using Ex.Models;

namespace Ex.Services
{
    public interface ITeachersService
    {
        IEnumerable<Teachers> GetAll();
        Teachers GetById(int id);
        Teachers Add(Teachers teacher);
        Teachers Update(Teachers teacher);
        void Delete(int id);
    }
}
