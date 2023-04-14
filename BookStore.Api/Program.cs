using BookStore.Application;
using BookStore.Application.MappingProfiles;
using Microsoft.EntityFrameworkCore;
using BookStore.Infrastructure.Context;
using BookStore.Infrastrcuture;
using BookStore.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add configuration
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<BookStoreDbContext>(options =>
//                options.UseSqlServer(connectionString: builder.Configuration.GetConnectionString("BookStoreDb")));

builder.Services.AddDbContext<BookStoreDbContext>(options =>
    options.UseSqlServer(connectionString: builder.Configuration.GetConnectionString("BookStoreDb"),
        sqlServerOptionsAction: sqlOptions => sqlOptions.CommandTimeout(1200)));



builder.Services
    //.InfrastructureDependencyInjection()
    .InfraDependencyInjection(builder.Configuration)
    .ApplicationDependencyInjection()
    .AddAutoMapper(typeof(AuthorProfile));


builder.Services.AddScoped<AuthorService>();
builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddAutoMapper(typeof(AuthorProfile));

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
