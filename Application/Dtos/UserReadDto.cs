namespace Application.Dtos
{
    public class UserReadDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Patrynomic { get; set; }

        public DateTime Birthday { get; set; }

        public string Role { get; set; }
    }
}