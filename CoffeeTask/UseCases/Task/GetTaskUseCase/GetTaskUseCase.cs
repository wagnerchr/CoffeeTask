using CoffeeTask.Entities;
using CoffeeTask.Repositories;
using CoffeeTask.UseCases.Task.interfaces;

namespace CoffeeTask.UseCases.Task.GetTaskUseCase
{
    public class GetTaskUseCase : IGetTaskUseCase
    {
        private readonly ITaskRepository _taskRepository;
        public GetTaskUseCase(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskEntity?> GetTask(GetTaskInput id)
        {
            TaskEntity? task =  await this._taskRepository.GetTask(id);
            return task;
        }
    }
}
