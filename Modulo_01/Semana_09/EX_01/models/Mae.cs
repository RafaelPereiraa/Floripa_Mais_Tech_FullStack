namespace EX_01.models
{
    public class Mae
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }

        public List<Bebe> Bebes { get; set; }
    }
}
