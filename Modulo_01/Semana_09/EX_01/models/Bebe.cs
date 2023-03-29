namespace EX_01.models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal PesoNascimento { get; set; }
        public int Altura { get; set; }
        public int MaeId { get; set; }
        public Mae Mae { get; set; }
        public int PartoId { get; set; }
        public Parto Parto { get; set; }
    }
}
