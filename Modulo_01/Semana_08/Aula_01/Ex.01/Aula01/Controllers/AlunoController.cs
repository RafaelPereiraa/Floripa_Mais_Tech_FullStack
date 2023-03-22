using Microsoft.AspNetCore.Mvc;

namespace Aula01.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{

    [HttpGet]
    [Route("obter-alunos")]
    public IActionResult ObterAlunos()
    {
        var aluno = new Aluno();
        aluno.Id = 1;
        aluno.Nome = "João";
        aluno.DataNascimento = new DateTime(2000, 1, 1);

        return Ok(aluno);
    }
}