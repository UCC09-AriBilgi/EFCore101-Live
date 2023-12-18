using Bogus;
using P01_CF.Entities;
using Person = P01_CF.Entities.Person;
using System;
using System.Collections.Generic;

namespace P01_CF.Data
{
    public class DataGenerator
    {
        // Burası Person classıma bağlı olarak fake/dummy veri üretecek kısım..

        Faker<Person> fakerPerson; // Bogus'un Faker isimli classı

        // Constructor
        //public DataGenerator()
        //{
        //    //fakerPerson = new Faker<Person>()
        //    //    .RuleFor(p => p.PersonId, fd => fd.Random.Int(1, 200))
        //    //    .RuleFor(p => p.PFName, fd => fd.Name.FirstName())
        //    //    .RuleFor(p => p.PLName, fd => fd.Name.LastName())
        //    //    .RuleFor(p => p.PEMail, fd => fd.Internet.Email())
        //    //    .RuleFor(p => p.PPhone, fd => fd.Phone.PhoneNumber())
        //    //    .RuleFor(p => p.PAddress, fd => fd.Address.StreetAddress())
        //    //    .RuleFor(p => p.PPostCode, fd => fd.Address.ZipCode())
        //    //    .RuleFor(p => p.PCity, fd => fd.Address.City())
        //    //    .RuleFor(p => p.PGender, fd => fd.PickRandom<GenderEnum>());

        //    //fakerPerson.Generate(); // Dummy Veriyi yaratacak olan metot

        //}

        public List<Person> GeneratePerson(int count) // Kaç adet person yaratacağımızı verebileceğimiz.
        {
            for (int i = 1; i <= count; i++)
            {
                fakerPerson= new Faker<Person>()
                    .RuleFor(p => p.PersonId, fd => fd.Random.Int(1, 200))
                    .RuleFor(p => p.PFName, fd => fd.Name.FirstName())
                    .RuleFor(p => p.PLName, fd => fd.Name.LastName())
                    .RuleFor(p => p.PEMail, fd => fd.Internet.Email())
                    .RuleFor(p => p.PPhone, fd => fd.Phone.PhoneNumber())
                    .RuleFor(p => p.PAddress, fd => fd.Address.StreetAddress())
                    .RuleFor(p => p.PPostCode, fd => fd.Address.ZipCode())
                    .RuleFor(p => p.PCity, fd => fd.Address.City())
                    .RuleFor(p => p.PGender, fd => fd.PickRandom<GenderEnum>());


            }




            var personList=fakerPerson.Generate();

            return personList;
        }



    }
}
