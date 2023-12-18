using Bogus;
using Microsoft.AspNetCore.Mvc;
using P01_CF.Models;
using P01_CF.Entities;
using System.Diagnostics;
using Person = P01_CF.Entities.Person;
using P01_CF.Data;

namespace P01_CF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Sayfaya ilk gelecek kısımda.. Index sayfası gelmeden önce örnek veriyi burada yaratacak.Yarattıktan sonra da görmek için İndex View2a gidecek.
            StudentDbContext dbContext=new StudentDbContext();

            // Sample Data ??????
            Faker<Person> fakerPerson; // Bogus'un Faker isimli classı

            var personList = new List<Person>();
            // ?? DB tarafına gönderilme...

            // Deneme olması açısından 10 tane dummy data ..for çevrimiyle ve bunu bir listeye yerleştirerek.

            for (int i = 1; i <= 20; i++)
            {
                fakerPerson = new Faker<Person>("tr") // Regional tr Türkiye
                    //.RuleFor(p => p.PersonId, fd => fd.Random.Int(1, 200))
                    .RuleFor(p => p.PFName, fd => fd.Name.FirstName())
                    .RuleFor(p => p.PLName, fd => fd.Name.LastName())
                    .RuleFor(p => p.PEMail, fd => fd.Internet.Email())
                    .RuleFor(p => p.PPhone, fd => fd.Phone.PhoneNumber())
                    .RuleFor(p => p.PAddress, fd => fd.Address.StreetAddress())
                    .RuleFor(p => p.PPostCode, fd => fd.Address.ZipCode())
                    .RuleFor(p => p.PCity, fd => fd.Address.City())
                    .RuleFor(p => p.PGender, fd => fd.PickRandom<GenderEnum>());

                var person = fakerPerson.Generate(); // fake data yaratılıyor.

                personList.Add(person); // yaratılan data bir listeye ekleniyor

                dbContext.Add<Person>(person);

                dbContext.SaveChanges();

                
            }


            //var std = new Student()
            //{
            //    FirstName = "Bill",
            //    LastName = "Gates"
            //};
            //context.Students.Add(std);

            // or
            // context.Add<Student>(std);

            return View(personList); // Home/Index sayfasına gönderiliyor.
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
