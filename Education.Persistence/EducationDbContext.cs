using Education.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Education.Persistence
{
    public class EducationDbContext : DbContext
    {
        public EducationDbContext()
        {

        }
        public EducationDbContext(DbContextOptions<EducationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                 //options.UseSqlServer("Server=.;database=Education;Trusted_Connection=True;MultipleActiveResultSets=true");
                options.UseSqlServer("Data Source=localhost;Initial Catalog=db_education;User Id=sa;Password=Junior99$");

            }
        }


        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(c => c.Precio)
                .HasPrecision(14, 2);


            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    CourseId = Guid.NewGuid(),
                    Description = "C basico",
                    Title = "C title",
                    CreationDate = DateTime.Now,
                    PublicationDate = DateTime.Now.AddYears(2),
                    Precio = 56
                }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    CourseId = Guid.NewGuid(),
                    Description = "C avanzado",
                    Title = "C title-avanzado",
                    CreationDate = DateTime.Now,
                    PublicationDate = DateTime.Now.AddYears(2),
                    Precio = 80
                }
            );

        }

    }
}
