using Bogus;
using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;


namespace P02_CF_DbRelations.Data
{
    // Category Fake Data Generator

    public class CategoryDG
    {
        Faker<Category> fakerCategory;

        public DbSet<Category> Categories { get; set; } // Category sınıfından Categories isimli bir tabloyu ifade ediyor.

        public CategoryDG() 
        {
            fakerCategory = new Faker<Category>();

            fakerCategory.RuleFor(c => c.CategoryName, cd => cd.Commerce.Categories(1)[0]);
        } 

        public void Generate(int count)
        {
            using var context = new CFDbRelationContext();

            for (int index = 1; index <= count; index++)
            {
                var category = fakerCategory.Generate();

                Categories.Add(category); // Kategori yaratıldı...
            }
        }
    }
}
