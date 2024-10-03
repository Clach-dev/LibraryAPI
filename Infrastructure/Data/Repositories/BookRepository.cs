using Domain.Entities;
using Application.IRepositories;

namespace Infrastructure.Data.Repositories
{
    public class BookRepository(AppDbContext context) : BaseRepository<Book>(context), IBookRepository
    {
    }
}
