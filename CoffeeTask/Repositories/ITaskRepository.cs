using CoffeeTask.Entities;
using CoffeeTask.UseCases.Task.GetTaskUseCase;

namespace CoffeeTask.Repositories
{
    public interface ITaskRepository
    {
        public Task<bool> CreateTask(TaskEntity task);
        public Task<TaskEntity?> GetTask(GetTaskInput id);
    }
}
