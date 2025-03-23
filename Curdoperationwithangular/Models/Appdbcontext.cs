using Microsoft.EntityFrameworkCore;

namespace Curdoperationwithangular.Models
{
    public class Appdbcontext:DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options) { }
        public DbSet<Employee> employee { get; set; }
    }
}
