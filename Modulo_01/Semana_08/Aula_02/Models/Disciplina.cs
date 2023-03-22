namespace Aula_02.Models;

public class Disciplina
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int CargaHoraria { get; set; }
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
}
