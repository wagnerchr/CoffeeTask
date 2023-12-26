using CoffeeTask.Entities;
using CoffeeTask.Repositories;
using CoffeeTask.UseCases.Task.interfaces;
using CoffeeTask.UseCases.Task.UpdateTaskUseCase;

namespace CoffeeTask.UseCases.Task.GetTaskUseCase
{
    public class UpdateTaskUseCase : IUpdateTaskUseCase
    {
        private readonly ITaskRepository _taskRepository;
        public UpdateTaskUseCase(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> UpdateTask(string id, UpdateTaskInput task)
        {
            Guid taskId = Guid.NewGuid();
            TaskEntity newTask = new TaskEntity();
            newTask.Id = taskId;
            newTask.Name = task.Name;
            newTask.Description = task.Description;

            await this._taskRepository.UpdateTask(newTask);
            return true;
        }
    }
}
