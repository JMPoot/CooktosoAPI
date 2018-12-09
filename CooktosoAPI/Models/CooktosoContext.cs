using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooktosoAPI.Models
{
    public class CooktosoContext : DbContext
    {
        public CooktosoContext(DbContextOptions<CooktosoContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
