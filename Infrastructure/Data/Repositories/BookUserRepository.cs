using Domain.Entities;
using Application.IRepositories;


namespace Infrastructure.Data.Repositories
{
    public class BookUserRepository(AppDbContext context) : BaseRepository<BookUser>(context), IBookUserRepository
    {
    }
}
