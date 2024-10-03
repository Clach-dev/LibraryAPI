using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class BookUserConfiguration : IEntityTypeConfiguration<BookUser>
    {
        public void Configure(EntityTypeBuilder<BookUser> builder)
        {
            builder.HasKey(bookUser => bookUser.BookUserId);
            builder.Property(bookUser => bookUser.ReceiptDate).IsRequired(true);
            builder.Property(bookUser => bookUser.ReturnDate).IsRequired(true);

            builder.HasOne(bookUser => bookUser.Book).WithMany(book => book.BookUsers);
            builder.HasOne(bookUser => bookUser.User).WithMany(user => user.BookUsers);
        }
    }
}
