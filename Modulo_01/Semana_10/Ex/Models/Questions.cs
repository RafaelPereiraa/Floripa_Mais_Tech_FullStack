namespace Ex.Models
{
    public class Questions
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
        
        public Quizs Quizs { get; set; }
        public ICollection<Answers> Answers { get; set; }
    }
}
