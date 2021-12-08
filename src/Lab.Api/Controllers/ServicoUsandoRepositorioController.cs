using Lab.Dados.ServicoUsandoRepositorio;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ServicoUsandoRepositorioController : ControllerBase
{
    private readonly ILogger<ServicoUsandoRepositorioController> logger;
    private readonly ServicoComRepo servico;

    public ServicoUsandoRepositorioController(
        ILogger<ServicoUsandoRepositorioController> logger,
        ServicoComRepo servico)
    {
        this.logger = logger;
        this.servico = servico;
    }

    [HttpGet("{id}")]
    public int Get(int id) => servico.Obter(id);
}
