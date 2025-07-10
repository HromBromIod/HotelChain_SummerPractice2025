using HotelChain.Core.Settings;
using HotelChain.Persistence.PostgreSql.Stores;
using HotelChain.Persistence.Stores;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelChain.Persistence.PostgreSql;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddPostgreSqlStores(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<PersistenceSettings>(configuration.GetRequiredSection(nameof(PersistenceSettings)));
        
        serviceCollection.AddSingleton<IHotelsStore, HotelsStore>();

        return serviceCollection;
    }
}