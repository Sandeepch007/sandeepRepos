using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace propertylayer
{
    public class AppdbContext:DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options) { }
        public DbSet<Products> Products { get; set; }
        public DbSet<category> Category { get; set; }
    }
}
