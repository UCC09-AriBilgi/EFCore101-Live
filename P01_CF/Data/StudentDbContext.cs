﻿using Microsoft.EntityFrameworkCore;
using P01_CF.Entities;

namespace P01_CF.Data
{
    public class StudentDbContext : DbContext
    {
        // constructor yaratılacak : Code snippet ctor(constructor)
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public StudentDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // tüm context ile ilgili gerekiyorsa konfigüre işlemleri için yazılacak kodlar bölümü
            // Database Connection String Konfigure etme
            optionsBuilder.UseSqlServer();


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // burası modellerimiz yaratılırken eğer yapılacak işlem varsa buraya yazılır..


        }


        // Sınıflarımızı DbSet olarak tanımlıyoruz...DbSet <--> table(db tarafındaki)
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Person> Persons { get; set; }
        





    }
}
