using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.Models;

namespace Booking.Repositories
{
    public interface ISeatRepository
    {
        Task<IEnumerable<Seat>> ListAsync();
        Task AddAsync(Seat seat);
        Task<Seat> FindByIdAsync(int id);
    }
}