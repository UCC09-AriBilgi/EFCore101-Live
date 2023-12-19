using Bogus;
using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;

namespace P02_CF_DbRelations.Data
{
    public class OrderDG
    {
        Faker<Order> fakerOrder;

        public DbSet<Order> Orders { get; set; } // City sınıfından Cities isimli bir tabloyu ifade ediyor.

        public OrderDG()
        {
            fakerOrder = new Faker<Order>(); // tr --> local ülke parametresi

            fakerOrder.RuleFor(c => c.Personels.PersonelID, cd => cd.Random.Number(10));
            fakerOrder.RuleFor(c => c.Products.ProductId, cd => cd.Random.Number(10));
        }

        public void Generate(int count)
        {
            using var context = new CFDbRelationContext();

            for (int index = 1; index <= count; index++)
            {
                var order = fakerOrder.Generate();

                Orders.Add(order); // Order yaratıldı...
            }
        }
    }
}
