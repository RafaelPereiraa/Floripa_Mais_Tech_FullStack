using Aula_02.Models;
using Aula_02.Repositories;
using Aula_02.Utils;
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
        Console.WriteLine(objectResult.Count);
        if (objectResult.Count == 0)
        {
            return StatusCode(204);
        }
        else
        {
            return StatusCode(200, objectResult);
        }
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult FindAlunoById(int id)
    {
        var objectResult = AlunoRepository.FindById(id);
        if (objectResult == null)
        {
            return StatusCode(404);
        }
        else
        {
            return StatusCode(200, AlunoRepository.FindById(id));
        }
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] AlunoDTO aluno)
    {
        var allFieldFilled = IsAnyNull.Check(aluno);
        if (allFieldFilled != null)
        {
            return StatusCode(400, $"O campo {allFieldFilled} não pode ser nulo.");
        }
        else
        {

            AlunoDTO objectResult = AlunoRepository.Cadastrar(aluno);
            objectResult.Links = new LinkDTO
            {
                Rel = "self",
                Href = $"http://localhost:8090/aluno/{objectResult.Id}",
                Metodo = "GET"
            };
            return StatusCode(201, objectResult);
        }
    }

    [HttpPut]
    [Route("alterar/{id}")]
    public IActionResult Alterar(int id, [FromBody] AlunoDTO aluno)
    {
        var allFieldFilled = IsAnyNull.Check(aluno);
        if (allFieldFilled != null)
        {
            return StatusCode(400, $"O campo {allFieldFilled} não pode ser nulo.");
        }
        else
        {
            var objectResult = AlunoRepository.FindById(id);
            if (objectResult == null)
            {
                return StatusCode(404);
            }
            else
            {
                objectResult.Nome = aluno.Nome;
                objectResult.DataDeNascimento = aluno.DataDeNascimento;
                objectResult.DataDeAlteracao = DateTime.Now;
                return StatusCode(200, objectResult);
            }
        }
    }

    [HttpDelete]
    [Route("deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var objectResult = AlunoRepository.FindById(id);
        if (objectResult == null)
        {
            return StatusCode(404);
        }
        else
        {
            AlunoRepository.Listar().Remove(objectResult);
            return StatusCode(200, objectResult);
        }
    }
}