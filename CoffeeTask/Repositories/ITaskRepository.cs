using CoffeeTask.Entities;

namespace CoffeeTask.Repositories
{
    public interface ITaskRepository
    {
        public Task<bool> CreateTask(TaskEntity task);
        public Task<TaskEntity?> GetTask(Guid id);
        public Task<bool> UpdateTask(TaskEntity task);
    }
}
