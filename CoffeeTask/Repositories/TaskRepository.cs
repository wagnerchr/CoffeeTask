using System.Threading.Tasks;
using CoffeeTask.Entities;
using CoffeeTask.Repositories;
using CoffeeTask.UseCases.Task.GetTaskUseCase;

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

    public async Task<TaskEntity?> GetTask(GetTaskInput id)
    {
        var task = await _dbService.GetOne<TaskEntity?>(
            "SELECT * FROM task WHERE id::text = @Id", new { Id = id.Id}
        );
        return task;
    }
}