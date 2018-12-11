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
            //modelBuilder.Entity<MakeYourOwnTopping>()
            //    .HasKey(mt => new { mt.MakeYourOwnId, mt.ToppingId });
            //modelBuilder.Entity<MakeYourOwnTopping>()
            //    .HasOne(mt => mt.MakeYourOwn)
            //    .WithMany(m => m.MakeYourOwnToppings)
            //    .HasForeignKey(mt => mt.MakeYourOwnId);
            //modelBuilder.Entity<MakeYourOwnTopping>()
            //    .HasOne(mt => mt.Topping)
            //    .WithMany(t => t.MakeYourOwnToppings)
            //    .HasForeignKey(mt => mt.ToppingId);
            modelBuilder.Entity<Pizza>()
                  .HasKey(nameof(Pizza.PizzaId));
            modelBuilder.Entity<MakeYourOwn>()
                .HasKey(nameof(MakeYourOwn.MakeYourOwnId));
            modelBuilder.Entity<Topping>()
                .HasKey(nameof(Topping.ToppingId));
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<MakeYourOwn> MakeYourOwns { set; get; }
        public DbSet<Topping> Toppings { get; set; }
        //public DbSet<MakeYourOwnTopping> MakeYourOwnToppings { get; set; }
    }
}
