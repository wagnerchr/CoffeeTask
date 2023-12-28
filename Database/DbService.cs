using CoffeeTask.Database.interfaces;
using Dapper;
using Npgsql;
using System.Data;

public class DbService : IDbService
{
    private readonly IDbConnection _db;

    public DbService(IConfiguration configuration)
    {
        _db = new NpgsqlConnection(Environment.GetEnvironmentVariable("CONN_STRING"));
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

    public async Task<T?> GetOne<T>(string command, object parms)
    {
        T? result;
        result = (await _db.QueryAsync<T>(command, parms).ConfigureAwait(false)).FirstOrDefault();
        return result;
    }

    public async Task<List<T?>> GetAll<T>(string command)
    {
        List<T?> result = new List<T?>();
        result = (await _db.QueryAsync<T?>(command)).ToList();
        return result;
    }

    public async Task<int> Update(string command, object parms)
    {
        int result;
        result = await _db.ExecuteAsync(command, parms);
        return result;
    }
}