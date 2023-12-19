using Bogus;
using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;

namespace P02_CF_DbRelations.Data
{
    public class ProductDG
    {
        Faker<Product> fakerProduct;

        public DbSet<Product> Products { get; set; } // City sınıfından Cities isimli bir tabloyu ifade ediyor.

        public ProductDG()
        {
            fakerProduct = new Faker<Product>("tr"); // tr --> local ülke parametresi

            fakerProduct.RuleFor(c => c.ProductName, cd => cd.Commerce.ProductName());
            fakerProduct.RuleFor(c => c.Categories.CategoryID, cd => cd.Random.Number(1,10));
        }

        public void Generate(int count)
        {
            using var context = new CFDbRelationContext();

            for (int index = 1; index <= count; index++)
            {
                var product = fakerProduct.Generate();

                Products.Add(product); // Product yaratıldı...
            }
        }
    }
}
