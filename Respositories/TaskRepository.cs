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

    public async Task<List<TaskEntity?>> GetAllTasks()
    {
        List<TaskEntity?> tasks = await _dbService.GetAll<TaskEntity?>(
            "SELECT * FROM task");
        return tasks;
    }

    public async Task<TaskEntity?> UpdateTask(TaskEntity task)
    {
        var result = await _dbService.Update(
            "UPDATE public.task SET name=@Name, description=@Description, priority=@Priority, dueDate=@DueDate WHERE id=@Id", task);
        return task;
    }
}