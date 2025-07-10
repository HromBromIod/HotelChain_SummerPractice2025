using System.Data;
using Dapper;
using HotelChain.Core.Settings;
using HotelChain.Persistence.Models;
using HotelChain.Persistence.PostgreSql.Core;
using HotelChain.Persistence.Stores;
using Microsoft.Extensions.Options;

namespace HotelChain.Persistence.PostgreSql.Stores;

internal class HotelsStore(
    IOptions<PersistenceSettings> options)
    : PostgreSqlStoreBase(options), IHotelsStore
{
    public async Task<HotelDto?> GetHotelById(int id, CancellationToken cancellationToken)
    {
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
}