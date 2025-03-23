using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PropertiesPROCUST
{
    public class ProCustDbcontext:DbContext
    {
        public ProCustDbcontext(DbContextOptions<ProCustDbcontext> options) : base(options) { }
        public DbSet<ProCust> ProCusts { get; set; }
    }
}
