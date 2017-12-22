using Microsoft.EntityFrameworkCore;
using PizzaStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.DataAccess
{
  public class PizzaStoreDbContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      //base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlServer("");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Pizza>().HasKey("PizzaId");
    }

    public DbSet<Pizza> Pizzas {get; set;}
  }
}
