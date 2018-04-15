using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Delta.BLL;
using Delta.DAL.Interfaces;

namespace Delta.DAL.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly Context _context;
        public PersonRepository(Context context)
        {
            _context = context;
        }
        public IEnumerable<Person> GetAllPersons()
        {
            return _context.People.Include("Address").ToList();
        }
    }
}