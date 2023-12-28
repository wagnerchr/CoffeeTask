using CoffeeTask.Entities;
using CoffeeTask.Repositories;
using CoffeeTask.UseCases.Task.interfaces;

namespace CoffeeTask.UseCases.Task.GetAllTasksUseCase
{
    public class GetAllTasksUseCase : IGetAllTasksUseCase
    {
        private readonly ITaskRepository _taskRepository;
        public GetAllTasksUseCase(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskEntity?>> GetAllTasks()
        {
            List<TaskEntity?> task = await this._taskRepository.GetAllTasks();
            return task;
        }
    }
}
