using System.Reflection;
using TestWebApi.Mapper;

namespace TestWebApi.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDbConnection(this IServiceCollection service)
        {
            return service;
        }

        public static IServiceCollection AddMediator(this IServiceCollection service)
        {
            service.AddMediatR(conf =>
            {
                conf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            return service;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(conf =>
            {
                conf.AddProfile(new ObserverProfile());
            });

            return service;
        }
    }
}
