using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(user => user.Id);
            builder.Property(user => user.Login).IsRequired(true);
            builder.Property(user => user.Password).IsRequired(true);
            builder.Property(user => user.FirstName).IsRequired(true);
            builder.Property(user => user.LastName).IsRequired(true);
            builder.Property(user => user.Patrynomic).IsRequired(false);
            builder.Property(user => user.Birthday).IsRequired(true);
            builder.Property(user => user.Role).IsRequired(true);

            builder.HasMany(user => user.BookUsers).WithOne(bookUser => bookUser.User).HasForeignKey(bookUser => bookUser.UserId);
        }
    }
}
