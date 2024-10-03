using Domain.Entities;
using Application.IRepositories;


namespace Infrastructure.Data.Repositories
{
    public class GenreRepository(AppDbContext context) : BaseRepository<Genre>(context), IGenreRepository
    {
    }
}
