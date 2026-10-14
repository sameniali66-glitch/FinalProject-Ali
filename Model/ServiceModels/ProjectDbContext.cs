using Microsoft.EntityFrameworkCore;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Model.ServiceModels
{
    public class ProjectDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = FinalProject-AliDb; Integrated Security = True; MultipleActiveResultSets = True; Encrypt = False");

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
