namespace WorlEvgen.DAL.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Rating { get; set; }

        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
