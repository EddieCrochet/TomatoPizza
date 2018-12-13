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
                .HasKey("PizzaID");
            modelBuilder.Entity<MakeYourOwn>()
                .HasKey("MakeYourOwnID");
            modelBuilder.Entity<Topping>()
                .HasKey("ToppingID");
            modelBuilder.Entity<Order>()
                .HasKey("OrderID");
            modelBuilder.Entity<OrderItem>()
                .HasKey("OrderItemID");
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<MakeYourOwn> MakeYourOwns { set; get; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
