using BookStore.Application.Contracts;
using BookStore.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Application
{
    public static class DependencyInjectionHelpersAppHelpers
    {
        public static IServiceCollection ApplicationDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICustomerService, CustomerService>();

            return services;
        }
    }
}