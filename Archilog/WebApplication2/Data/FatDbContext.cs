using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class FatDbContext:DbContext
    {
        public FatDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizza { get; set; }
    }
}
