using System;
using System.Collections.Generic;
using System.Text;
using loggingnblogDataLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace loggingnblog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }

        public Article FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
