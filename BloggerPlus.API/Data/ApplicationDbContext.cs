using BloggerPlus.API.Model.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BloggerPlus.API.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }

        public DbSet<BlogPost> Blogposts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
