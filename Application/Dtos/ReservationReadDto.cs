namespace Application.Dtos
{
    public class ReservationReadDto
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Guid UserId { get; set; }

        public DateTime ReceiptDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}