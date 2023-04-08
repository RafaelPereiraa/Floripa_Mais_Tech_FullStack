using System.Collections.Generic;
using Ex.Models;

namespace Ex.Services
{
    public interface IStudentsService
    {
        IEnumerable<Students> GetAll();
        Students GetById(int id);
        Students Add(Students student);
        Students Update(Students student);
        void Delete(int id);
    }
}
