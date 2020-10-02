using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Api.Context
{
    public class BarContext : DbContext
    {
        public BarContext(DbContextOptions<BarContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Chain>()
                .HasIndex(u => u.Name)
                .IsUnique();
        }

        public DbSet<Bar> Bars { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Chain> Chains { get; set; }
    }

    public class Bar
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Location Location { get; set; }
        public Chain? Chain { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public IList<Bar> Bars { get; set; }
    }
    public class Chain
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IList<Bar> Bars { get; set; }
    }
}