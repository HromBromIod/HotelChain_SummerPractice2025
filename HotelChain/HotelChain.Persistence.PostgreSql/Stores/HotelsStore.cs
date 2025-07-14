using System.Data;
using Dapper;
using HotelChain.Core.Settings;
using HotelChain.Persistence.Models;
using HotelChain.Persistence.PostgreSql.Core;
using HotelChain.Persistence.Stores;
using Microsoft.Extensions.Options;
using Serilog;

namespace HotelChain.Persistence.PostgreSql.Stores;

internal class HotelsStore(
    ILogger logger,
    IOptions<PersistenceSettings> options)
    : PostgreSqlStoreBase(options), IHotelsStore
{
    public async Task<HotelDto?> GetHotelById(int id, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsStore)}.{nameof(GetHotelById)}: {id}");
        
        await using var connection = await GetConnectionAsync(cancellationToken);

        var sql = $@"
select
    ""Id"" as {nameof(HotelDto.Id)},
    ""CreationTime"" as {nameof(HotelDto.CreationTime)},
    ""ModificationTime"" as {nameof(HotelDto.ModificationTime)},
    ""Name"" as {nameof(HotelDto.Name)},
    ""PhoneNumber"" as {nameof(HotelDto.PhoneNumber)},
    ""Email"" as {nameof(HotelDto.Email)},
    ""Adress"" as {nameof(HotelDto.Address)}
from
    ""Hotels""
where
    ""Id"" = @HotelId
";

        var command = new CommandDefinition(
            commandText: sql,
            commandType: CommandType.Text,
            parameters: new { HotelId = id },
            cancellationToken: cancellationToken
            );

        return await connection.QuerySingleOrDefaultAsync<HotelDto>(command);
    }
    
    public async Task<HotelDto?> CreateHotelInfo(string name, string phoneNumber, string email, string address,
        CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsStore)}.{nameof(CreateHotelInfo)}: {name}");

        var hotelDto = new HotelDto
        {
            CreationTime = DateTime.UtcNow,
            ModificationTime = DateTime.UtcNow,
            Name = name,
            PhoneNumber = phoneNumber,
            Email = email,
            Address = address
        };
        
        await using var connection = await GetConnectionAsync(cancellationToken);

        var sql = $@"
insert into ""Hotels""(
    ""CreationTime"",
    ""ModificationTime"",
    ""Name"",
    ""PhoneNumber"",
    ""Email"",
    ""Adress"",
    ""ExternalId"")
values(
    @CreationTime,
    @ModificationTime,
    @Name,
    @PhoneNumber,
    @Email,
    @Address,
    gen_random_uuid())
returning ""Id""
";

        var command = new CommandDefinition(
            commandText: sql,
            commandType: CommandType.Text,
            parameters: new
            {
                CreationTime = hotelDto.CreationTime,
                ModificationTime = hotelDto.ModificationTime,
                Name = hotelDto.Name,
                PhoneNumber = hotelDto.PhoneNumber,
                Email = hotelDto.Email,
                Address = hotelDto.Address
            },
            cancellationToken: cancellationToken
        );
        
        var id = await connection.QuerySingleOrDefaultAsync<int?>(command);

        if (id == null)
            return null;
        
        hotelDto.Id = id;
        return hotelDto;
    }
    
    public async Task<bool> DeleteHotelById(int id, CancellationToken cancellationToken)
    {
        logger.Information($"{nameof(HotelsStore)}.{nameof(DeleteHotelById)}: {id}");
        
        await using var connection = await GetConnectionAsync(cancellationToken);
        
        var sql = $@"
delete from ""Hotels""
where ""Id"" = @HotelId
";

        var result = await connection.ExecuteAsync(
            sql: sql, 
            param: new { HotelId = id }
        );

        return result != 0;
    }
}