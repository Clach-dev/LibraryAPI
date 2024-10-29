using Domain.Entities;
using Application.IRepositories;


namespace Infrastructure.Data.Repositories
{
    public class ReservationRepository(AppDbContext context) : BaseRepository<Reservation>(context), IReservationRepository
    {
    }
}
