using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communitymodels.Articlesmodel;
using communitymodels.Forumsmodel;
using communitymodels.Projectsmodel;
using Microsoft.EntityFrameworkCore;

namespace communitymodels
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Login> Logins { get; set; }
        public DbSet<SecurityQuestions> SecurityQuestions { get; set; }
        public DbSet<Forum>forums { get; set; }
        public DbSet<ForumsReply> ForumsReply {  get; set; }
        public DbSet<Articles> PostArticle { get; set; }
        public DbSet<Contact> contact { get; set; }
        public DbSet<Project> project { get; set; }


    }
}
