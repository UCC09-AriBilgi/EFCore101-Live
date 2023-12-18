using Bogus;
using Microsoft.AspNetCore.Mvc;
using P01_CF.Models;
using P01_CF.Entities;
using System.Diagnostics;
using Person = P01_CF.Entities.Person;

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
            // Sample Data ??????
            Faker<Person> fakerPerson; // Bogus'un Faker isimli classı

            var personList = new List<Person>();


            for (int i = 1; i <= 10; i++)
            {
                fakerPerson = new Faker<Person>()
                    .RuleFor(p => p.PersonId, fd => fd.Random.Int(1, 200))
                    .RuleFor(p => p.PFName, fd => fd.Name.FirstName())
                    .RuleFor(p => p.PLName, fd => fd.Name.LastName())
                    .RuleFor(p => p.PEMail, fd => fd.Internet.Email())
                    .RuleFor(p => p.PPhone, fd => fd.Phone.PhoneNumber())
                    .RuleFor(p => p.PAddress, fd => fd.Address.StreetAddress())
                    .RuleFor(p => p.PPostCode, fd => fd.Address.ZipCode())
                    .RuleFor(p => p.PCity, fd => fd.Address.City())
                    .RuleFor(p => p.PGender, fd => fd.PickRandom<GenderEnum>());

                var person = fakerPerson.Generate();

                personList.Add(person);

            }


            return View(personList);
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
