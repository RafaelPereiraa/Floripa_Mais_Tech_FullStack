namespace Ex.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }

        public Teachers Teacher { get; set; }
        public Students Student { get; set; }

    }
}
