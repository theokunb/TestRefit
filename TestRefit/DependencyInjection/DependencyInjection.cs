using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestRefit.Mapper;

namespace TestRefit.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDbConnection(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];

            services.AddDbContext<WordDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });
            services.AddScoped<IWordDbContext>(provider =>
            {
                var dbContext = provider.GetService<WordDbContext>();
                DbInitializer.Initialize(dbContext);

                return dbContext;
            });

            return services;
        }

        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }

        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(conf =>
            {
                conf.AddProfile(new WordProfile());
            });

            return services;
        }
    }
}
