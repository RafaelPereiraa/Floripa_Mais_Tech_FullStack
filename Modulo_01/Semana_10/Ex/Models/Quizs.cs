namespace Ex.Models
{
    public class Quizs
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }

        public Disciplines Discipline { get; set; }
        public ICollection<Questions> Questions{ get; set; }
    }
}
