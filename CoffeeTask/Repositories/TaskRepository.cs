using CoffeeTask.Entities;
using CoffeeTask.Repositories;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;
using Dapper;
using System.Threading.Tasks;

public class TaskRepository : ITaskRepository
{
    private readonly DbService _dbService;

    public TaskRepository(DbService dbService)
    {
        _dbService = dbService;
    }

    public async Task<bool> CreateTask(TaskEntity task)
    {
        var result = await _dbService.Create(
            "INSERT INTO task (Id, name, description, priority, creationDate, dueDate) VALUES (@Id, @Name, @Description, @Priority, @CreationDate, @DueDate)", task);
        return true;
    }
}