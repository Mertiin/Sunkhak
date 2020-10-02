using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    public class BarContext : DbContext
    {
        public BarContext(DbContextOptions<BarContext> options)
            : base(options)
        { }

        public DbSet<Bar> Bars { get; set; }
    }

    public class Bar
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}