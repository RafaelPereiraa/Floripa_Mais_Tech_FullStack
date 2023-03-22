using Aula_02.Models;
using Aula_02.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aula_02.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar(string? nome = null)
    {
        var objectResult = AlunoRepository.Listar(nome);
        if (objectResult.Count == 0)
        {
            return StatusCode(204);
        } else {        
            return StatusCode(200, objectResult);
        }
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult FindAlunoById(int id) { 
        var objectResult = AlunoRepository.FindById(id) != null;
        if (objectResult == false)
            return StatusCode(204);
        else
            return StatusCode(200, objectResult);
    }
}