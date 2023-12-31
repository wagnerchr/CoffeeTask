﻿namespace CoffeeTask.Database.interfaces
{
    public interface IDbService
    {
        Task<int> Create(string command, object parms);
        Task<T?> GetOne<T>(string command, object parms);
        Task<List<T?>> GetAll<T>(string command);
        Task<int> Update(string command, object parms);
    }
}