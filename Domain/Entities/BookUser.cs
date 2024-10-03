﻿namespace Domain.Entities
{
    public class BookUser
    {
        public Guid BookUserId { get; set; }
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
