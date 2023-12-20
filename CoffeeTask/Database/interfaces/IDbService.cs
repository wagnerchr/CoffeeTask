namespace CoffeeTask.Database.interfaces
{
    public interface IDbService
    {
        Task<int> Create(string command, object parms); 
    }
}
