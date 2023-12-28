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

        public async Task<TaskEntity?> UpdateTask(string id, UpdateTaskInput task)
        {
            TaskEntity newTask = new TaskEntity();
            newTask.Id = new Guid(id);
            newTask.Name = task.Name;
            newTask.Description = task.Description;
            newTask.Priority = task.Priority;
            newTask.DueDate = DateTime.UtcNow; ;

            TaskEntity? response = await this._taskRepository.UpdateTask(newTask);
            return response;
        }
    }
}