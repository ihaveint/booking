using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.Communication;
using Booking.Models;

namespace Booking.Services
{
    public interface ISalonService
    {
        Task<IEnumerable<Salon>> ListAsync();
        Task<SalonResponse> SaveAsync(Salon salon);
    }
}