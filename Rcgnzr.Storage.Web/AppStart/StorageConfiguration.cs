using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rcgnzr.Storage.Logic.Storage;

namespace Rcgnzr.Storage.Web.AppStart
{
    public static class StorageConfiguration
    {
        public static IServiceCollection AddStorage(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Storage");
            services.AddScoped<IStorage>(x => new FileStorage(connectionString));
            return services;
        }
    }
}