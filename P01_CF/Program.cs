using Bogus;
using Microsoft.EntityFrameworkCore;
using P01_CF.Data;
using P01_CF.Entities;

using Person = P01_CF.Entities.Person;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        // Dependency Injection
        // Database iþlemleri için 
        builder.Services.AddDbContext<StudentDbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

        //// Sample Data ??????
        //Faker<Person> fakerPerson; // Bogus'un Faker isimli classý

        //var personList = new List<Person>();


        //for (int i = 1; i <= 10; i++)
        //{
        //    fakerPerson = new Faker<Person>()
        //        .RuleFor(p => p.PersonId, fd => fd.Random.Int(1, 200))
        //        .RuleFor(p => p.PFName, fd => fd.Name.FirstName())
        //        .RuleFor(p => p.PLName, fd => fd.Name.LastName())
        //        .RuleFor(p => p.PEMail, fd => fd.Internet.Email())
        //        .RuleFor(p => p.PPhone, fd => fd.Phone.PhoneNumber())
        //        .RuleFor(p => p.PAddress, fd => fd.Address.StreetAddress())
        //        .RuleFor(p => p.PPostCode, fd => fd.Address.ZipCode())
        //        .RuleFor(p => p.PCity, fd => fd.Address.City())
        //        .RuleFor(p => p.PGender, fd => fd.PickRandom<GenderEnum>());

        //    var person = fakerPerson.Generate();
        //    personList.Add(person);

        //}



        var app = builder.Build();


        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}