using Microsoft.EntityFrameworkCore;
using MyBlog.Application.Abstractions;
using MyBlog.Domain.Entities;
using MyBlog.Infrastructure.Persistence.EntityTypeConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PostEntityTypeConfiguration());
        }

    }
}
