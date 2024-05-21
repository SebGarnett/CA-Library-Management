using LibraryManagement.Application.Interfaces;
using LibraryManagement.Infrastructure.Repositories;
//using LibraryManagement.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DockerDb")));

            services.AddScoped<IAppDbContext, AppDbContext>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBorrowerRepository, BorrowerRepository>();
            services.AddScoped<ILoanRepository, LoanRepository>();
        }
    }
}
