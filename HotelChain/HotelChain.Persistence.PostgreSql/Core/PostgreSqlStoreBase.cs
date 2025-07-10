using System.Data;
using HotelChain.Core.Settings;
using Microsoft.Extensions.Options;
using Npgsql;

namespace HotelChain.Persistence.PostgreSql.Core;

internal class PostgreSqlStoreBase(IOptions<PersistenceSettings> options)
{
    protected async Task<NpgsqlConnection> GetConnectionAsync(CancellationToken cancellationToken)
    {
        var connection = new NpgsqlConnection(options.Value.DbConnectionString);
        if (connection.State != ConnectionState.Open)
        {
            await connection.OpenAsync(cancellationToken);
        }

        return connection;
    }
}