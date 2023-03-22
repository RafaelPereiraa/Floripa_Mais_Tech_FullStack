using Aula_02.Models;

namespace Aula_02.Repositories;

public class AlunoRepository{
 
    private static List<AlunoModel> alunos = new List<AlunoModel>(){
        new AlunoModel { Id = 1, Nome = "João", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 2, Nome = "Maria joão", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 3, Nome = "José", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 4, Nome = "Ana", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 5, Nome = "João Pedro", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 6, Nome = "Paulo", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 7, Nome = "Joana", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 8, Nome = "Joaquim", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 9, Nome = "Júlia", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
        new AlunoModel { Id = 10, Nome = "Júlio", DataDeNascimento = new DateTime(1990, 01, 01), DataDeInclusao = DateTime.Now, DataDeAlteracao = DateTime.Now },
    };


    public static List<AlunoModel> Listar(string? nome = null)
    {
        if (nome != null)
        {
            return alunos.Where(x => x.Nome.ToLower().Contains(nome.ToLower())).ToList();
        } else
        {
            return alunos;
        }
    }
}