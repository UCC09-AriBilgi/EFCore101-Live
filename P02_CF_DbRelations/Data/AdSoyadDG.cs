using Bogus;
using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;

namespace P02_CF_DbRelations.Data
{
    public class AdSoyadDG
    {
        Faker<AdSoyad> fakerAdSoyad;

        //public DbSet<AdSoyad> AdSoyads { get; set; } // City sınıfından Cities isimli bir tabloyu ifade ediyor.
        public List<AdSoyad> AdSoyads { get; set; } // City sınıfından Cities isimli bir tabloyu ifade ediyor.

        public AdSoyadDG()
        {
            fakerAdSoyad = new Faker<AdSoyad>("tr"); // tr --> local ülke parametresi

            fakerAdSoyad.RuleFor(c => c.Id, cd => cd.Random.Int(1,10));
            fakerAdSoyad.RuleFor(c => c.Ad, cd => cd.Person.FirstName);
            fakerAdSoyad.RuleFor(c => c.Soyad, cd => cd.Person.LastName);
        }

        public void Generate(int count)
        {
            using var context = new CFDbRelationContext();

            for (int index = 1; index <= count; index++)
            {
                var adsoyad = fakerAdSoyad.Generate();

                AdSoyads.Add(adsoyad); // Product yaratıldı...
            }
        }
    }
}
