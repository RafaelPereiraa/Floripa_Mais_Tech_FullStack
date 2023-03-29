namespace EX_01.models
{
    public class Parto
    {
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        public DateTime DataParto { get; set; }
        public TimeSpan HorarioParto { get; set; }
        public List<Bebe> Bebes { get; set; }

        public void Display()
        {
            // Código para exibir as informações desejadas
        }
    }
}
