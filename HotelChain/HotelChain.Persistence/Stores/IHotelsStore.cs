using HotelChain.Persistence.Models;

namespace HotelChain.Persistence.Stores;

public interface IHotelsStore
{
    public Task<HotelDto?> GetHotelById(int id, CancellationToken cancellationToken);
    public Task<HotelDto?> CreateHotelInfo(string name, string phoneNumber, string email, string address, CancellationToken cancellationToken);
}