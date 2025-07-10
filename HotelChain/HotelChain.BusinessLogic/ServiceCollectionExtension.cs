using HotelChain.BusinessLogic.Services;
using HotelChain.BusinessLogic.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace HotelChain.BusinessLogic;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHotelsService, HotelsService>();

        return serviceCollection;
    }
}