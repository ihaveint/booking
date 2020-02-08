using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.Communication;
using Booking.Models;

namespace Booking.Services
{
    public interface ISeatService
    {
        Task<IEnumerable<Seat>> ListAsync();
        Task<SeatResponse> SaveAsync(Seat seat);
    }
}