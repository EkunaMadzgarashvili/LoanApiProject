namespace FinalProject2.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public bool isBlocked { get; set; } = false;
        public string Password { get; set; }
        public string Role { get; set; }

        public string ID { get; set; }
    }
}
