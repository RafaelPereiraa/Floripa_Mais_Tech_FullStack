namespace Ex.Models
{
    public class Students
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Period { get; set; }
        public int RA { get; set; }

        public Users User { get; set; }
        public ICollection<StudentsDisciplines> StudentDisciplines { get; set; }
        public ICollection<Answers> Answers { get; set; }
    }
}
