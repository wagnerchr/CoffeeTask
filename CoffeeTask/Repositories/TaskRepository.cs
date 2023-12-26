using CoffeeTask.Entities;
using CoffeeTask.Repositories;

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

    public async Task<TaskEntity?> GetTask(Guid id)
    {
        var task = await _dbService.GetOne<TaskEntity?>(
            "SELECT * FROM task WHERE id = @Id", id);
        return task;
    }

    public async Task<bool> UpdateTask(TaskEntity task)
    {
        var result = await _dbService.Update(
            "Update task SET task = @task WHERE id = @Id", task);
        return true;
    }
}