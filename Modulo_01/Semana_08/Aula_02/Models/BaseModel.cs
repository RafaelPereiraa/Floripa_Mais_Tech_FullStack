namespace Aula_02.Models;

public abstract class BaseModel
{
    public int Id { get; set; }
    public DateTime DataDeInclusao { get; set; }
    public DateTime DataDeAlteracao { get; set; }
}
