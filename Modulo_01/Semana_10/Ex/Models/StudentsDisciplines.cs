namespace Ex.Models
{
    public class StudentsDisciplines
    {

        public int StudentId { get; set; }
        public int DisciplineId { get; set; }

        public Students Student { get; set; }
        public Disciplines Discipline { get; set; }

    }
}
