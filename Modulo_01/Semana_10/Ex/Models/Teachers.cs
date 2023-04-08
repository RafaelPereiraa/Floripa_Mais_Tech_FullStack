namespace Ex.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; }

        public Users User { get; set; }
        public ICollection<Disciplines> Disciplines { get; set; }
    }
}
