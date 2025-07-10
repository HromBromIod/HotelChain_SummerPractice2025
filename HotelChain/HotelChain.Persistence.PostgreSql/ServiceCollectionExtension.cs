using HotelChain.Core.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelChain.Persistence.PostgreSql;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPostgreSqlStores(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<PersistenceSettings>(configuration.GetRequiredSection(nameof(PersistenceSettings)));

        return serviceCollection;
    }
}