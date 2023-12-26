using CoffeeTask.Entities;
using CoffeeTask.Repositories;
using CoffeeTask.UseCases.Task.interfaces;

namespace CoffeeTask.UseCases.Task.CreateTaskUseCase
{
    public class CreateTaskUseCase: ICreateTaskUseCase
    {
        private readonly ITaskRepository _taskRepository;
        public CreateTaskUseCase(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> CreateTask(CreateTaskInput task)
        {
            
            var Id = Guid.NewGuid();

            TaskEntity newTask = new TaskEntity();
            newTask.Id = Id;
            newTask.Name = task.Name;
            newTask.Description = task.Description;
            newTask.Priority = task.Priority;
            newTask.CreationDate = DateTime.Now;
            newTask.DueDate = task.DueDate;
            
            var result = await _taskRepository.CreateTask(newTask);
            return result;
        }
    }
}
