using Microsoft.EntityFrameworkCore;
using P02_CF_DbRelations.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Dependency Injection
// Database iþlemleri için --> appsettings.json dan okudu
builder.Services.AddDbContext<CFDbRelationContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

#region Fake Data Generation
// Definitions
builder.Services.AddTransient<CityDG>();
builder.Services.AddTransient<AdSoyadDG>();


// Calling
AdSoyadDG adsoyadDG = new AdSoyadDG();
adsoyadDG.Generate(5);


//CityDG cityDG = new CityDG();
//cityDG.Generate(5);


#endregion


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
