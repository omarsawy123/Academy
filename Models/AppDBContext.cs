using Academy_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class AppDBContext:DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Student>().HasData(new Student
            {
                id = "1",
                name = "John",
                academicYear = "FirstYear",
                dateOfBirth = "2020-12-3",
                description="First Year Student"
            });
            
            modelBuilder.Entity<Student>().HasData(new Student
            {
                id = "2",
                name = "Sami",
                academicYear = "SecondYear",
                dateOfBirth = "2020-12-3",
                description = "Second Year Student"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                id = "3",
                name = "Ahmed",
                academicYear = "ThirdYear",
                dateOfBirth ="2020-12-2",
                description = "Third Year Student"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                id = "4",
                name = "Mostafa",
                academicYear = "FourthYear",
                dateOfBirth = "2020-2-11",
                description = "Fourth Year Student"
            });


            

        }

    }
}
