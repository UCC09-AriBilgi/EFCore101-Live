using Bogus;
using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;

namespace P02_CF_DbRelations.Data
{
    public class CityDG
    {
        Faker<City> fakerCity;

        public DbSet<City> Cities { get; set; } // City sınıfından Cities isimli bir tabloyu ifade ediyor.

        public CityDG()
        {
            fakerCity = new Faker<City>("tr"); // local ülke parametresi

            fakerCity.RuleFor(c => c.CityName, cd => cd.Address.City());
        }

        public void Generate(int count)
        {
            using var context = new CFDbRelationContext();

            for (int index = 1; index <= count; index++)
            {
                var city = fakerCity.Generate();

                Cities.Add(city); // City yaratıldı...
            }
        }
    }
}
