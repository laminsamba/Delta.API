using System.Collections.Generic;
using Delta.BLL;

namespace Delta.DAL.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons();
    }
}