using Ex.Models.Configurations;

namespace Ex.Models
{
    public class Disciplines
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public int TeacherId { get; set; }
        public string Name { get; set; }

        public Teachers Teachers { get; set; }
        public List<StudentsDisciplines> StudentsDisciplines{ get; set; }
        public List<Quizs> Quizs { get; set; }
    }
}
