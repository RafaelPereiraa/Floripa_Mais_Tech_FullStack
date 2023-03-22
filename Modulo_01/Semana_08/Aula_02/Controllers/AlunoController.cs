using Aula_02.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula_02.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar(string? nome = null) => StatusCode(200 ,AlunoRepository.Listar(nome));
}