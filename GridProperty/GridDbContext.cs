using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GridProperty
{
    public class GridDbContext:DbContext
    {
        public GridDbContext(DbContextOptions<GridDbContext> options) : base(options) { }
        public DbSet<FinancialData> financialdate {  get; set; }

    }
}
