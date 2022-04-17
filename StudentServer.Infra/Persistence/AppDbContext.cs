using Microsoft.EntityFrameworkCore;
using StudentServer.Domain.Entities;
using StudentServer.Infra.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServer.Infra.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StudentConfig());
            builder.ApplyConfiguration(new ClassConfig());

            base.OnModelCreating(builder);
        }
    }
}
