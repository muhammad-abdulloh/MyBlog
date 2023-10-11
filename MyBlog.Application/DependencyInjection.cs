using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MyBlog.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}