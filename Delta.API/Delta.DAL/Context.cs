using Delta.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta.DAL
{
   public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
        }
      public DbSet<Person> People { get; set; }
      public DbSet<Address> Addresses { get; set; }
    }
}
