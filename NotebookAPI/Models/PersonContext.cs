using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotebookAPI.Models
{

    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
       
        public PersonContext()
        {
            Database.EnsureCreated();
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=kakdela");
        }


    }
}