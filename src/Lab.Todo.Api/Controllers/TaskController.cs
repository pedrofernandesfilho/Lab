using Microsoft.AspNetCore.Mvc;

namespace Lab.Todo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ILogger<TaskController> logger;

    public TaskController(ILogger<TaskController> logger) => this.logger = logger;

  [HttpGet]
  public ActionResult<IEnumerable<TaskModel>> Get()
  {
    logger.LogInformation($"{nameof(TaskController)} - Get List");

    return Ok(new[] { new TaskModel("Tarefa 1"), new TaskModel("Tarefa 2") });
  }
}

public record TaskModel(string Title);
