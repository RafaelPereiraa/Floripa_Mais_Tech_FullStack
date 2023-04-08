using System.Reflection.Metadata;

namespace Ex.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public string Answer { get; set; }
        public byte[]? Image { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }

        public Questions Question { get; set; }
        public Students Student { get; set; }
    }
}
