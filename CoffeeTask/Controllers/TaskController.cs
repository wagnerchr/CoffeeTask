using Microsoft.AspNetCore.Mvc;
using CoffeeTask.UseCases.Task.interfaces;
using CoffeeTask.UseCases.Task.CreateTaskUseCase;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ICreateTaskUseCase _createTaskUseCase;
    public TaskController(ICreateTaskUseCase createTaskUseCase)
    {
        _createTaskUseCase = createTaskUseCase;
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask([FromBody] CreateTaskInput task)
    {
        await _createTaskUseCase.CreateTask(task);
        return Ok("Tarefa criada com sucesso!");
    }
}
