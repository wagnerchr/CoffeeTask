using Microsoft.AspNetCore.Mvc;
using CoffeeTask.UseCases.Task.interfaces;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;
using CoffeeTask.UseCases.Task.GetTaskUseCase;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ICreateTaskUseCase _createTaskUseCase;
    private readonly IGetTaskUseCase _getTaskUseCase;
    public TaskController(
        ICreateTaskUseCase createTaskUseCase,
        IGetTaskUseCase getTaskUseCase)
    {
        _createTaskUseCase = createTaskUseCase;
        _getTaskUseCase = getTaskUseCase;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] CreateTaskInput task)
    {
        await _createTaskUseCase.CreateTask(task);
        return Ok("Tarefa criada com sucesso!");
    }

    [HttpGet]
    public async Task<IActionResult> GetTask(string id)
    {
        var taskInput = new GetTaskInput { Id = id};
        var result = await _getTaskUseCase.GetTask(taskInput);
        return Ok(result);
    }
}
