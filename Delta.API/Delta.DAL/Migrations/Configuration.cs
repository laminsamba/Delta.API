using Delta.BLL;

namespace Delta.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Delta.DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Delta.DAL.Context context)
        {
            context.Addresses.AddOrUpdate(
                    new Address() { AddressId = 1, HouseNo = "10", Street = "Tord Road", Town = "Barnet", Country = "UK"}, 
                    new Address() { AddressId = 2, HouseNo = "11", Street = "Tord Road", Town = "Barnet", Country = "UK"}, 
                    new Address() { AddressId = 3, HouseNo = "12", Street = "Tord Road", Town = "Barnet", Country = "UK"}, 
                    new Address() { AddressId = 4, HouseNo = "13", Street = "Tord Road", Town = "Barnet", Country = "UK"}, 
                    new Address() { AddressId = 5, HouseNo = "14", Street = "Tord Road", Town = "Barnet", Country = "UK"} 
                );

            context.People.AddOrUpdate(
                    new Person() { PersonId = 1, FirstName = "Dodou", LastName = "Samba", AddressId = 1},
                    new Person() { PersonId = 2, FirstName = "Dodou", LastName = "Samba", AddressId = 2},
                    new Person() { PersonId = 3, FirstName = "Dodou", LastName = "Samba", AddressId = 3},
                    new Person() { PersonId = 4, FirstName = "Dodou", LastName = "Samba", AddressId = 4},
                    new Person() { PersonId = 5, FirstName = "Dodou", LastName = "Samba", AddressId = 5}
                );
        }
    }
}
