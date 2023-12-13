using Microsoft.EntityFrameworkCore;
using P01_CF.Data;
using P01_CF.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        // Dependency Injection
        // Database i�lemleri i�in 
        builder.Services.AddDbContext<StudentDbContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

        // Sample Data ??????
        //var context = new StudentDbContext();

        //try
        //{
        //    var student = new Student()
        //    {
        //        SFName = "�mit",
        //        SLastName = "KARA��V�"
        //    };

        //    context.Students.Add(student);
        //    context.SaveChanges();

        //}
        //catch (Exception)
        //{

        //    throw;
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