using CoffeeTask.Entities;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;
using CoffeeTask.UseCases.Task.GetTaskUseCase;

namespace CoffeeTask.UseCases.Task.interfaces
{
    public interface ICreateTaskUseCase
    {
        Task<bool> CreateTask(CreateTaskInput task);
    }

    public interface IGetTaskUseCase 
    {
        Task<TaskEntity?> GetTask(GetTaskInput id);
    }
}
