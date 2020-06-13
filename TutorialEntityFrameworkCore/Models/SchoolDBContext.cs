using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TutorialEntityFrameworkCore.Models
{
    class SchoolDBContext:DbContext
    {
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        //Example of modelBuilder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Con estas configuraciones, se forza a colocar la clave primaria manualmente
            modelBuilder.Entity<Maestro>().Property(t => t.TeacherId).HasColumnName("Id").HasDefaultValue(0).IsRequired();

            
            modelBuilder.Entity<Maestro>().Property<String>("Direccion");
            modelBuilder.Entity<Maestro>().Property<int>("Edad");
        }

        public DbSet<Estudiantes> Student { get; set; }
        public DbSet<Cursos> Courses { get; set; }
        public DbSet<Maestro> Persons { get; set; }

    }
}
