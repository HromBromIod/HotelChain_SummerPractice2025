using HotelChain.Persistence.Models;

namespace HotelChain.Persistence.Stores;

public interface IHotelsStore
{
    public Task<HotelDto?> GetHotelById(int id, CancellationToken cancellationToken);
}