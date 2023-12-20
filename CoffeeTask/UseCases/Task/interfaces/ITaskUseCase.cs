using CoffeeTask.Entities;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;

namespace CoffeeTask.UseCases.Task.interfaces
{
    public interface ICreateTaskUseCase
    {
        Task<bool> CreateTask(CreateTaskInput task);
    }
}
