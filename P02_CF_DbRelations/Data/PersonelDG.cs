using Bogus;
using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;

namespace P02_CF_DbRelations.Data
{
    public class PersonelDG
    {
        Faker<Personel> fakerPersonel;

        public DbSet<Personel> Personels { get; set; } // City sınıfından Cities isimli bir tabloyu ifade ediyor.

        public PersonelDG()
        {
            fakerPersonel = new Faker<Personel>("tr"); // tr --> local ülke parametresi

            fakerPersonel.RuleFor(c => c.FName, cd => cd.Person.FirstName);
            fakerPersonel.RuleFor(c => c.LName, cd => cd.Person.LastName);
            fakerPersonel.RuleFor(c => c.Cities.CityID, cd => cd.Random.Number(1, 81));
            fakerPersonel.RuleFor(c => c.Departments.DepartmentID, cd => cd.Random.Number(1,10));
        }

        public void Generate(int count)
        {
            using var context = new CFDbRelationContext();

            for (int index = 1; index <= count; index++)
            {
                var personel = fakerPersonel.Generate();

                Personels.Add(personel); // Personel yaratıldı...
            }
        }
    }
}
