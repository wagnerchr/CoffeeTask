using Microsoft.AspNetCore.Mvc;
using CoffeeTask.UseCases.Task.interfaces;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;
using CoffeeTask.UseCases.Task.GetTaskUseCase;
using CoffeeTask.UseCases.Task.UpdateTaskUseCase;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ICreateTaskUseCase _createTaskUseCase;
    private readonly IGetTaskUseCase _getTaskUseCase;
    private readonly IUpdateTaskUseCase _updateTaskUseCase;

    public TaskController(
        ICreateTaskUseCase createTaskUseCase,
        IGetTaskUseCase getTaskUseCase,
        IUpdateTaskUseCase updateTaskUseCase)
    {
        _createTaskUseCase = createTaskUseCase;
        _getTaskUseCase = getTaskUseCase;
        _updateTaskUseCase = updateTaskUseCase;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] CreateTaskInput task)
    {
        await _createTaskUseCase.CreateTask(task);
        return Ok("Tarefa criada com sucesso!");
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTask(GetTaskInput id)
    {
        var result = await _getTaskUseCase.GetTask(id);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTask(string id, [FromBody] UpdateTaskInput task)
    {
        var result = await _updateTaskUseCase.UpdateTask(id, task);
        return Ok(result);
    }
}
