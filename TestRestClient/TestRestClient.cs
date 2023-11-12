using Refit;
using TestRestClient.Abstraction;

namespace TestRestClient
{
    public static class TestRestClient
    {
        public static IServiceCollection AddTestRestClient(this IServiceCollection services)
        {
            services.AddRefitClient<IWordRestClient>().ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5000/api");
            });

            return services;
        }
    }
}
