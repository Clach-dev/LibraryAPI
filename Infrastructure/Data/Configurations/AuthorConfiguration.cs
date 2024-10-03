using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(author => author.Id);
            builder.Property(author => author.FirstName).IsRequired(true);
            builder.Property(author => author.LastName).IsRequired(true);
            builder.Property(author => author.Patrynomic).IsRequired(false);
            builder.Property(author => author.Description).IsRequired(true);

            builder.HasMany(author => author.Books).WithMany(book => book.Authors);
        }
    }
}
