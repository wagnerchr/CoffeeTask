using CoffeeTask.Entities;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;
using Dapper;

namespace CoffeeTask.Repositories
{
    public interface ITaskRepository
    {
        public Task<bool> CreateTask(TaskEntity task);
    }
}
