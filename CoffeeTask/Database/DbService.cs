using CoffeeTask.Database.interfaces;
using Dapper;
using Npgsql;
using System.Data;

public class DbService : IDbService
{
    private readonly IDbConnection _db;
    public DbService(IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("SqlConnection");
        _db = new NpgsqlConnection(connectionString);
    }

    public async Task<int> Create(string command, object parms)
    {
        if (_db.State != ConnectionState.Open)
        {
            if (_db is NpgsqlConnection npgsqlConnection)
                await npgsqlConnection.OpenAsync();
            else
                throw new InvalidOperationException("Connection is not NpgsqlConnection");
        }
        int result = await _db.ExecuteAsync(command, parms);
        return result;
    }
}