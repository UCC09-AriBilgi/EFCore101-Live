using Bogus;
using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Models;

namespace P02_CF_DbRelations.Data
{
    public class DepartmentDG
    {
        Faker<Department> fakerDepartment;

        public DbSet<Department> Departments { get; set; } // City sınıfından Cities isimli bir tabloyu ifade ediyor.

        public DepartmentDG()
        {
            fakerDepartment = new Faker<Department>("tr"); // tr --> local ülke parametresi

            fakerDepartment.RuleFor(c => c.DepartmentName, cd => cd.Commerce.Department());
        }

        public void Generate(int count)
        {
            using var context = new CFDbRelationContext();

            for (int index = 1; index <= count; index++)
            {
                var department = fakerDepartment.Generate();

                Departments.Add(department); // Department yaratıldı...
            }
        }
    }
}
