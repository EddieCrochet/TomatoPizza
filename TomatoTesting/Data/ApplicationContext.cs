using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TomatoPizzaCafe.Models;

namespace TomatoPizzaCafe.Data
{
    public class ApplicationContext : DbContext
    {
        
        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>()
                  .HasKey(nameof(Pizza.PizzaId));
            modelBuilder.Entity<MakeYourOwn>()
                .HasKey(nameof(MakeYourOwn.MakeYourOwnId));
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<MakeYourOwn> MakeYourOwns { set; get; }

    }
}
