using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogSansLogin.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
    }
}