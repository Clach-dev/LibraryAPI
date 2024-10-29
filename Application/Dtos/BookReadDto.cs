namespace Application.Dtos
{
    public class BookReadDto
    {
        public Guid Id { get; set; }

        public string ISBN { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
