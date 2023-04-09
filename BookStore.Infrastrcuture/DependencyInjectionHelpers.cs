using BookStore.Domain.Persistences.Repositories;
using BookStore.Infrastrcuture.Persistences.Repositories;
using BookStore.Infrastructure.Context;
using BookStore.Infrastructure.Persistences.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastrcuture
{
    public static class DependencyInjectionInfraHelpers
    {
        public static IServiceCollection InfrastructureDependencyInjection(this IServiceCollection services)
        {            

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));            
            services.AddScoped(typeof(IAuthorRepository), typeof(AuthorRepository));
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));

            return services;
        }

        public static IServiceCollection InfrastructureDependencyInjection1(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookStoreDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("BookStoreDb")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IAuthorRepository), typeof(AuthorRepository));
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));

            return services;
        }
    }
}