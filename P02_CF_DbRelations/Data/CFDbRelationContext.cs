using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;

namespace P02_CF_DbRelations.Data
{
    public class CFDbRelationContext : DbContext
    {
        public CFDbRelationContext()
        {
                
        }

        public CFDbRelationContext(DbContextOptions<CFDbRelationContext> options) : base(options)
        {
                
        }

        // DB içeriğinde asağıdakiler olacak tanımlaması
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<AdSoyad> AdSoyad { get; set; }

    }
}
