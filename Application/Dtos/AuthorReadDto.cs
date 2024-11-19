namespace Application.Dtos
{
    public class AuthorReadDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Patrynomic { get; set; }

        public string Description { get; set; }
    }
}