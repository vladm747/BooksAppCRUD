using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace BooksApp.Startup
{
    public static partial class ServiceInitializer
    {
        public  static IServiceCollection RegisterApplicationServices(
                                    this IServiceCollection services)
        {
            RegisterSwagger(services);
            RegisterCustomDependencies(services);

           
            return services;
        }

        private static void RegisterCustomDependencies(IServiceCollection services)
        {
            services.AddDbContext<BookDbContext>(
                options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
        }

        private static void RegisterSwagger(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
