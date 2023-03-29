namespace EX_01.models
{
    public class Medico
    {
        public int Id { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Especialidade { get; set; }
        public List<Parto> Partos { get; set; }
    }
}
