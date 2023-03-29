namespace EX_01.models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public decimal Peso_Nascimento { get; set; }
        public int Altura { get; set; }

        public int Id_Mae { get; set; }
        public Mae Mae { get; set; }

        public int Id_Parto { get; set; }
        public Parto Parto { get; set; }
    }
}
