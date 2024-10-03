using Domain.Entities;
using Application.IRepositories;

namespace Infrastructure.Data.Repositories
{
    public class AuthorRepository(AppDbContext context) : BaseRepository<Author>(context), IAuthorRepository
    {
    }
}
