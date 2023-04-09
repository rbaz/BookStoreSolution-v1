using BookStore.Domain.Persistences.Repositories;
using BookStore.Domain.Persistences.Specifications;
using BookStore.Infrastrcuture.Persistences.Repositories;
using BookStore.Infrastrcuture.Persistences.Specifications;
using BookStore.Infrastructure.Context;
using BookStore.Infrastructure.Persistences.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastrcuture
{
    public static class OtherDependencyInjection
    {
        public static IServiceCollection InfraDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookStoreDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("BookStoreDb")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IAuthorRepository), typeof(AuthorRepository));
            services.AddScoped(typeof(IBookRepository), typeof(BookRepository));
            services.AddScoped(typeof(ISpecification<>), typeof(SpecificationEvaluator<>));

            return services;
        }
    }
}
