using Domain.Entities;
using Application.IRepositories;


namespace Infrastructure.Data.Repositories
{
    public class UserRepository(AppDbContext context) : BaseRepository<User>(context), IUserRepository
    {
    }
}
