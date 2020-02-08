using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.API.Domain.Services.Communication;
using Booking.Models;

namespace Booking.Services
{
    public interface ISeatService
    {
        Task<IEnumerable<Seat>> ListAsync();
        Task<SeatResponse> SaveAsync(Seat seat);
    }
}