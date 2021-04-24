using Microsoft.EntityFrameworkCore;
using System;

namespace Project2.Models
{
    public class PriceContext : DbContext
    {
        public PriceContext(DbContextOptions<PriceContext> options)
            : base(options)
        { }

        public DbSet<Price> Prices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Price>(
                eb =>
                {
                    eb.HasNoKey();
                });
        }

    }
}
