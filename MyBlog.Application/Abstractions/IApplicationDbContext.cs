using Microsoft.EntityFrameworkCore;
using MyBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Post> Posts { get; set; }

        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    }
}
